namespace FurnitureDatabaseUtility
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
                    // Делаем что-то с полученными данными (например, выводим в MessageBox)
                }
            }
        }
    }
}
