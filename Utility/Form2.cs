namespace Utility
{
    public partial class CollectionInputDialogForm : Form
    {
        public string CollectionId { get; private set; }
        public string CollectionName { get; private set; }

        public CollectionInputDialogForm()
        {
            InitializeComponent();
        }

        private void CollectionAddButton_Click(object sender, EventArgs e)
        {
            CollectionId = CollectionIdInputField.Text;
            CollectionName = CollectionNameInputField.Text;

            var collection = new FurnitureCollection(CollectionId, CollectionName);

            CollectionId = null;
            CollectionName = null;
        }
    }
}
