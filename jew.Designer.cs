namespace Lombard
{
    partial class jew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(jew));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_Jew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lombadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaselomDataSet = new Lombard.DatabaselomDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.jewTableAdapter = new Lombard.DatabaselomDataSetTableAdapters.JewTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.namez = new System.Windows.Forms.TextBox();
            this.prob = new System.Windows.Forms.TextBox();
            this.combosos = new System.Windows.Forms.ComboBox();
            this.comboad = new System.Windows.Forms.ComboBox();
            this.addbut = new System.Windows.Forms.Button();
            this.delbut = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaselomDataSet)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.ID_Jew,
            this.nameTovDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.sostDataGridViewTextBoxColumn,
            this.probaDataGridViewTextBoxColumn,
            this.lombadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.jewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(753, 177);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID_Jew
            // 
            this.ID_Jew.DataPropertyName = "ID_Jew";
            this.ID_Jew.HeaderText = "ID";
            this.ID_Jew.Name = "ID_Jew";
            this.ID_Jew.ReadOnly = true;
            this.ID_Jew.Visible = false;
            // 
            // nameTovDataGridViewTextBoxColumn
            // 
            this.nameTovDataGridViewTextBoxColumn.DataPropertyName = "Name_Tov";
            this.nameTovDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameTovDataGridViewTextBoxColumn.Name = "nameTovDataGridViewTextBoxColumn";
            this.nameTovDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameTovDataGridViewTextBoxColumn.Width = 140;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 110;
            // 
            // sostDataGridViewTextBoxColumn
            // 
            this.sostDataGridViewTextBoxColumn.DataPropertyName = "Sost";
            this.sostDataGridViewTextBoxColumn.HeaderText = "Состояние товара";
            this.sostDataGridViewTextBoxColumn.Name = "sostDataGridViewTextBoxColumn";
            this.sostDataGridViewTextBoxColumn.ReadOnly = true;
            this.sostDataGridViewTextBoxColumn.Width = 150;
            // 
            // probaDataGridViewTextBoxColumn
            // 
            this.probaDataGridViewTextBoxColumn.DataPropertyName = "Proba";
            this.probaDataGridViewTextBoxColumn.HeaderText = "Проба";
            this.probaDataGridViewTextBoxColumn.Name = "probaDataGridViewTextBoxColumn";
            this.probaDataGridViewTextBoxColumn.ReadOnly = true;
            this.probaDataGridViewTextBoxColumn.Width = 140;
            // 
            // lombadDataGridViewTextBoxColumn
            // 
            this.lombadDataGridViewTextBoxColumn.DataPropertyName = "Lomb_ad";
            this.lombadDataGridViewTextBoxColumn.HeaderText = "Адрес ломбарда";
            this.lombadDataGridViewTextBoxColumn.Name = "lombadDataGridViewTextBoxColumn";
            this.lombadDataGridViewTextBoxColumn.ReadOnly = true;
            this.lombadDataGridViewTextBoxColumn.Width = 170;
            // 
            // jewBindingSource
            // 
            this.jewBindingSource.DataMember = "Jew";
            this.jewBindingSource.DataSource = this.databaselomDataSet;
            // 
            // databaselomDataSet
            // 
            this.databaselomDataSet.DataSetName = "DatabaselomDataSet";
            this.databaselomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // jewTableAdapter
            // 
            this.jewTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добавить товар ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Состояние товара";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Проба";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Адрес ломбарда";
            // 
            // namez
            // 
            this.namez.Location = new System.Drawing.Point(75, 43);
            this.namez.Name = "namez";
            this.namez.Size = new System.Drawing.Size(183, 20);
            this.namez.TabIndex = 8;
            // 
            // prob
            // 
            this.prob.Location = new System.Drawing.Point(75, 100);
            this.prob.Name = "prob";
            this.prob.Size = new System.Drawing.Size(183, 20);
            this.prob.TabIndex = 10;
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
            this.combosos.Location = new System.Drawing.Point(107, 130);
            this.combosos.Name = "combosos";
            this.combosos.Size = new System.Drawing.Size(151, 21);
            this.combosos.TabIndex = 11;
            // 
            // comboad
            // 
            this.comboad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboad.FormattingEnabled = true;
            this.comboad.Items.AddRange(new object[] {
            "Туристская улица, 23к5",
            "Богатырский проспект, 51к1"});
            this.comboad.Location = new System.Drawing.Point(107, 158);
            this.comboad.Name = "comboad";
            this.comboad.Size = new System.Drawing.Size(151, 21);
            this.comboad.TabIndex = 12;
            // 
            // addbut
            // 
            this.addbut.Location = new System.Drawing.Point(284, 40);
            this.addbut.Name = "addbut";
            this.addbut.Size = new System.Drawing.Size(146, 39);
            this.addbut.TabIndex = 13;
            this.addbut.Text = "Добавить";
            this.addbut.UseVisualStyleBackColor = true;
            this.addbut.Click += new System.EventHandler(this.addbut_Click);
            // 
            // delbut
            // 
            this.delbut.Location = new System.Drawing.Point(284, 95);
            this.delbut.Name = "delbut";
            this.delbut.Size = new System.Drawing.Size(146, 39);
            this.delbut.TabIndex = 14;
            this.delbut.Text = "Удалить";
            this.delbut.UseVisualStyleBackColor = true;
            this.delbut.Click += new System.EventHandler(this.delbut_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 31;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 30);
            this.button2.TabIndex = 30;
            this.button2.Text = "Поиск по названию";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(588, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Выбор фильтра";
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
            "Проба ˄",
            "Проба ˅",
            "Адрес ломбарда ˄",
            "Адрес ломбарда ˅"});
            this.comboBox1.Location = new System.Drawing.Point(577, 290);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 33;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(577, 323);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 45);
            this.button3.TabIndex = 34;
            this.button3.Text = "Сортировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rice);
            this.panel1.Controls.Add(this.addbut);
            this.panel1.Controls.Add(this.delbut);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.namez);
            this.panel1.Controls.Add(this.prob);
            this.panel1.Controls.Add(this.combosos);
            this.panel1.Controls.Add(this.comboad);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(23, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 185);
            this.panel1.TabIndex = 35;
            // 
            // rice
            // 
            this.rice.Location = new System.Drawing.Point(75, 69);
            this.rice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.rice.Name = "rice";
            this.rice.Size = new System.Drawing.Size(183, 20);
            this.rice.TabIndex = 15;
            // 
            // jew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "jew";
            this.Text = "Ювелирные изделия";
            this.Load += new System.EventHandler(this.jew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaselomDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private DatabaselomDataSet databaselomDataSet;
        private System.Windows.Forms.BindingSource jewBindingSource;
        private DatabaselomDataSetTableAdapters.JewTableAdapter jewTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox namez;
        private System.Windows.Forms.TextBox prob;
        private System.Windows.Forms.ComboBox combosos;
        private System.Windows.Forms.ComboBox comboad;
        private System.Windows.Forms.Button addbut;
        private System.Windows.Forms.Button delbut;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Jew;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameTovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn probaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lombadDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown rice;
    }
}