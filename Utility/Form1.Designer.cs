namespace Utility
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            ModelAddButton = new Button();
            ElementsDataGridView = new DataGridView();
            elementIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            furnitureElementBindingSource1 = new BindingSource(components);
            CollectionsDataGridView = new DataGridView();
            collectionIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            furnitureCollectionBindingSource1 = new BindingSource(components);
            CollectionAddButton = new Button();
            tabPage2 = new TabPage();
            change_model_btn = new Button();
            add_model_btn = new Button();
            furnitureElementBindingSource = new BindingSource(components);
            furnitureCollectionBindingSource = new BindingSource(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ElementsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)furnitureElementBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CollectionsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)furnitureCollectionBindingSource1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)furnitureElementBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)furnitureCollectionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(728, 266);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ModelAddButton);
            tabPage1.Controls.Add(ElementsDataGridView);
            tabPage1.Controls.Add(CollectionsDataGridView);
            tabPage1.Controls.Add(CollectionAddButton);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(720, 238);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Коллекция";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // ModelAddButton
            // 
            ModelAddButton.Location = new Point(7, 75);
            ModelAddButton.Margin = new Padding(2);
            ModelAddButton.Name = "ModelAddButton";
            ModelAddButton.Size = new Size(89, 62);
            ModelAddButton.TabIndex = 4;
            ModelAddButton.Text = "Добавить модель";
            ModelAddButton.UseVisualStyleBackColor = true;
            ModelAddButton.Click += ModelAddButton_Click;
            // 
            // ElementsDataGridView
            // 
            ElementsDataGridView.AutoGenerateColumns = false;
            ElementsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ElementsDataGridView.Columns.AddRange(new DataGridViewColumn[] { elementIdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn1, descriptionDataGridViewTextBoxColumn });
            ElementsDataGridView.DataSource = furnitureElementBindingSource1;
            ElementsDataGridView.Location = new Point(357, 3);
            ElementsDataGridView.Name = "ElementsDataGridView";
            ElementsDataGridView.ReadOnly = true;
            ElementsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ElementsDataGridView.Size = new Size(355, 217);
            ElementsDataGridView.TabIndex = 2;
            ElementsDataGridView.Visible = false;
            // 
            // elementIdDataGridViewTextBoxColumn
            // 
            elementIdDataGridViewTextBoxColumn.DataPropertyName = "ElementId";
            elementIdDataGridViewTextBoxColumn.HeaderText = "ElementId";
            elementIdDataGridViewTextBoxColumn.Name = "elementIdDataGridViewTextBoxColumn";
            elementIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // furnitureElementBindingSource1
            // 
            furnitureElementBindingSource1.DataSource = typeof(FurnitureElement);
            // 
            // CollectionsDataGridView
            // 
            CollectionsDataGridView.AutoGenerateColumns = false;
            CollectionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CollectionsDataGridView.Columns.AddRange(new DataGridViewColumn[] { collectionIdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn });
            CollectionsDataGridView.DataSource = furnitureCollectionBindingSource1;
            CollectionsDataGridView.Location = new Point(101, 3);
            CollectionsDataGridView.Name = "CollectionsDataGridView";
            CollectionsDataGridView.ReadOnly = true;
            CollectionsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CollectionsDataGridView.Size = new Size(250, 217);
            CollectionsDataGridView.TabIndex = 1;
            CollectionsDataGridView.SelectionChanged += CollectionsDataGridView_SelectionChanged;
            // 
            // collectionIdDataGridViewTextBoxColumn
            // 
            collectionIdDataGridViewTextBoxColumn.DataPropertyName = "CollectionId";
            collectionIdDataGridViewTextBoxColumn.HeaderText = "CollectionId";
            collectionIdDataGridViewTextBoxColumn.Name = "collectionIdDataGridViewTextBoxColumn";
            collectionIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // furnitureCollectionBindingSource1
            // 
            furnitureCollectionBindingSource1.DataSource = typeof(FurnitureCollection);
            // 
            // CollectionAddButton
            // 
            CollectionAddButton.Location = new Point(7, 4);
            CollectionAddButton.Margin = new Padding(2);
            CollectionAddButton.Name = "CollectionAddButton";
            CollectionAddButton.Size = new Size(89, 67);
            CollectionAddButton.TabIndex = 0;
            CollectionAddButton.Text = "Добавить коллекцию";
            CollectionAddButton.UseVisualStyleBackColor = true;
            CollectionAddButton.Click += Add_collection_btn_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(change_model_btn);
            tabPage2.Controls.Add(add_model_btn);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(855, 311);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Модель";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // change_model_btn
            // 
            change_model_btn.Location = new Point(7, 70);
            change_model_btn.Margin = new Padding(2);
            change_model_btn.Name = "change_model_btn";
            change_model_btn.Size = new Size(167, 62);
            change_model_btn.TabIndex = 2;
            change_model_btn.Text = "Изменить модель";
            change_model_btn.UseVisualStyleBackColor = true;
            // 
            // add_model_btn
            // 
            add_model_btn.Location = new Point(7, 4);
            add_model_btn.Margin = new Padding(2);
            add_model_btn.Name = "add_model_btn";
            add_model_btn.Size = new Size(167, 62);
            add_model_btn.TabIndex = 1;
            add_model_btn.Text = "Добавить модель";
            add_model_btn.UseVisualStyleBackColor = true;
            // 
            // furnitureElementBindingSource
            // 
            furnitureElementBindingSource.DataSource = typeof(FurnitureElement);
            // 
            // furnitureCollectionBindingSource
            // 
            furnitureCollectionBindingSource.DataSource = typeof(FurnitureCollection);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 266);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "PERFORMA.VIP";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ElementsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)furnitureElementBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CollectionsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)furnitureCollectionBindingSource1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)furnitureElementBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)furnitureCollectionBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button CollectionAddButton;
        private Button add_model_btn;
        private Button change_model_btn;
        private DataGridView CollectionsDataGridView;
        private DataGridView ElementsDataGridView;
        private BindingSource furnitureCollectionBindingSource;
        private BindingSource furnitureElementBindingSource;
        private BindingSource furnitureCollectionBindingSource1;
        private BindingSource furnitureElementBindingSource1;
        private Button ModelAddButton;
        private DataGridViewTextBoxColumn elementIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn collectionIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}
