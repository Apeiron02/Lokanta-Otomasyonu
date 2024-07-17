namespace Lokanta_Otomasyonu_1
{
    partial class DurumDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DurumDuzenle));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sıraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lokantaOtomasyon1DataSetDurumler = new Lokanta_Otomasyonu_1.LokantaOtomasyon1DataSetDurumler();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FiyatTextbox = new System.Windows.Forms.TextBox();
            this.adTextbox = new System.Windows.Forms.TextBox();
            this.BtnFiyatDegis = new System.Windows.Forms.Button();
            this.BtnAdDegis = new System.Windows.Forms.Button();
            this.durumlerTableAdapter = new Lokanta_Otomasyonu_1.LokantaOtomasyon1DataSetDurumlerTableAdapters.DurumlerTableAdapter();
            this.sıratextbox = new System.Windows.Forms.TextBox();
            this.btngeri = new System.Windows.Forms.Button();
            this.Cikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durumlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokantaOtomasyon1DataSetDurumler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sıraDataGridViewTextBoxColumn,
            this.durumAdiDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.durumlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 231);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // sıraDataGridViewTextBoxColumn
            // 
            this.sıraDataGridViewTextBoxColumn.DataPropertyName = "Sıra";
            this.sıraDataGridViewTextBoxColumn.HeaderText = "Sıra";
            this.sıraDataGridViewTextBoxColumn.Name = "sıraDataGridViewTextBoxColumn";
            this.sıraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // durumAdiDataGridViewTextBoxColumn
            // 
            this.durumAdiDataGridViewTextBoxColumn.DataPropertyName = "Durum_Adi";
            this.durumAdiDataGridViewTextBoxColumn.HeaderText = "Durum_Adi";
            this.durumAdiDataGridViewTextBoxColumn.Name = "durumAdiDataGridViewTextBoxColumn";
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            // 
            // durumlerBindingSource
            // 
            this.durumlerBindingSource.DataMember = "Durumler";
            this.durumlerBindingSource.DataSource = this.lokantaOtomasyon1DataSetDurumler;
            // 
            // lokantaOtomasyon1DataSetDurumler
            // 
            this.lokantaOtomasyon1DataSetDurumler.DataSetName = "LokantaOtomasyon1DataSetDurumler";
            this.lokantaOtomasyon1DataSetDurumler.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "Fiyat Güncelle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "İsim Güncelle";
            // 
            // FiyatTextbox
            // 
            this.FiyatTextbox.Location = new System.Drawing.Point(573, 278);
            this.FiyatTextbox.Name = "FiyatTextbox";
            this.FiyatTextbox.Size = new System.Drawing.Size(110, 27);
            this.FiyatTextbox.TabIndex = 29;
            // 
            // adTextbox
            // 
            this.adTextbox.Location = new System.Drawing.Point(573, 159);
            this.adTextbox.Name = "adTextbox";
            this.adTextbox.Size = new System.Drawing.Size(110, 27);
            this.adTextbox.TabIndex = 28;
            // 
            // BtnFiyatDegis
            // 
            this.BtnFiyatDegis.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnFiyatDegis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFiyatDegis.Location = new System.Drawing.Point(689, 262);
            this.BtnFiyatDegis.Name = "BtnFiyatDegis";
            this.BtnFiyatDegis.Size = new System.Drawing.Size(116, 56);
            this.BtnFiyatDegis.TabIndex = 27;
            this.BtnFiyatDegis.Text = "Fiyat Değiş";
            this.BtnFiyatDegis.UseVisualStyleBackColor = false;
            this.BtnFiyatDegis.Click += new System.EventHandler(this.BtnFiyatDegis_Click);
            // 
            // BtnAdDegis
            // 
            this.BtnAdDegis.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnAdDegis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAdDegis.Location = new System.Drawing.Point(689, 145);
            this.BtnAdDegis.Name = "BtnAdDegis";
            this.BtnAdDegis.Size = new System.Drawing.Size(118, 53);
            this.BtnAdDegis.TabIndex = 26;
            this.BtnAdDegis.Text = "Ad Değiş";
            this.BtnAdDegis.UseVisualStyleBackColor = false;
            this.BtnAdDegis.Click += new System.EventHandler(this.BtnAdDegis_Click);
            // 
            // durumlerTableAdapter
            // 
            this.durumlerTableAdapter.ClearBeforeFill = true;
            // 
            // sıratextbox
            // 
            this.sıratextbox.Location = new System.Drawing.Point(573, 92);
            this.sıratextbox.Name = "sıratextbox";
            this.sıratextbox.Size = new System.Drawing.Size(110, 27);
            this.sıratextbox.TabIndex = 39;
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.Transparent;
            this.btngeri.BackgroundImage = global::Lokanta_Otomasyonu_1.Properties.Resources.Restart;
            this.btngeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btngeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngeri.Location = new System.Drawing.Point(692, 1);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(60, 58);
            this.btngeri.TabIndex = 41;
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // Cikis
            // 
            this.Cikis.BackColor = System.Drawing.Color.Transparent;
            this.Cikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cikis.Image = ((System.Drawing.Image)(resources.GetObject("Cikis.Image")));
            this.Cikis.Location = new System.Drawing.Point(758, 1);
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(60, 58);
            this.Cikis.TabIndex = 40;
            this.Cikis.UseVisualStyleBackColor = false;
            this.Cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // DurumDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lokanta_Otomasyonu_1.Properties.Resources.background_dimension_3d_graphic_message_board_for_text_and_message_design_line_shadow_for_modern_web_design_free_vector;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 526);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.Cikis);
            this.Controls.Add(this.sıratextbox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FiyatTextbox);
            this.Controls.Add(this.adTextbox);
            this.Controls.Add(this.BtnFiyatDegis);
            this.Controls.Add(this.BtnAdDegis);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DurumDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DurumDuzenle";
            this.Load += new System.EventHandler(this.DurumDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durumlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokantaOtomasyon1DataSetDurumler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FiyatTextbox;
        private System.Windows.Forms.TextBox adTextbox;
        private System.Windows.Forms.Button BtnFiyatDegis;
        private System.Windows.Forms.Button BtnAdDegis;
        private LokantaOtomasyon1DataSetDurumler lokantaOtomasyon1DataSetDurumler;
        private System.Windows.Forms.BindingSource durumlerBindingSource;
        private LokantaOtomasyon1DataSetDurumlerTableAdapters.DurumlerTableAdapter durumlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sıraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox sıratextbox;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Button Cikis;
    }
}