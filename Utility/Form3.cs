using System;
using System.Collections.Generic;
namespace Utility
{
    public partial class ElementlInputDialogForm : Form
    {
        public string ElementId { get; private set; }
        public string CollectionId { get; private set; }
        public string ElementName { get; private set; }
        public string ElementDescription { get; private set; }


        public ElementlInputDialogForm()
        {
            InitializeComponent();
        }

        private void ModelAddApproveButton_Click(object sender, EventArgs e)
        {
            ElementId = ElementIdInputField.Text;
            CollectionId = CollectionIdComboBox.Text;
            ElementName = ElementNameInputField.Text;
            ElementDescription = ElementDescriptionInputField.Text;
        }

        private void ElementlInputDialogForm_Load(object sender, EventArgs e)
        {
            using (var context = new UtilityDbContext())
            {
                var collectionIds = context.Collections.Select(x => x.CollectionId).ToList();
                CollectionIdComboBox.DataSource = collectionIds;
            }
        }
    }
}
