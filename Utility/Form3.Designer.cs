namespace Utility
{
    partial class ElementlInputDialogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ModelAddApproveButton = new Button();
            ElementNameInputField = new TextBox();
            ModelNameInputLabel = new Label();
            ModelIdInputLabel = new Label();
            ModelDescriptionInputLabel = new Label();
            ElementDescriptionInputField = new TextBox();
            ModelCollectionIdInputLabel = new Label();
            CollectionIdViewLabel = new Label();
            ElementIdInputField = new TextBox();
            CollectionIdComboBox = new ComboBox();
            furnitureCollectionBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)furnitureCollectionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // ModelAddApproveButton
            // 
            ModelAddApproveButton.DialogResult = DialogResult.OK;
            ModelAddApproveButton.Location = new Point(111, 126);
            ModelAddApproveButton.Name = "ModelAddApproveButton";
            ModelAddApproveButton.Size = new Size(144, 39);
            ModelAddApproveButton.TabIndex = 9;
            ModelAddApproveButton.Text = "Добавить элемент";
            ModelAddApproveButton.UseVisualStyleBackColor = true;
            ModelAddApproveButton.Click += ModelAddApproveButton_Click;
            // 
            // ElementNameInputField
            // 
            ElementNameInputField.Location = new Point(111, 10);
            ElementNameInputField.Name = "ElementNameInputField";
            ElementNameInputField.Size = new Size(144, 23);
            ElementNameInputField.TabIndex = 8;
            // 
            // ModelNameInputLabel
            // 
            ModelNameInputLabel.AutoSize = true;
            ModelNameInputLabel.Location = new Point(15, 13);
            ModelNameInputLabel.Name = "ModelNameInputLabel";
            ModelNameInputLabel.Size = new Size(59, 15);
            ModelNameInputLabel.TabIndex = 7;
            ModelNameInputLabel.Text = "Название";
            // 
            // ModelIdInputLabel
            // 
            ModelIdInputLabel.AutoSize = true;
            ModelIdInputLabel.Location = new Point(12, 100);
            ModelIdInputLabel.Name = "ModelIdInputLabel";
            ModelIdInputLabel.Size = new Size(18, 15);
            ModelIdInputLabel.TabIndex = 6;
            ModelIdInputLabel.Text = "ID";
            // 
            // ModelDescriptionInputLabel
            // 
            ModelDescriptionInputLabel.AutoSize = true;
            ModelDescriptionInputLabel.Location = new Point(12, 42);
            ModelDescriptionInputLabel.Name = "ModelDescriptionInputLabel";
            ModelDescriptionInputLabel.Size = new Size(62, 15);
            ModelDescriptionInputLabel.TabIndex = 10;
            ModelDescriptionInputLabel.Text = "Описание";
            // 
            // ElementDescriptionInputField
            // 
            ElementDescriptionInputField.Location = new Point(111, 39);
            ElementDescriptionInputField.Name = "ElementDescriptionInputField";
            ElementDescriptionInputField.Size = new Size(144, 23);
            ElementDescriptionInputField.TabIndex = 11;
            // 
            // ModelCollectionIdInputLabel
            // 
            ModelCollectionIdInputLabel.AutoSize = true;
            ModelCollectionIdInputLabel.Location = new Point(12, 71);
            ModelCollectionIdInputLabel.Name = "ModelCollectionIdInputLabel";
            ModelCollectionIdInputLabel.Size = new Size(81, 15);
            ModelCollectionIdInputLabel.TabIndex = 12;
            ModelCollectionIdInputLabel.Text = "ID коллекции";
            // 
            // CollectionIdViewLabel
            // 
            CollectionIdViewLabel.AutoSize = true;
            CollectionIdViewLabel.Location = new Point(36, 97);
            CollectionIdViewLabel.Name = "CollectionIdViewLabel";
            CollectionIdViewLabel.Size = new Size(0, 15);
            CollectionIdViewLabel.TabIndex = 13;
            // 
            // ElementIdInputField
            // 
            ElementIdInputField.Location = new Point(111, 97);
            ElementIdInputField.Name = "ElementIdInputField";
            ElementIdInputField.Size = new Size(144, 23);
            ElementIdInputField.TabIndex = 14;
            // 
            // CollectionIdComboBox
            // 
            CollectionIdComboBox.DataSource = furnitureCollectionBindingSource;
            CollectionIdComboBox.DisplayMember = "CollectionId";
            CollectionIdComboBox.FormattingEnabled = true;
            CollectionIdComboBox.Location = new Point(111, 68);
            CollectionIdComboBox.Name = "CollectionIdComboBox";
            CollectionIdComboBox.Size = new Size(144, 23);
            CollectionIdComboBox.TabIndex = 15;
            // 
            // furnitureCollectionBindingSource
            // 
            furnitureCollectionBindingSource.DataSource = typeof(FurnitureCollection);
            // 
            // ElementlInputDialogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 178);
            Controls.Add(CollectionIdComboBox);
            Controls.Add(ElementIdInputField);
            Controls.Add(CollectionIdViewLabel);
            Controls.Add(ModelCollectionIdInputLabel);
            Controls.Add(ElementDescriptionInputField);
            Controls.Add(ModelDescriptionInputLabel);
            Controls.Add(ModelAddApproveButton);
            Controls.Add(ElementNameInputField);
            Controls.Add(ModelNameInputLabel);
            Controls.Add(ModelIdInputLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ElementlInputDialogForm";
            Text = "Ввод модели";
            Load += ElementlInputDialogForm_Load;
            ((System.ComponentModel.ISupportInitialize)furnitureCollectionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ModelAddApproveButton;
        private TextBox ElementNameInputField;
        private Label ModelNameInputLabel;
        private Label ModelIdInputLabel;
        private Label ModelDescriptionInputLabel;
        private TextBox ElementDescriptionInputField;
        private Label ModelCollectionIdInputLabel;
        private Label CollectionIdViewLabel;
        private TextBox ElementIdInputField;
        private ComboBox CollectionIdComboBox;
        private BindingSource furnitureCollectionBindingSource;
    }
}