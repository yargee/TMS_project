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
            ElementsDataGridView = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            collectionIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            furnitureElementBindingSource = new BindingSource(components);
            CollectionsDataGridView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            furnitureCollectionBindingSource = new BindingSource(components);
            Add_collection_btn = new Button();
            tabPage2 = new TabPage();
            change_model_btn = new Button();
            add_model_btn = new Button();
            textBox1 = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ElementsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)furnitureElementBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CollectionsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)furnitureCollectionBindingSource).BeginInit();
            tabPage2.SuspendLayout();
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
            tabControl1.Size = new Size(931, 712);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(ElementsDataGridView);
            tabPage1.Controls.Add(CollectionsDataGridView);
            tabPage1.Controls.Add(Add_collection_btn);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(923, 684);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Коллекция";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // ElementsDataGridView
            // 
            ElementsDataGridView.AutoGenerateColumns = false;
            ElementsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ElementsDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn1, descriptionDataGridViewTextBoxColumn, collectionIdDataGridViewTextBoxColumn });
            ElementsDataGridView.DataSource = furnitureElementBindingSource;
            ElementsDataGridView.Location = new Point(469, 5);
            ElementsDataGridView.Name = "ElementsDataGridView";
            ElementsDataGridView.Size = new Size(444, 217);
            ElementsDataGridView.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // collectionIdDataGridViewTextBoxColumn
            // 
            collectionIdDataGridViewTextBoxColumn.DataPropertyName = "CollectionId";
            collectionIdDataGridViewTextBoxColumn.HeaderText = "CollectionId";
            collectionIdDataGridViewTextBoxColumn.Name = "collectionIdDataGridViewTextBoxColumn";
            // 
            // furnitureElementBindingSource
            // 
            furnitureElementBindingSource.DataSource = typeof(FurnitureElement);
            // 
            // CollectionsDataGridView
            // 
            CollectionsDataGridView.AutoGenerateColumns = false;
            CollectionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CollectionsDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn });
            CollectionsDataGridView.DataSource = furnitureCollectionBindingSource;
            CollectionsDataGridView.Location = new Point(200, 5);
            CollectionsDataGridView.Name = "CollectionsDataGridView";
            CollectionsDataGridView.Size = new Size(245, 217);
            CollectionsDataGridView.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // furnitureCollectionBindingSource
            // 
            furnitureCollectionBindingSource.DataSource = typeof(FurnitureCollection);
            // 
            // Add_collection_btn
            // 
            Add_collection_btn.Location = new Point(7, 4);
            Add_collection_btn.Margin = new Padding(2);
            Add_collection_btn.Name = "Add_collection_btn";
            Add_collection_btn.Size = new Size(188, 67);
            Add_collection_btn.TabIndex = 0;
            Add_collection_btn.Text = "Добавить коллекцию";
            Add_collection_btn.UseVisualStyleBackColor = true;
            Add_collection_btn.Click += Add_collection_btn_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(change_model_btn);
            tabPage2.Controls.Add(add_model_btn);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(923, 409);
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
            // textBox1
            // 
            textBox1.Location = new Point(45, 279);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(844, 23);
            textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 712);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "PERFORMA.VIP";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ElementsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)furnitureElementBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)CollectionsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)furnitureCollectionBindingSource).EndInit();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Add_collection_btn;
        private Button add_model_btn;
        private Button change_model_btn;
        private DataGridView CollectionsDataGridView;
        private DataGridView ElementsDataGridView;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private BindingSource furnitureCollectionBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn collectionIdDataGridViewTextBoxColumn;
        private BindingSource furnitureElementBindingSource;
        private TextBox textBox1;
    }
}
