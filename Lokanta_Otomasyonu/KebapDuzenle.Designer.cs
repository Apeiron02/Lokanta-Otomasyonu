namespace Lokanta_Otomasyonu_1
{
    partial class KebapDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KebapDuzenle));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FiyatDegisTxt = new System.Windows.Forms.TextBox();
            this.adDegisTxt = new System.Windows.Forms.TextBox();
            this.FiyatDegisBtn = new System.Windows.Forms.Button();
            this.adDegisbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sıraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kebapAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kebaplarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lokantaOtomasyon1DataSetKebaplar = new Lokanta_Otomasyonu_1.LokantaOtomasyon1DataSetKebaplar();
            this.kebaplarTableAdapter = new Lokanta_Otomasyonu_1.LokantaOtomasyon1DataSetKebaplarTableAdapters.KebaplarTableAdapter();
            this.btngeri = new System.Windows.Forms.Button();
            this.Cikis = new System.Windows.Forms.Button();
            this.sıratextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kebaplarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokantaOtomasyon1DataSetKebaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Fiyat Güncelle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(463, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "İsim Güncelle";
            // 
            // FiyatDegisTxt
            // 
            this.FiyatDegisTxt.Location = new System.Drawing.Point(574, 292);
            this.FiyatDegisTxt.Name = "FiyatDegisTxt";
            this.FiyatDegisTxt.Size = new System.Drawing.Size(110, 27);
            this.FiyatDegisTxt.TabIndex = 22;
            // 
            // adDegisTxt
            // 
            this.adDegisTxt.Location = new System.Drawing.Point(574, 173);
            this.adDegisTxt.Name = "adDegisTxt";
            this.adDegisTxt.Size = new System.Drawing.Size(110, 27);
            this.adDegisTxt.TabIndex = 21;
            // 
            // FiyatDegisBtn
            // 
            this.FiyatDegisBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.FiyatDegisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FiyatDegisBtn.Location = new System.Drawing.Point(689, 276);
            this.FiyatDegisBtn.Name = "FiyatDegisBtn";
            this.FiyatDegisBtn.Size = new System.Drawing.Size(116, 56);
            this.FiyatDegisBtn.TabIndex = 20;
            this.FiyatDegisBtn.Text = "Fiyat Değiş";
            this.FiyatDegisBtn.UseVisualStyleBackColor = false;
            this.FiyatDegisBtn.Click += new System.EventHandler(this.FiyatDegisBtn_Click);
            // 
            // adDegisbtn
            // 
            this.adDegisbtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.adDegisbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adDegisbtn.Location = new System.Drawing.Point(689, 159);
            this.adDegisbtn.Name = "adDegisbtn";
            this.adDegisbtn.Size = new System.Drawing.Size(118, 53);
            this.adDegisbtn.TabIndex = 19;
            this.adDegisbtn.Text = "Ad Değiş";
            this.adDegisbtn.UseVisualStyleBackColor = false;
            this.adDegisbtn.Click += new System.EventHandler(this.adDegisbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sıraDataGridViewTextBoxColumn,
            this.kebapAdiDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kebaplarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(49, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 231);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // sıraDataGridViewTextBoxColumn
            // 
            this.sıraDataGridViewTextBoxColumn.DataPropertyName = "Sıra";
            this.sıraDataGridViewTextBoxColumn.HeaderText = "Sıra";
            this.sıraDataGridViewTextBoxColumn.Name = "sıraDataGridViewTextBoxColumn";
            this.sıraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kebapAdiDataGridViewTextBoxColumn
            // 
            this.kebapAdiDataGridViewTextBoxColumn.DataPropertyName = "Kebap_Adi";
            this.kebapAdiDataGridViewTextBoxColumn.HeaderText = "Kebap_Adi";
            this.kebapAdiDataGridViewTextBoxColumn.Name = "kebapAdiDataGridViewTextBoxColumn";
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            // 
            // kebaplarBindingSource
            // 
            this.kebaplarBindingSource.DataMember = "Kebaplar";
            this.kebaplarBindingSource.DataSource = this.lokantaOtomasyon1DataSetKebaplar;
            // 
            // lokantaOtomasyon1DataSetKebaplar
            // 
            this.lokantaOtomasyon1DataSetKebaplar.DataSetName = "LokantaOtomasyon1DataSetKebaplar";
            this.lokantaOtomasyon1DataSetKebaplar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kebaplarTableAdapter
            // 
            this.kebaplarTableAdapter.ClearBeforeFill = true;
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.Transparent;
            this.btngeri.BackgroundImage = global::Lokanta_Otomasyonu_1.Properties.Resources.Restart;
            this.btngeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btngeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngeri.Location = new System.Drawing.Point(691, 1);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(60, 58);
            this.btngeri.TabIndex = 43;
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // Cikis
            // 
            this.Cikis.BackColor = System.Drawing.Color.Transparent;
            this.Cikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cikis.Image = ((System.Drawing.Image)(resources.GetObject("Cikis.Image")));
            this.Cikis.Location = new System.Drawing.Point(757, 1);
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(60, 58);
            this.Cikis.TabIndex = 42;
            this.Cikis.UseVisualStyleBackColor = false;
            this.Cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // sıratextbox
            // 
            this.sıratextbox.Location = new System.Drawing.Point(574, 104);
            this.sıratextbox.Name = "sıratextbox";
            this.sıratextbox.Size = new System.Drawing.Size(110, 27);
            this.sıratextbox.TabIndex = 44;
            // 
            // KebapDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lokanta_Otomasyonu_1.Properties.Resources.background_dimension_3d_graphic_message_board_for_text_and_message_design_line_shadow_for_modern_web_design_free_vector;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 526);
            this.Controls.Add(this.sıratextbox);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.Cikis);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FiyatDegisTxt);
            this.Controls.Add(this.adDegisTxt);
            this.Controls.Add(this.FiyatDegisBtn);
            this.Controls.Add(this.adDegisbtn);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KebapDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KebapDuzenle";
            this.Load += new System.EventHandler(this.KebapDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kebaplarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokantaOtomasyon1DataSetKebaplar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FiyatDegisTxt;
        private System.Windows.Forms.TextBox adDegisTxt;
        private System.Windows.Forms.Button FiyatDegisBtn;
        private System.Windows.Forms.Button adDegisbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LokantaOtomasyon1DataSetKebaplar lokantaOtomasyon1DataSetKebaplar;
        private System.Windows.Forms.BindingSource kebaplarBindingSource;
        private LokantaOtomasyon1DataSetKebaplarTableAdapters.KebaplarTableAdapter kebaplarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sıraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kebapAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Button Cikis;
        private System.Windows.Forms.TextBox sıratextbox;
    }
}