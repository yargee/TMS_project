using ClosedXML.Excel;
using System.Text;
using Utility.IDChecker;

namespace Utility
{
    public partial class Form1 : Form
    {
        UtilityDbContext context = new UtilityDbContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Add_collection_btn_Click(object sender, EventArgs e)
        {
            using (var input = new CollectionInputDialogForm())
            {
                if (input.ShowDialog() == DialogResult.OK
                    && input.CollectionId != string.Empty
                    && input.CollectionName != string.Empty)
                {
                    var data = new FurnitureCollection(input.CollectionId, input.CollectionName);
                    context.Add(data);
                    context.SaveChanges();
                    UpdateGridView(context);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            UpdateGridView(context);
            CollectionsDataGridView.ClearSelection();
            ElementsDataGridView.Columns.Clear();
        }

        private void UpdateGridView(UtilityDbContext context)
        {
            var collectionsData = context.Collections.ToList();
            var elementsData = context.Elements.ToList();

            CollectionsDataGridView.DataSource = collectionsData;
            ElementsDataGridView.DataSource = elementsData;
        }

        private void CollectionsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            ElementsDataGridView.Visible = true;

            if (CollectionsDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = CollectionsDataGridView.SelectedRows[0];
                string targetId = selectedRow.Cells[0].Value.ToString();

                using (var context = new UtilityDbContext())
                {
                    ElementsDataGridView.DataSource = context.Elements.Where(x => x.CollectionId == targetId).ToList();
                    ElementsDataGridView.Columns.Clear();
                    var idColumn = new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "ElementId" };
                    var nameColumn = new DataGridViewTextBoxColumn { HeaderText = "Название", DataPropertyName = "Name" };
                    //idColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    //idColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    //nameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    //nameColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                    ElementsDataGridView.Columns.Add(idColumn);
                    ElementsDataGridView.Columns.Add(nameColumn);


                }
            }
        }
        
        private void ElementsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            PricesDataGridView.Visible = true;

            if (ElementsDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = ElementsDataGridView.SelectedRows[0];
                string targetId = selectedRow.Cells[0].Value.ToString();

                using (var context = new UtilityDbContext())
                {
                    var prices = context.ElementsPrice.Where(x => x.ElementId == targetId).ToList();
                    PricesDataGridView.DataSource = prices;
                    PricesDataGridView.Columns.Clear();
                    PricesDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "ElementId" });

                    for(int i = 0; i < prices.Count; i++)
                    {
                        PricesDataGridView.Columns.Add(new DataGridViewTextBoxColumn{ HeaderText = $"Category {prices[i].Category}", DataPropertyName = $"{prices[i].Category}" });
                    }

                }
            }
        }

        private void SelectPriceFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файлы Excel|*.xlsx;*.xls";
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                using (var workbook = new XLWorkbook(selectedFilePath))
                {
                    var worksheet = workbook.Worksheet(1);
                    var rows = worksheet.RowsUsed();
                    var columns = worksheet.ColumnsUsed();
                    var equalizer = new StringEqualizer();

                    for (int i = 1; i <= rows.Count(); i++)
                    {
                        for (int j = 1; j <= columns.Count(); j++)
                        {
                            var stringValue = equalizer.ReplaceEnglishLetters(worksheet.Cell(i, j).Value.ToString());

                            if (!IsTargetRow(stringValue, out string name))
                            {
                                textBox2.AppendText("строка выхода из цикла " + i + " " + name + Environment.NewLine);
                                break;
                            }

                            if (TryFindCollection(stringValue, out FurnitureCollection collection))
                            {
                                var elementData = new StringBuilder();
                                elementData.Append(collection.CollectionId + "@" /*артикул коллекции*/
                                                 + worksheet.Cell(i, j - 1).Value.ToString() + "@"  /*имя элемента*/
                                                 + worksheet.Cell(i, j).Value.ToString() + "@"); /*артикул элемента*/

                                string collectionId = "";
                                string elementId = "";
                                string elementName = "";

                                List<ElementPrice> prices = new();

                                for (int k = j + 1; k <= columns.Count(); k++)
                                {
                                    if (worksheet.Cell(i, k).Value.IsNumber)
                                    {
                                        elementData.Append((int)worksheet.Cell(i, k).Value + "@");

                                        var data = elementData.ToString().Split('@');

                                        for (int n = 0; n < data.Length; n++)
                                        {
                                            switch (n)
                                            {
                                                case 0:
                                                    collectionId = data[n];
                                                    break;
                                                case 1:
                                                    elementName = data[n];
                                                    break;
                                                case 2:
                                                    elementId = data[n];
                                                    break;
                                                default:
                                                    {
                                                        int.TryParse(data[n], out int price);
                                                        prices.Add(new ElementPrice(elementId, n, price));
                                                    }
                                                    break;
                                            }
                                        }
                                    }
                                }

                                var element = new FurnitureElement(collectionId, elementId, elementName);
                                textBox3.AppendText("add element " + elementId + Environment.NewLine);

                                foreach (var price in prices)
                                {
                                    element.Prices.Add(price);
                                }

                                context.Add(element);
                                context.SaveChanges();

                                i++;
                                j = 0;
                                textBox1.AppendText(collectionId + "//" + elementId + Environment.NewLine);
                                elementData = null;
                            }
                        }
                    }
                }
            }
        }

        private bool TryFindCollection(string s, out FurnitureCollection collection)
        {
            collection = context.Collections.FirstOrDefault(x => (s.Contains(x.CollectionId) || s.Equals(x.CollectionId)));

            if (collection != null)
            {
                textBox3.AppendText($"TFC  !{s}!  !{collection.Name}! {Environment.NewLine}");
            }
            else
            {
                textBox3.AppendText($"FALSE !{s}!  NOT COLLECTION {Environment.NewLine}");
            }

            return collection != null ? true : false;

        }

        private bool IsTargetRow(string s, out string name)
        {
            var strings = s.Split(' ');

            foreach (var unit in strings)
            {
                var collection = context.Collections.FirstOrDefault(x => unit.Equals(x.Name));

                if (collection != null)
                {
                    name = collection.Name;
                    return false;
                }
            }

            name = "no collections";

            return true;
        }

        private void TempDeleteElements_Click(object sender, EventArgs e)
        {
            foreach (var el in context.Elements)
            {
                context.Elements.Remove(el);
                context.SaveChanges();
            }
        }
    }
}
