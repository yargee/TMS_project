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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            PricesDataGridView = new DataGridView();
            TempDeleteElements = new Button();
            ElementsDataGridView = new DataGridView();
            CollectionsDataGridView = new DataGridView();
            collectionIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            furnitureCollectionBindingSource1 = new BindingSource(components);
            CollectionAddButton = new Button();
            tabPage2 = new TabPage();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            TempXMLDataView = new DataGridView();
            SelectPriceFileButton = new Button();
            furnitureElementBindingSource1 = new BindingSource(components);
            furnitureElementBindingSource = new BindingSource(components);
            furnitureCollectionBindingSource = new BindingSource(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PricesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ElementsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CollectionsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)furnitureCollectionBindingSource1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TempXMLDataView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)furnitureElementBindingSource1).BeginInit();
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
            tabControl1.Size = new Size(1040, 752);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Khaki;
            tabPage1.Controls.Add(PricesDataGridView);
            tabPage1.Controls.Add(TempDeleteElements);
            tabPage1.Controls.Add(ElementsDataGridView);
            tabPage1.Controls.Add(CollectionsDataGridView);
            tabPage1.Controls.Add(CollectionAddButton);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(1032, 724);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Коллекция";
            // 
            // PricesDataGridView
            // 
            PricesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            PricesDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            PricesDataGridView.Location = new Point(740, 5);
            PricesDataGridView.Name = "PricesDataGridView";
            PricesDataGridView.ReadOnly = true;
            PricesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PricesDataGridView.Size = new Size(287, 337);
            PricesDataGridView.TabIndex = 4;
            // 
            // TempDeleteElements
            // 
            TempDeleteElements.Location = new Point(7, 86);
            TempDeleteElements.Margin = new Padding(2);
            TempDeleteElements.Name = "TempDeleteElements";
            TempDeleteElements.Size = new Size(89, 67);
            TempDeleteElements.TabIndex = 3;
            TempDeleteElements.Text = "Очистить элементы";
            TempDeleteElements.UseVisualStyleBackColor = true;
            TempDeleteElements.Click += TempDeleteElements_Click;
            // 
            // ElementsDataGridView
            // 
            ElementsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ElementsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            ElementsDataGridView.Location = new Point(391, 3);
            ElementsDataGridView.Name = "ElementsDataGridView";
            ElementsDataGridView.ReadOnly = true;
            ElementsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ElementsDataGridView.Size = new Size(343, 650);
            ElementsDataGridView.TabIndex = 2;
            ElementsDataGridView.SelectionChanged += ElementsDataGridView_SelectionChanged;
            // 
            // CollectionsDataGridView
            // 
            CollectionsDataGridView.AutoGenerateColumns = false;
            CollectionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CollectionsDataGridView.Columns.AddRange(new DataGridViewColumn[] { collectionIdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn });
            CollectionsDataGridView.DataSource = furnitureCollectionBindingSource1;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            CollectionsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            CollectionsDataGridView.Location = new Point(101, 3);
            CollectionsDataGridView.Name = "CollectionsDataGridView";
            CollectionsDataGridView.ReadOnly = true;
            CollectionsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CollectionsDataGridView.Size = new Size(284, 650);
            CollectionsDataGridView.TabIndex = 1;
            CollectionsDataGridView.SelectionChanged += CollectionsDataGridView_SelectionChanged;
            // 
            // collectionIdDataGridViewTextBoxColumn
            // 
            collectionIdDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            collectionIdDataGridViewTextBoxColumn.DataPropertyName = "CollectionId";
            collectionIdDataGridViewTextBoxColumn.HeaderText = "CollectionId";
            collectionIdDataGridViewTextBoxColumn.Name = "collectionIdDataGridViewTextBoxColumn";
            collectionIdDataGridViewTextBoxColumn.ReadOnly = true;
            collectionIdDataGridViewTextBoxColumn.Width = 96;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 64;
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
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(TempXMLDataView);
            tabPage2.Controls.Add(SelectPriceFileButton);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(1797, 724);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Парсинг";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(22, 158);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(1303, 558);
            textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(383, 99);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(261, 40);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 99);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 40);
            textBox1.TabIndex = 2;
            // 
            // TempXMLDataView
            // 
            TempXMLDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TempXMLDataView.Location = new Point(158, 18);
            TempXMLDataView.Name = "TempXMLDataView";
            TempXMLDataView.Size = new Size(974, 44);
            TempXMLDataView.TabIndex = 1;
            // 
            // SelectPriceFileButton
            // 
            SelectPriceFileButton.Location = new Point(22, 18);
            SelectPriceFileButton.Name = "SelectPriceFileButton";
            SelectPriceFileButton.Size = new Size(117, 44);
            SelectPriceFileButton.TabIndex = 0;
            SelectPriceFileButton.Text = "Выбрать прайс";
            SelectPriceFileButton.UseVisualStyleBackColor = true;
            SelectPriceFileButton.Click += SelectPriceFileButton_Click;
            // 
            // furnitureElementBindingSource1
            // 
            furnitureElementBindingSource1.DataSource = typeof(FurnitureElement);
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
            ClientSize = new Size(1040, 752);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "PERFORMA.VIP";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PricesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ElementsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)CollectionsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)furnitureCollectionBindingSource1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TempXMLDataView).EndInit();
            ((System.ComponentModel.ISupportInitialize)furnitureElementBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)furnitureElementBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)furnitureCollectionBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button CollectionAddButton;
        private DataGridView CollectionsDataGridView;
        private DataGridView ElementsDataGridView;
        private BindingSource furnitureCollectionBindingSource;
        private BindingSource furnitureElementBindingSource;
        private BindingSource furnitureCollectionBindingSource1;
        private BindingSource furnitureElementBindingSource1;
        private TabPage tabPage2;
        private Button SelectPriceFileButton;
        private DataGridView TempXMLDataView;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button TempDeleteElements;
        private TextBox textBox3;
        private DataGridViewTextBoxColumn collectionIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridView PricesDataGridView;
    }
}
