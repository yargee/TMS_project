using ClosedXML.Excel;
using System.Text;

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
        /*
        private void ModelAddButton_Click(object sender, EventArgs e)
        {
            using (var input = new ElementlInputDialogForm())
            {
                if (input.ShowDialog() == DialogResult.OK
                    && input.ElementId != string.Empty
                    && input.ElementName != string.Empty
                    && input.ElementDescription != string.Empty
                    && input.CollectionId != string.Empty)
                {

                    var data = new FurnitureElement(input.ElementId, input.ElementName, input.ElementDescription, input.CollectionId);
                    context.Add(data);
                    context.SaveChanges();
                    UpdateGridView(context);
                }
            }
        }
        */
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
                    ElementsDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "ElementId" });
                    ElementsDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Название", DataPropertyName = "Name" });
                    ElementsDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Описание", DataPropertyName = "Description" });
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

                    for (int i = 1; i <= rows.Count(); i++)
                    {
                        for (int j = 1; j <= columns.Count(); j++)
                        {
                            var value = worksheet.Cell(i, j).Value;
                            var stringValue = value.ToString();

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

                                List<int> prices = new();

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
                                                        prices.Add(price);
                                                    }
                                                    break;
                                            }
                                        }

                                        for(int m = 0; m < prices.Count; m++)
                                        {
                                            var price = new ElementPrice(elementId, m + 3, prices[m]);
                                            context.Add(price);
                                            context.SaveChanges();
                                        }

                                        var element = new FurnitureElement(collectionId, elementId, elementName);

                                        context.Add(element);
                                        context.SaveChanges();
                                    }
                                }

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
            collection = context.Collections.FirstOrDefault(x => s.Contains(x.CollectionId));

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
    }
}
