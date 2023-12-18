using Utility.Data;

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
            var priceData = context.ElementsPrice.ToList();

            CollectionsDataGridView.DataSource = collectionsData;
            ElementsDataGridView.DataSource = elementsData;
            PricesDataGridView.DataSource = priceData;
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
                    PricesDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Категория", DataPropertyName = "Category" });
                    PricesDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Стоимость", DataPropertyName = "Price" });
                }
            }
        }

        private void SelectPriceFileButton_Click(object sender, EventArgs e)
        {
            IParsingPattern pattern = new StandartSofaPattern(context, textBox1, textBox2, textBox3);
            pattern.Parse();
        }

        private void TempDeleteElements_Click(object sender, EventArgs e) //сначала удаляем младших зависимых, потом уже старших?
        {
            foreach (var el in context.Elements)
            {
                foreach (var pr in context.ElementsPrice.Where(x => x.ElementId == el.ElementId))
                {
                    context.ElementsPrice.Remove(pr);
                }

                context.Elements.Remove(el);
                context.SaveChanges();
            }
        }
    }
}
