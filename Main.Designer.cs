namespace Lombard
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.товарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ювелирныеИзделияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.техникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сделкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ювелирныеИзделияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.техникаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.databaselomDataSet = new Lombard.DatabaselomDataSet();
            this.jewdealBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jewdealTableAdapter = new Lombard.DatabaselomDataSetTableAdapters.JewdealTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.techdealBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techdealTableAdapter = new Lombard.DatabaselomDataSetTableAdapters.TechdealTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnfam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columntov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnsos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnidi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnfamil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columntovar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnpr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnsost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.выходныеДокументыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ювелирныеИзделияToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.техникаToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaselomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jewdealBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techdealBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.товарыToolStripMenuItem,
            this.сделкаToolStripMenuItem,
            this.выходныеДокументыToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(440, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // товарыToolStripMenuItem
            // 
            this.товарыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ювелирныеИзделияToolStripMenuItem,
            this.техникаToolStripMenuItem});
            this.товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
            this.товарыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.товарыToolStripMenuItem.Text = "Товары";
            // 
            // ювелирныеИзделияToolStripMenuItem
            // 
            this.ювелирныеИзделияToolStripMenuItem.Name = "ювелирныеИзделияToolStripMenuItem";
            this.ювелирныеИзделияToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.ювелирныеИзделияToolStripMenuItem.Text = "Ювелирные изделия";
            this.ювелирныеИзделияToolStripMenuItem.Click += new System.EventHandler(this.ювелирныеИзделияToolStripMenuItem_Click);
            // 
            // техникаToolStripMenuItem
            // 
            this.техникаToolStripMenuItem.Name = "техникаToolStripMenuItem";
            this.техникаToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.техникаToolStripMenuItem.Text = "Техника";
            this.техникаToolStripMenuItem.Click += new System.EventHandler(this.техникаToolStripMenuItem_Click);
            // 
            // сделкаToolStripMenuItem
            // 
            this.сделкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ювелирныеИзделияToolStripMenuItem1,
            this.техникаToolStripMenuItem1});
            this.сделкаToolStripMenuItem.Name = "сделкаToolStripMenuItem";
            this.сделкаToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.сделкаToolStripMenuItem.Text = "Сделка";
            // 
            // ювелирныеИзделияToolStripMenuItem1
            // 
            this.ювелирныеИзделияToolStripMenuItem1.Name = "ювелирныеИзделияToolStripMenuItem1";
            this.ювелирныеИзделияToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.ювелирныеИзделияToolStripMenuItem1.Text = "Ювелирные изделия";
            this.ювелирныеИзделияToolStripMenuItem1.Click += new System.EventHandler(this.ювелирныеИзделияToolStripMenuItem1_Click);
            // 
            // техникаToolStripMenuItem1
            // 
            this.техникаToolStripMenuItem1.Name = "техникаToolStripMenuItem1";
            this.техникаToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.техникаToolStripMenuItem1.Text = "Техника";
            this.техникаToolStripMenuItem1.Click += new System.EventHandler(this.техникаToolStripMenuItem1_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.Columnfam,
            this.Columnname,
            this.Columntov,
            this.Columnprice,
            this.Columnsos});
            this.dataGridView1.Location = new System.Drawing.Point(13, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(775, 137);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // databaselomDataSet
            // 
            this.databaselomDataSet.DataSetName = "DatabaselomDataSet";
            this.databaselomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jewdealBindingSource
            // 
            this.jewdealBindingSource.DataMember = "Jewdeal";
            this.jewdealBindingSource.DataSource = this.databaselomDataSet;
            // 
            // jewdealTableAdapter
            // 
            this.jewdealTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columnidi,
            this.Columnfamil,
            this.ColumnIma,
            this.Columntovar,
            this.Columnpr,
            this.Columnsost});
            this.dataGridView2.Location = new System.Drawing.Point(13, 261);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(775, 137);
            this.dataGridView2.TabIndex = 3;
            // 
            // techdealBindingSource
            // 
            this.techdealBindingSource.DataMember = "Techdeal";
            this.techdealBindingSource.DataSource = this.databaselomDataSet;
            // 
            // techdealTableAdapter
            // 
            this.techdealTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Сделки в категории: Техника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Сделки в категории: Ювелирные изделия";
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            this.ColumnId.Width = 50;
            // 
            // Columnfam
            // 
            this.Columnfam.HeaderText = "Фамилия";
            this.Columnfam.Name = "Columnfam";
            this.Columnfam.ReadOnly = true;
            this.Columnfam.Width = 140;
            // 
            // Columnname
            // 
            this.Columnname.HeaderText = "Имя";
            this.Columnname.Name = "Columnname";
            this.Columnname.ReadOnly = true;
            this.Columnname.Width = 140;
            // 
            // Columntov
            // 
            this.Columntov.HeaderText = "Название товара";
            this.Columntov.Name = "Columntov";
            this.Columntov.ReadOnly = true;
            this.Columntov.Width = 170;
            // 
            // Columnprice
            // 
            this.Columnprice.HeaderText = "Цена";
            this.Columnprice.Name = "Columnprice";
            this.Columnprice.ReadOnly = true;
            this.Columnprice.Width = 120;
            // 
            // Columnsos
            // 
            this.Columnsos.HeaderText = "Состояние сделки";
            this.Columnsos.Name = "Columnsos";
            this.Columnsos.ReadOnly = true;
            this.Columnsos.Width = 160;
            // 
            // Columnidi
            // 
            this.Columnidi.HeaderText = "ID";
            this.Columnidi.Name = "Columnidi";
            this.Columnidi.ReadOnly = true;
            this.Columnidi.Visible = false;
            this.Columnidi.Width = 50;
            // 
            // Columnfamil
            // 
            this.Columnfamil.HeaderText = "Фамилия";
            this.Columnfamil.Name = "Columnfamil";
            this.Columnfamil.ReadOnly = true;
            this.Columnfamil.Width = 140;
            // 
            // ColumnIma
            // 
            this.ColumnIma.HeaderText = "Имя";
            this.ColumnIma.Name = "ColumnIma";
            this.ColumnIma.ReadOnly = true;
            this.ColumnIma.Width = 140;
            // 
            // Columntovar
            // 
            this.Columntovar.HeaderText = "Название товара";
            this.Columntovar.Name = "Columntovar";
            this.Columntovar.ReadOnly = true;
            this.Columntovar.Width = 170;
            // 
            // Columnpr
            // 
            this.Columnpr.HeaderText = "Цена";
            this.Columnpr.Name = "Columnpr";
            this.Columnpr.ReadOnly = true;
            this.Columnpr.Width = 120;
            // 
            // Columnsost
            // 
            this.Columnsost.HeaderText = "Состояние сделки";
            this.Columnsost.Name = "Columnsost";
            this.Columnsost.ReadOnly = true;
            this.Columnsost.Width = 160;
            // 
            // выходныеДокументыToolStripMenuItem
            // 
            this.выходныеДокументыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ювелирныеИзделияToolStripMenuItem2,
            this.техникаToolStripMenuItem2});
            this.выходныеДокументыToolStripMenuItem.Name = "выходныеДокументыToolStripMenuItem";
            this.выходныеДокументыToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.выходныеДокументыToolStripMenuItem.Text = "Выходные документы";
            // 
            // ювелирныеИзделияToolStripMenuItem2
            // 
            this.ювелирныеИзделияToolStripMenuItem2.Name = "ювелирныеИзделияToolStripMenuItem2";
            this.ювелирныеИзделияToolStripMenuItem2.Size = new System.Drawing.Size(188, 22);
            this.ювелирныеИзделияToolStripMenuItem2.Text = "Ювелирные изделия";
            this.ювелирныеИзделияToolStripMenuItem2.Click += new System.EventHandler(this.ювелирныеИзделияToolStripMenuItem2_Click);
            // 
            // техникаToolStripMenuItem2
            // 
            this.техникаToolStripMenuItem2.Name = "техникаToolStripMenuItem2";
            this.техникаToolStripMenuItem2.Size = new System.Drawing.Size(188, 22);
            this.техникаToolStripMenuItem2.Text = "Техника";
            this.техникаToolStripMenuItem2.Click += new System.EventHandler(this.техникаToolStripMenuItem2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Main";
            this.Text = "Ломбард";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaselomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jewdealBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techdealBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem товарыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ювелирныеИзделияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem техникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сделкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem ювелирныеИзделияToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem техникаToolStripMenuItem1;
        public DatabaselomDataSet databaselomDataSet;
        public System.Windows.Forms.BindingSource jewdealBindingSource;
        public DatabaselomDataSetTableAdapters.JewdealTableAdapter jewdealTableAdapter;
        public System.Windows.Forms.BindingSource techdealBindingSource;
        public DatabaselomDataSetTableAdapters.TechdealTableAdapter techdealTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnfam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columntov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnsos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnidi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnfamil;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columntovar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnpr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnsost;
        private System.Windows.Forms.ToolStripMenuItem выходныеДокументыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ювелирныеИзделияToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem техникаToolStripMenuItem2;
    }
}