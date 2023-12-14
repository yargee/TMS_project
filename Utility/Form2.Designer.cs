namespace Utility
{
    partial class CollectionInputDialogForm
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
            CollectionIdInputField = new TextBox();
            CollectionIdInputLabel = new Label();
            CollectionNameInputLabel = new Label();
            CollectionNameInputField = new TextBox();
            CollectionAddApproveButton = new Button();
            SuspendLayout();
            // 
            // CollectionIdInputField
            // 
            CollectionIdInputField.Location = new Point(77, 22);
            CollectionIdInputField.Name = "CollectionIdInputField";
            CollectionIdInputField.Size = new Size(144, 23);
            CollectionIdInputField.TabIndex = 0;
            // 
            // CollectionIdInputLabel
            // 
            CollectionIdInputLabel.AutoSize = true;
            CollectionIdInputLabel.Location = new Point(12, 25);
            CollectionIdInputLabel.Name = "CollectionIdInputLabel";
            CollectionIdInputLabel.Size = new Size(18, 15);
            CollectionIdInputLabel.TabIndex = 1;
            CollectionIdInputLabel.Text = "ID";
            // 
            // CollectionNameInputLabel
            // 
            CollectionNameInputLabel.AutoSize = true;
            CollectionNameInputLabel.Location = new Point(12, 54);
            CollectionNameInputLabel.Name = "CollectionNameInputLabel";
            CollectionNameInputLabel.Size = new Size(59, 15);
            CollectionNameInputLabel.TabIndex = 2;
            CollectionNameInputLabel.Text = "Название";
            // 
            // CollectionNameInputField
            // 
            CollectionNameInputField.Location = new Point(77, 46);
            CollectionNameInputField.Name = "CollectionNameInputField";
            CollectionNameInputField.Size = new Size(144, 23);
            CollectionNameInputField.TabIndex = 3;
            // 
            // CollectionAddApproveButton
            // 
            CollectionAddApproveButton.DialogResult = DialogResult.OK;
            CollectionAddApproveButton.Location = new Point(12, 96);
            CollectionAddApproveButton.Name = "CollectionAddApproveButton";
            CollectionAddApproveButton.Size = new Size(209, 39);
            CollectionAddApproveButton.TabIndex = 4;
            CollectionAddApproveButton.Text = "Добавить коллекцию";
            CollectionAddApproveButton.UseVisualStyleBackColor = true;
            CollectionAddApproveButton.Click += CollectionAddButton_Click;
            // 
            // CollectionInputDialogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(236, 147);
            Controls.Add(CollectionAddApproveButton);
            Controls.Add(CollectionNameInputField);
            Controls.Add(CollectionNameInputLabel);
            Controls.Add(CollectionIdInputLabel);
            Controls.Add(CollectionIdInputField);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "CollectionInputDialogForm";
            Text = "Ввод коллекции";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CollectionIdInputField;
        private Label CollectionIdInputLabel;
        private Label CollectionNameInputLabel;
        private TextBox CollectionNameInputField;
        private Button CollectionAddApproveButton;
    }
}