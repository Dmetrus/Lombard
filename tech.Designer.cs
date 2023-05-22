namespace Lombard
{
    partial class tech
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tech));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDTechDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nametechDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sostoyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lombadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.techBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaselomDataSet = new Lombard.DatabaselomDataSet();
            this.techTableAdapter = new Lombard.DatabaselomDataSetTableAdapters.TechTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.delbut = new System.Windows.Forms.Button();
            this.addbut = new System.Windows.Forms.Button();
            this.comboad = new System.Windows.Forms.ComboBox();
            this.combosos = new System.Windows.Forms.ComboBox();
            this.namez = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.adel = new System.Windows.Forms.Panel();
            this.rice = new System.Windows.Forms.NumericUpDown();
            this.export = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaselomDataSet)).BeginInit();
            this.adel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rice)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDTechDataGridViewTextBoxColumn,
            this.nametechDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.sostoyDataGridViewTextBoxColumn,
            this.lombadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.techBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(753, 177);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDTechDataGridViewTextBoxColumn
            // 
            this.iDTechDataGridViewTextBoxColumn.DataPropertyName = "ID_Tech";
            this.iDTechDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDTechDataGridViewTextBoxColumn.Name = "iDTechDataGridViewTextBoxColumn";
            this.iDTechDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDTechDataGridViewTextBoxColumn.Visible = false;
            this.iDTechDataGridViewTextBoxColumn.Width = 50;
            // 
            // nametechDataGridViewTextBoxColumn
            // 
            this.nametechDataGridViewTextBoxColumn.DataPropertyName = "Name_tech";
            this.nametechDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nametechDataGridViewTextBoxColumn.Name = "nametechDataGridViewTextBoxColumn";
            this.nametechDataGridViewTextBoxColumn.ReadOnly = true;
            this.nametechDataGridViewTextBoxColumn.Width = 200;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 120;
            // 
            // sostoyDataGridViewTextBoxColumn
            // 
            this.sostoyDataGridViewTextBoxColumn.DataPropertyName = "Sostoy";
            this.sostoyDataGridViewTextBoxColumn.HeaderText = "Состояние товара";
            this.sostoyDataGridViewTextBoxColumn.Name = "sostoyDataGridViewTextBoxColumn";
            this.sostoyDataGridViewTextBoxColumn.ReadOnly = true;
            this.sostoyDataGridViewTextBoxColumn.Width = 180;
            // 
            // lombadDataGridViewTextBoxColumn
            // 
            this.lombadDataGridViewTextBoxColumn.DataPropertyName = "Lomb_ad";
            this.lombadDataGridViewTextBoxColumn.HeaderText = "Адрес ломбарда";
            this.lombadDataGridViewTextBoxColumn.Name = "lombadDataGridViewTextBoxColumn";
            this.lombadDataGridViewTextBoxColumn.ReadOnly = true;
            this.lombadDataGridViewTextBoxColumn.Width = 210;
            // 
            // techBindingSource
            // 
            this.techBindingSource.DataMember = "Tech";
            this.techBindingSource.DataSource = this.databaselomDataSet;
            // 
            // databaselomDataSet
            // 
            this.databaselomDataSet.DataSetName = "DatabaselomDataSet";
            this.databaselomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // techTableAdapter
            // 
            this.techTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(642, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "На главную";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // delbut
            // 
            this.delbut.Location = new System.Drawing.Point(303, 96);
            this.delbut.Name = "delbut";
            this.delbut.Size = new System.Drawing.Size(146, 39);
            this.delbut.TabIndex = 27;
            this.delbut.Text = "Удалить";
            this.delbut.UseVisualStyleBackColor = true;
            this.delbut.Click += new System.EventHandler(this.delbut_Click);
            // 
            // addbut
            // 
            this.addbut.Location = new System.Drawing.Point(303, 33);
            this.addbut.Name = "addbut";
            this.addbut.Size = new System.Drawing.Size(146, 39);
            this.addbut.TabIndex = 26;
            this.addbut.Text = "Добавить";
            this.addbut.UseVisualStyleBackColor = true;
            this.addbut.Click += new System.EventHandler(this.addbut_Click);
            // 
            // comboad
            // 
            this.comboad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboad.FormattingEnabled = true;
            this.comboad.Items.AddRange(new object[] {
            "Туристская улица, 23к5",
            "Богатырский проспект, 51к1"});
            this.comboad.Location = new System.Drawing.Point(101, 121);
            this.comboad.Name = "comboad";
            this.comboad.Size = new System.Drawing.Size(151, 21);
            this.comboad.TabIndex = 25;
            // 
            // combosos
            // 
            this.combosos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combosos.FormattingEnabled = true;
            this.combosos.Items.AddRange(new object[] {
            "Удовлетворительное",
            "Хорошее",
            "Плохое",
            "Есть повреждения"});
            this.combosos.Location = new System.Drawing.Point(102, 94);
            this.combosos.Name = "combosos";
            this.combosos.Size = new System.Drawing.Size(151, 21);
            this.combosos.TabIndex = 24;
            // 
            // namez
            // 
            this.namez.Location = new System.Drawing.Point(70, 33);
            this.namez.Name = "namez";
            this.namez.Size = new System.Drawing.Size(183, 20);
            this.namez.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Адрес ломбарда";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Состояние товара";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Цена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Добавить товар ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 30);
            this.button2.TabIndex = 28;
            this.button2.Text = "Поиск по названию";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 29;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(577, 323);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 45);
            this.button3.TabIndex = 37;
            this.button3.Text = "Сортировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "По умолчанию",
            "Название ˄",
            "Название ˅",
            "Цена ˄",
            "Цена ˅",
            "Состояние товара ˄",
            "Состояние товара ˅",
            "Адрес ломбарда ˄",
            "Адрес ломбарда ˅"});
            this.comboBox1.Location = new System.Drawing.Point(577, 290);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(588, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Выбор фильтра";
            // 
            // adel
            // 
            this.adel.Controls.Add(this.rice);
            this.adel.Controls.Add(this.addbut);
            this.adel.Controls.Add(this.delbut);
            this.adel.Controls.Add(this.label1);
            this.adel.Controls.Add(this.label2);
            this.adel.Controls.Add(this.label3);
            this.adel.Controls.Add(this.namez);
            this.adel.Controls.Add(this.combosos);
            this.adel.Controls.Add(this.comboad);
            this.adel.Controls.Add(this.label4);
            this.adel.Controls.Add(this.label6);
            this.adel.Location = new System.Drawing.Point(23, 253);
            this.adel.Name = "adel";
            this.adel.Size = new System.Drawing.Size(452, 173);
            this.adel.TabIndex = 38;
            // 
            // rice
            // 
            this.rice.Location = new System.Drawing.Point(70, 63);
            this.rice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.rice.Name = "rice";
            this.rice.Size = new System.Drawing.Size(183, 20);
            this.rice.TabIndex = 28;
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(494, 20);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(128, 30);
            this.export.TabIndex = 39;
            this.export.Text = "экспорт";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // tech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.export);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.adel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "tech";
            this.Text = "Техника";
            this.Load += new System.EventHandler(this.tech_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaselomDataSet)).EndInit();
            this.adel.ResumeLayout(false);
            this.adel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaselomDataSet databaselomDataSet;
        private System.Windows.Forms.BindingSource techBindingSource;
        private DatabaselomDataSetTableAdapters.TechTableAdapter techTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button delbut;
        private System.Windows.Forms.Button addbut;
        private System.Windows.Forms.ComboBox comboad;
        private System.Windows.Forms.ComboBox combosos;
        private System.Windows.Forms.TextBox namez;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTechDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nametechDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sostoyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lombadDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel adel;
        private System.Windows.Forms.NumericUpDown rice;
        private System.Windows.Forms.Button export;
    }
}