namespace Lokanta_Otomasyonu_1
{
    partial class CorbaDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CorbaDuzenle));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sıraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corbaAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corbalarBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.lokantaOtomasyon1DataSet1 = new Lokanta_Otomasyonu_1.LokantaOtomasyon1DataSet1();
            this.corbalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lokantaOtomasyon1DataSet = new Lokanta_Otomasyonu_1.LokantaOtomasyon1DataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fiyatDegis = new System.Windows.Forms.Button();
            this.adDegis = new System.Windows.Forms.Button();
            this.corbalarTableAdapter = new Lokanta_Otomasyonu_1.LokantaOtomasyon1DataSetTableAdapters.CorbalarTableAdapter();
            this.btngeri = new System.Windows.Forms.Button();
            this.Cikis = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lokantaOtomasyon1DataSetCorbalar = new Lokanta_Otomasyonu_1.LokantaOtomasyon1DataSetCorbalar();
            this.corbalarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.corbalarTableAdapter1 = new Lokanta_Otomasyonu_1.LokantaOtomasyon1DataSetCorbalarTableAdapters.CorbalarTableAdapter();
            this.corbalarTableAdapter2 = new Lokanta_Otomasyonu_1.LokantaOtomasyon1DataSet1TableAdapters.CorbalarTableAdapter();
            this.lokantaOtomasyon1DataSetCorbalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corbalarBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokantaOtomasyon1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corbalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokantaOtomasyon1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokantaOtomasyon1DataSetCorbalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corbalarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokantaOtomasyon1DataSetCorbalarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sıraDataGridViewTextBoxColumn,
            this.corbaAdiDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.corbalarBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(47, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(347, 218);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sıraDataGridViewTextBoxColumn
            // 
            this.sıraDataGridViewTextBoxColumn.DataPropertyName = "Sıra";
            this.sıraDataGridViewTextBoxColumn.HeaderText = "Sıra";
            this.sıraDataGridViewTextBoxColumn.Name = "sıraDataGridViewTextBoxColumn";
            this.sıraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // corbaAdiDataGridViewTextBoxColumn
            // 
            this.corbaAdiDataGridViewTextBoxColumn.DataPropertyName = "Corba_Adi";
            this.corbaAdiDataGridViewTextBoxColumn.HeaderText = "Corba_Adi";
            this.corbaAdiDataGridViewTextBoxColumn.Name = "corbaAdiDataGridViewTextBoxColumn";
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            // 
            // corbalarBindingSource2
            // 
            this.corbalarBindingSource2.DataMember = "Corbalar";
            this.corbalarBindingSource2.DataSource = this.lokantaOtomasyon1DataSet1;
            // 
            // lokantaOtomasyon1DataSet1
            // 
            this.lokantaOtomasyon1DataSet1.DataSetName = "LokantaOtomasyon1DataSet1";
            this.lokantaOtomasyon1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // corbalarBindingSource
            // 
            this.corbalarBindingSource.DataMember = "Corbalar";
            this.corbalarBindingSource.DataSource = this.lokantaOtomasyon1DataSet;
            // 
            // lokantaOtomasyon1DataSet
            // 
            this.lokantaOtomasyon1DataSet.DataSetName = "LokantaOtomasyon1DataSet";
            this.lokantaOtomasyon1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "Fiyat Güncelle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "İsim Güncelle";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(535, 286);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(110, 27);
            this.textBox2.TabIndex = 29;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(535, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 27);
            this.textBox1.TabIndex = 28;
            // 
            // fiyatDegis
            // 
            this.fiyatDegis.BackColor = System.Drawing.Color.LightSteelBlue;
            this.fiyatDegis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fiyatDegis.Location = new System.Drawing.Point(675, 276);
            this.fiyatDegis.Name = "fiyatDegis";
            this.fiyatDegis.Size = new System.Drawing.Size(116, 56);
            this.fiyatDegis.TabIndex = 27;
            this.fiyatDegis.Text = "Fiyat Değiş";
            this.fiyatDegis.UseVisualStyleBackColor = false;
            this.fiyatDegis.Click += new System.EventHandler(this.fiyatDegis_Click);
            // 
            // adDegis
            // 
            this.adDegis.BackColor = System.Drawing.Color.LightSteelBlue;
            this.adDegis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adDegis.Location = new System.Drawing.Point(673, 153);
            this.adDegis.Name = "adDegis";
            this.adDegis.Size = new System.Drawing.Size(118, 53);
            this.adDegis.TabIndex = 26;
            this.adDegis.Text = "Ad Değiş";
            this.adDegis.UseVisualStyleBackColor = false;
            this.adDegis.Click += new System.EventHandler(this.adDegis_Click);
            // 
            // corbalarTableAdapter
            // 
            this.corbalarTableAdapter.ClearBeforeFill = true;
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.Transparent;
            this.btngeri.BackgroundImage = global::Lokanta_Otomasyonu_1.Properties.Resources.Restart;
            this.btngeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btngeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngeri.Location = new System.Drawing.Point(693, 1);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(60, 58);
            this.btngeri.TabIndex = 37;
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // Cikis
            // 
            this.Cikis.BackColor = System.Drawing.Color.Transparent;
            this.Cikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cikis.Image = ((System.Drawing.Image)(resources.GetObject("Cikis.Image")));
            this.Cikis.Location = new System.Drawing.Point(759, 1);
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(60, 58);
            this.Cikis.TabIndex = 36;
            this.Cikis.UseVisualStyleBackColor = false;
            this.Cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(535, 103);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(110, 27);
            this.textBox3.TabIndex = 38;
            // 
            // lokantaOtomasyon1DataSetCorbalar
            // 
            this.lokantaOtomasyon1DataSetCorbalar.DataSetName = "LokantaOtomasyon1DataSetCorbalar";
            this.lokantaOtomasyon1DataSetCorbalar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // corbalarBindingSource1
            // 
            this.corbalarBindingSource1.DataMember = "Corbalar";
            this.corbalarBindingSource1.DataSource = this.lokantaOtomasyon1DataSetCorbalar;
            // 
            // corbalarTableAdapter1
            // 
            this.corbalarTableAdapter1.ClearBeforeFill = true;
            // 
            // corbalarTableAdapter2
            // 
            this.corbalarTableAdapter2.ClearBeforeFill = true;
            // 
            // lokantaOtomasyon1DataSetCorbalarBindingSource
            // 
            this.lokantaOtomasyon1DataSetCorbalarBindingSource.DataSource = this.lokantaOtomasyon1DataSetCorbalar;
            this.lokantaOtomasyon1DataSetCorbalarBindingSource.Position = 0;
            // 
            // CorbaDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lokanta_Otomasyonu_1.Properties.Resources.background_dimension_3d_graphic_message_board_for_text_and_message_design_line_shadow_for_modern_web_design_free_vector;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 526);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.Cikis);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.fiyatDegis);
            this.Controls.Add(this.adDegis);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CorbaDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CorbaDuzenle";
            this.Load += new System.EventHandler(this.CorbaDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corbalarBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokantaOtomasyon1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corbalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokantaOtomasyon1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokantaOtomasyon1DataSetCorbalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corbalarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokantaOtomasyon1DataSetCorbalarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button fiyatDegis;
        private System.Windows.Forms.Button adDegis;
        private LokantaOtomasyon1DataSet lokantaOtomasyon1DataSet;
        private System.Windows.Forms.BindingSource corbalarBindingSource;
        private LokantaOtomasyon1DataSetTableAdapters.CorbalarTableAdapter corbalarTableAdapter;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Button Cikis;
        private System.Windows.Forms.TextBox textBox3;
        private LokantaOtomasyon1DataSetCorbalar lokantaOtomasyon1DataSetCorbalar;
        private System.Windows.Forms.BindingSource corbalarBindingSource1;
        private LokantaOtomasyon1DataSetCorbalarTableAdapters.CorbalarTableAdapter corbalarTableAdapter1;
        private LokantaOtomasyon1DataSet1 lokantaOtomasyon1DataSet1;
        private System.Windows.Forms.BindingSource corbalarBindingSource2;
        private LokantaOtomasyon1DataSet1TableAdapters.CorbalarTableAdapter corbalarTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sıraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corbaAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource lokantaOtomasyon1DataSetCorbalarBindingSource;
    }
}