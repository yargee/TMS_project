using FurnitureDatabaseFiller.Data;

namespace FurnitureDatabaseUtility
{
    public partial class CollectionInputDialogForm : Form
    {
        public CollectionInputDialogForm()
        {
            InitializeComponent();
        }

        private void CollectionAddButton_Click(object sender, EventArgs e)
        {
            var collection = new FurnitureCollection(CollectionIdInputField.Text, CollectionNameInputField.Text);
            MessageBox.Show($"Вы добавили коллекцию {collection.Id} {collection.Name}");
            //обращение к репозиторию и добавление в бд
        }
    }
}
