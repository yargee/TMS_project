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
            using (CollectionInputDialogForm input = new CollectionInputDialogForm())
            {

                if (input.ShowDialog() == DialogResult.OK)
                {
                    using (var context = new UtilityDbContext())
                    {
                        var data = new FurnitureCollection (input.CollectionId,input.CollectionName);
                        textBox1.Text = "insdsadfet";//data.Name + data.Id;
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
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                UpdateGridView(context);
            }
        }

        private void UpdateGridView(UtilityDbContext context)
        {
            var collectionsData = context.Collections.ToList();
            var elementsData = context.Elements.ToList();

            CollectionsDataGridView.DataSource = collectionsData;
            ElementsDataGridView.DataSource = elementsData;

            string text = "";

            foreach(var collection in collectionsData)
            {
                text += collection.CollectionId + "/" + collection.Name + ".";
            }

            textBox1.Text = collectionsData.Count().ToString();
        }
    }
}
