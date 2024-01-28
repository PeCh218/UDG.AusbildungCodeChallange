namespace UI
{
    partial class CsvReader
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            save = new Button();
            artikelGrid = new DataGridView();
            hauptartikelnrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            artikelnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            herstellerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            beschreibungDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            materialangabenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            geschlechtDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            produktartDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ärmelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            beinDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kragenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            herstellungDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            taschenartDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            grammaturDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            materialDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ursprungslandDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bildnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            artikelBindingSource = new BindingSource(components);
            addArticle = new Button();
            toolTipAdd = new ToolTip(components);
            deleteArticle = new Button();
            labelPC = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)artikelGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)artikelBindingSource).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // save
            // 
            save.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            save.ForeColor = Color.FromArgb(8, 8, 8);
            save.ImageAlign = ContentAlignment.BottomRight;
            save.Location = new Point(1204, 12);
            save.Name = "save";
            save.Size = new Size(94, 29);
            save.TabIndex = 0;
            save.Text = "Save";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // artikelGrid
            // 
            artikelGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            artikelGrid.AutoGenerateColumns = false;
            artikelGrid.BackgroundColor = Color.White;
            artikelGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            artikelGrid.Columns.AddRange(new DataGridViewColumn[] { hauptartikelnrDataGridViewTextBoxColumn, artikelnameDataGridViewTextBoxColumn, herstellerDataGridViewTextBoxColumn, beschreibungDataGridViewTextBoxColumn, materialangabenDataGridViewTextBoxColumn, geschlechtDataGridViewTextBoxColumn, produktartDataGridViewTextBoxColumn, ärmelDataGridViewTextBoxColumn, beinDataGridViewTextBoxColumn, kragenDataGridViewTextBoxColumn, herstellungDataGridViewTextBoxColumn, taschenartDataGridViewTextBoxColumn, grammaturDataGridViewTextBoxColumn, materialDataGridViewTextBoxColumn, ursprungslandDataGridViewTextBoxColumn, bildnameDataGridViewTextBoxColumn });
            artikelGrid.DataSource = artikelBindingSource;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(231, 234, 240);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(8, 8, 8);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(35, 62, 80);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(231, 234, 240);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            artikelGrid.DefaultCellStyle = dataGridViewCellStyle1;
            artikelGrid.GridColor = Color.FromArgb(255, 67, 46);
            artikelGrid.ImeMode = ImeMode.On;
            artikelGrid.Location = new Point(12, 99);
            artikelGrid.MultiSelect = false;
            artikelGrid.Name = "artikelGrid";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(8, 8, 8);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(231, 234, 240);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            artikelGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            artikelGrid.RowHeadersWidth = 51;
            artikelGrid.Size = new Size(1286, 523);
            artikelGrid.TabIndex = 1;
            artikelGrid.CellClick += artikelGrid_CellClick;
            // 
            // hauptartikelnrDataGridViewTextBoxColumn
            // 
            hauptartikelnrDataGridViewTextBoxColumn.DataPropertyName = "Hauptartikelnr";
            hauptartikelnrDataGridViewTextBoxColumn.HeaderText = "Hauptartikelnr";
            hauptartikelnrDataGridViewTextBoxColumn.MinimumWidth = 6;
            hauptartikelnrDataGridViewTextBoxColumn.Name = "hauptartikelnrDataGridViewTextBoxColumn";
            hauptartikelnrDataGridViewTextBoxColumn.Width = 125;
            // 
            // artikelnameDataGridViewTextBoxColumn
            // 
            artikelnameDataGridViewTextBoxColumn.DataPropertyName = "Artikelname";
            artikelnameDataGridViewTextBoxColumn.HeaderText = "Artikelname";
            artikelnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            artikelnameDataGridViewTextBoxColumn.Name = "artikelnameDataGridViewTextBoxColumn";
            artikelnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // herstellerDataGridViewTextBoxColumn
            // 
            herstellerDataGridViewTextBoxColumn.DataPropertyName = "Hersteller";
            herstellerDataGridViewTextBoxColumn.HeaderText = "Hersteller";
            herstellerDataGridViewTextBoxColumn.MinimumWidth = 6;
            herstellerDataGridViewTextBoxColumn.Name = "herstellerDataGridViewTextBoxColumn";
            herstellerDataGridViewTextBoxColumn.Width = 125;
            // 
            // beschreibungDataGridViewTextBoxColumn
            // 
            beschreibungDataGridViewTextBoxColumn.DataPropertyName = "Beschreibung";
            beschreibungDataGridViewTextBoxColumn.HeaderText = "Beschreibung";
            beschreibungDataGridViewTextBoxColumn.MinimumWidth = 6;
            beschreibungDataGridViewTextBoxColumn.Name = "beschreibungDataGridViewTextBoxColumn";
            beschreibungDataGridViewTextBoxColumn.Width = 125;
            // 
            // materialangabenDataGridViewTextBoxColumn
            // 
            materialangabenDataGridViewTextBoxColumn.DataPropertyName = "Materialangaben";
            materialangabenDataGridViewTextBoxColumn.HeaderText = "Materialangaben";
            materialangabenDataGridViewTextBoxColumn.MinimumWidth = 6;
            materialangabenDataGridViewTextBoxColumn.Name = "materialangabenDataGridViewTextBoxColumn";
            materialangabenDataGridViewTextBoxColumn.Width = 125;
            // 
            // geschlechtDataGridViewTextBoxColumn
            // 
            geschlechtDataGridViewTextBoxColumn.DataPropertyName = "Geschlecht";
            geschlechtDataGridViewTextBoxColumn.HeaderText = "Geschlecht";
            geschlechtDataGridViewTextBoxColumn.MinimumWidth = 6;
            geschlechtDataGridViewTextBoxColumn.Name = "geschlechtDataGridViewTextBoxColumn";
            geschlechtDataGridViewTextBoxColumn.Width = 125;
            // 
            // produktartDataGridViewTextBoxColumn
            // 
            produktartDataGridViewTextBoxColumn.DataPropertyName = "Produktart";
            produktartDataGridViewTextBoxColumn.HeaderText = "Produktart";
            produktartDataGridViewTextBoxColumn.MinimumWidth = 6;
            produktartDataGridViewTextBoxColumn.Name = "produktartDataGridViewTextBoxColumn";
            produktartDataGridViewTextBoxColumn.Width = 125;
            // 
            // ärmelDataGridViewTextBoxColumn
            // 
            ärmelDataGridViewTextBoxColumn.DataPropertyName = "Ärmel";
            ärmelDataGridViewTextBoxColumn.HeaderText = "Ärmel";
            ärmelDataGridViewTextBoxColumn.MinimumWidth = 6;
            ärmelDataGridViewTextBoxColumn.Name = "ärmelDataGridViewTextBoxColumn";
            ärmelDataGridViewTextBoxColumn.Width = 125;
            // 
            // beinDataGridViewTextBoxColumn
            // 
            beinDataGridViewTextBoxColumn.DataPropertyName = "Bein";
            beinDataGridViewTextBoxColumn.HeaderText = "Bein";
            beinDataGridViewTextBoxColumn.MinimumWidth = 6;
            beinDataGridViewTextBoxColumn.Name = "beinDataGridViewTextBoxColumn";
            beinDataGridViewTextBoxColumn.Width = 125;
            // 
            // kragenDataGridViewTextBoxColumn
            // 
            kragenDataGridViewTextBoxColumn.DataPropertyName = "Kragen";
            kragenDataGridViewTextBoxColumn.HeaderText = "Kragen";
            kragenDataGridViewTextBoxColumn.MinimumWidth = 6;
            kragenDataGridViewTextBoxColumn.Name = "kragenDataGridViewTextBoxColumn";
            kragenDataGridViewTextBoxColumn.Width = 125;
            // 
            // herstellungDataGridViewTextBoxColumn
            // 
            herstellungDataGridViewTextBoxColumn.DataPropertyName = "Herstellung";
            herstellungDataGridViewTextBoxColumn.HeaderText = "Herstellung";
            herstellungDataGridViewTextBoxColumn.MinimumWidth = 6;
            herstellungDataGridViewTextBoxColumn.Name = "herstellungDataGridViewTextBoxColumn";
            herstellungDataGridViewTextBoxColumn.Width = 125;
            // 
            // taschenartDataGridViewTextBoxColumn
            // 
            taschenartDataGridViewTextBoxColumn.DataPropertyName = "Taschenart";
            taschenartDataGridViewTextBoxColumn.HeaderText = "Taschenart";
            taschenartDataGridViewTextBoxColumn.MinimumWidth = 6;
            taschenartDataGridViewTextBoxColumn.Name = "taschenartDataGridViewTextBoxColumn";
            taschenartDataGridViewTextBoxColumn.Width = 125;
            // 
            // grammaturDataGridViewTextBoxColumn
            // 
            grammaturDataGridViewTextBoxColumn.DataPropertyName = "Grammatur";
            grammaturDataGridViewTextBoxColumn.HeaderText = "Grammatur";
            grammaturDataGridViewTextBoxColumn.MinimumWidth = 6;
            grammaturDataGridViewTextBoxColumn.Name = "grammaturDataGridViewTextBoxColumn";
            grammaturDataGridViewTextBoxColumn.Width = 125;
            // 
            // materialDataGridViewTextBoxColumn
            // 
            materialDataGridViewTextBoxColumn.DataPropertyName = "Material";
            materialDataGridViewTextBoxColumn.HeaderText = "Material";
            materialDataGridViewTextBoxColumn.MinimumWidth = 6;
            materialDataGridViewTextBoxColumn.Name = "materialDataGridViewTextBoxColumn";
            materialDataGridViewTextBoxColumn.Width = 125;
            // 
            // ursprungslandDataGridViewTextBoxColumn
            // 
            ursprungslandDataGridViewTextBoxColumn.DataPropertyName = "Ursprungsland";
            ursprungslandDataGridViewTextBoxColumn.HeaderText = "Ursprungsland";
            ursprungslandDataGridViewTextBoxColumn.MinimumWidth = 6;
            ursprungslandDataGridViewTextBoxColumn.Name = "ursprungslandDataGridViewTextBoxColumn";
            ursprungslandDataGridViewTextBoxColumn.Width = 125;
            // 
            // bildnameDataGridViewTextBoxColumn
            // 
            bildnameDataGridViewTextBoxColumn.DataPropertyName = "Bildname";
            bildnameDataGridViewTextBoxColumn.HeaderText = "Bildname";
            bildnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            bildnameDataGridViewTextBoxColumn.Name = "bildnameDataGridViewTextBoxColumn";
            bildnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // artikelBindingSource
            // 
            artikelBindingSource.DataSource = typeof(Data.Models.Artikel);
            // 
            // addArticle
            // 
            addArticle.BackColor = Color.LightSlateGray;
            addArticle.FlatAppearance.BorderSize = 0;
            addArticle.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addArticle.ForeColor = Color.FromArgb(8, 8, 8);
            addArticle.Location = new Point(12, 55);
            addArticle.Name = "addArticle";
            addArticle.Size = new Size(89, 35);
            addArticle.TabIndex = 4;
            addArticle.Text = "Add";
            addArticle.UseVisualStyleBackColor = false;
            addArticle.Click += Add_Click;
            // 
            // deleteArticle
            // 
            deleteArticle.BackColor = Color.FromArgb(255, 67, 46);
            deleteArticle.BackgroundImageLayout = ImageLayout.None;
            deleteArticle.FlatAppearance.BorderSize = 0;
            deleteArticle.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            deleteArticle.ForeColor = Color.FromArgb(8, 8, 8);
            deleteArticle.Location = new Point(107, 55);
            deleteArticle.Name = "deleteArticle";
            deleteArticle.Size = new Size(99, 35);
            deleteArticle.TabIndex = 4;
            deleteArticle.Text = "x Delete";
            toolTipAdd.SetToolTip(deleteArticle, "Delete");
            deleteArticle.UseVisualStyleBackColor = false;
            deleteArticle.Click += deleteArticle_Click;
            // 
            // labelPC
            // 
            labelPC.AutoSize = true;
            labelPC.BackColor = Color.Transparent;
            labelPC.Dock = DockStyle.Right;
            labelPC.Font = new Font("Arial", 16.2F, FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout, GraphicsUnit.Point, 0);
            labelPC.ForeColor = Color.FromArgb(255, 67, 46);
            labelPC.Location = new Point(1089, 0);
            labelPC.Name = "labelPC";
            labelPC.Size = new Size(219, 32);
            labelPC.TabIndex = 6;
            labelPC.Text = "PC SOFTWARE";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(35, 62, 80);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(labelPC);
            panel1.Location = new Point(0, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1310, 40);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(37, 46, 52);
            panel2.Controls.Add(save);
            panel2.Location = new Point(0, 639);
            panel2.Name = "panel2";
            panel2.Size = new Size(1310, 76);
            panel2.TabIndex = 8;
            // 
            // CsvReader
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 234, 240);
            ClientSize = new Size(1310, 692);
            Controls.Add(deleteArticle);
            Controls.Add(panel1);
            Controls.Add(addArticle);
            Controls.Add(artikelGrid);
            Controls.Add(panel2);
            Name = "CsvReader";
            Text = "Ausbildung-Code-Challange";
            ((System.ComponentModel.ISupportInitialize)artikelGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)artikelBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button save;
        private DataGridView artikelGrid;
        private DataGridViewTextBoxColumn hauptartikelnrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn artikelnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn herstellerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn beschreibungDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn materialangabenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn geschlechtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn produktartDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ärmelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn beinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kragenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn herstellungDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn taschenartDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn grammaturDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn materialDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ursprungslandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bildnameDataGridViewTextBoxColumn;
        private BindingSource artikelBindingSource;
        private Button addArticle;
        private ToolTip toolTipAdd;
        private Button deleteArticle;
        private Label labelPC;
        private Panel panel1;
        private Panel panel2;
    }
}
