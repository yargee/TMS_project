using System.Windows.Forms;

namespace Utility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_collection_btn_Click(object sender, EventArgs e)
        {
            using (var input = new CollectionInputDialogForm())
            {
                if (input.ShowDialog() == DialogResult.OK
                    &&input.CollectionId != string.Empty
                    && input.CollectionName != string.Empty)
                {
                    using (var context = new UtilityDbContext())
                    {
                        var data = new FurnitureCollection(input.CollectionId, input.CollectionName);
                        context.Add(data);
                        context.SaveChanges();
                        UpdateGridView(context);
                    }
                }
            }
        }

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
                    using (var context = new UtilityDbContext())
                    {
                        var data = new FurnitureElement(input.ElementId, input.ElementName, input.ElementDescription, input.CollectionId);
                        context.Add(data);
                        context.SaveChanges();
                        UpdateGridView(context);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var context = new UtilityDbContext())
            {
                //context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                UpdateGridView(context);
                CollectionsDataGridView.ClearSelection();
                ElementsDataGridView.Visible = false;
            }
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
                }
            }
        }
    }
}
