using Utility.IDChecker;

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
            var equalizer = new StringEqualizer();
            CollectionId = equalizer.ReplaceEnglishLetters(CollectionIdInputField.Text.Trim());
            CollectionName = equalizer.ReplaceEnglishLetters(CollectionNameInputField.Text.Trim());
        }
    }
}
