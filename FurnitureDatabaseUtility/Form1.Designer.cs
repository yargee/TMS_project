namespace FurnitureDatabaseUtility
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            Add_collection_btn = new Button();
            tabPage2 = new TabPage();
            add_model_btn = new Button();
            change_model_btn = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
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
            tabControl1.Size = new Size(400, 291);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(Add_collection_btn);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(392, 263);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Коллекция";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Add_collection_btn
            // 
            Add_collection_btn.Location = new Point(92, 81);
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
            tabPage2.Size = new Size(392, 263);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Модель";
            tabPage2.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 291);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "PERFORMA.VIP";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
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
    }
}

