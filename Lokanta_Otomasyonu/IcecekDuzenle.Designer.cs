﻿namespace Lokanta_Otomasyonu_1
{
    partial class IcecekDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IcecekDuzenle));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sıraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icecekAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iceceklerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lokantaOtomasyon1DataSetİcecekler = new Lokanta_Otomasyonu_1.LokantaOtomasyon1DataSetİcecekler();
            this.btngeri = new System.Windows.Forms.Button();
            this.Cikis = new System.Windows.Forms.Button();
            this.sıratextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FiyatDegisTxt = new System.Windows.Forms.TextBox();
            this.AdDegisTxt = new System.Windows.Forms.TextBox();
            this.FiyatDegisBtn = new System.Windows.Forms.Button();
            this.AdDegisBtn = new System.Windows.Forms.Button();
            this.İceceklerTableAdapter = new Lokanta_Otomasyonu_1.LokantaOtomasyon1DataSetİceceklerTableAdapters.İceceklerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iceceklerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokantaOtomasyon1DataSetİcecekler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sıraDataGridViewTextBoxColumn,
            this.icecekAdiDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.iceceklerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(61, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 231);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // sıraDataGridViewTextBoxColumn
            // 
            this.sıraDataGridViewTextBoxColumn.DataPropertyName = "Sıra";
            this.sıraDataGridViewTextBoxColumn.HeaderText = "Sıra";
            this.sıraDataGridViewTextBoxColumn.Name = "sıraDataGridViewTextBoxColumn";
            this.sıraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // icecekAdiDataGridViewTextBoxColumn
            // 
            this.icecekAdiDataGridViewTextBoxColumn.DataPropertyName = "İcecek_Adi";
            this.icecekAdiDataGridViewTextBoxColumn.HeaderText = "İcecek_Adi";
            this.icecekAdiDataGridViewTextBoxColumn.Name = "icecekAdiDataGridViewTextBoxColumn";
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            // 
            // iceceklerBindingSource
            // 
            this.iceceklerBindingSource.DataMember = "İcecekler";
            this.iceceklerBindingSource.DataSource = this.lokantaOtomasyon1DataSetİcecekler;
            // 
            // lokantaOtomasyon1DataSetİcecekler
            // 
            this.lokantaOtomasyon1DataSetİcecekler.DataSetName = "LokantaOtomasyon1DataSetİcecekler";
            this.lokantaOtomasyon1DataSetİcecekler.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.Transparent;
            this.btngeri.BackgroundImage = global::Lokanta_Otomasyonu_1.Properties.Resources.Restart;
            this.btngeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btngeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngeri.Location = new System.Drawing.Point(690, 3);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(60, 58);
            this.btngeri.TabIndex = 63;
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // Cikis
            // 
            this.Cikis.BackColor = System.Drawing.Color.Transparent;
            this.Cikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cikis.Image = ((System.Drawing.Image)(resources.GetObject("Cikis.Image")));
            this.Cikis.Location = new System.Drawing.Point(756, 3);
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(60, 58);
            this.Cikis.TabIndex = 62;
            this.Cikis.UseVisualStyleBackColor = false;
            this.Cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // sıratextbox
            // 
            this.sıratextbox.Location = new System.Drawing.Point(573, 125);
            this.sıratextbox.Name = "sıratextbox";
            this.sıratextbox.Size = new System.Drawing.Size(110, 27);
            this.sıratextbox.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 60;
            this.label2.Text = "Fiyat Güncelle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 59;
            this.label1.Text = "İsim Güncelle";
            // 
            // FiyatDegisTxt
            // 
            this.FiyatDegisTxt.Location = new System.Drawing.Point(573, 298);
            this.FiyatDegisTxt.Name = "FiyatDegisTxt";
            this.FiyatDegisTxt.Size = new System.Drawing.Size(110, 27);
            this.FiyatDegisTxt.TabIndex = 58;
            // 
            // AdDegisTxt
            // 
            this.AdDegisTxt.Location = new System.Drawing.Point(573, 179);
            this.AdDegisTxt.Name = "AdDegisTxt";
            this.AdDegisTxt.Size = new System.Drawing.Size(110, 27);
            this.AdDegisTxt.TabIndex = 57;
            // 
            // FiyatDegisBtn
            // 
            this.FiyatDegisBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.FiyatDegisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FiyatDegisBtn.Location = new System.Drawing.Point(688, 282);
            this.FiyatDegisBtn.Name = "FiyatDegisBtn";
            this.FiyatDegisBtn.Size = new System.Drawing.Size(116, 56);
            this.FiyatDegisBtn.TabIndex = 56;
            this.FiyatDegisBtn.Text = "Fiyat Değiş";
            this.FiyatDegisBtn.UseVisualStyleBackColor = false;
            this.FiyatDegisBtn.Click += new System.EventHandler(this.FiyatDegisBtn_Click);
            // 
            // AdDegisBtn
            // 
            this.AdDegisBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.AdDegisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AdDegisBtn.Location = new System.Drawing.Point(688, 165);
            this.AdDegisBtn.Name = "AdDegisBtn";
            this.AdDegisBtn.Size = new System.Drawing.Size(118, 53);
            this.AdDegisBtn.TabIndex = 55;
            this.AdDegisBtn.Text = "Ad Değiş";
            this.AdDegisBtn.UseVisualStyleBackColor = false;
            this.AdDegisBtn.Click += new System.EventHandler(this.AdDegisBtn_Click);
            // 
            // İceceklerTableAdapter
            // 
            this.İceceklerTableAdapter.ClearBeforeFill = true;
            // 
            // IcecekDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lokanta_Otomasyonu_1.Properties.Resources.background_dimension_3d_graphic_message_board_for_text_and_message_design_line_shadow_for_modern_web_design_free_vector;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 526);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.Cikis);
            this.Controls.Add(this.sıratextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FiyatDegisTxt);
            this.Controls.Add(this.AdDegisTxt);
            this.Controls.Add(this.FiyatDegisBtn);
            this.Controls.Add(this.AdDegisBtn);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IcecekDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IcecekDuzenle";
            this.Load += new System.EventHandler(this.IcecekDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iceceklerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokantaOtomasyon1DataSetİcecekler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Button Cikis;
        private System.Windows.Forms.TextBox sıratextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FiyatDegisTxt;
        private System.Windows.Forms.TextBox AdDegisTxt;
        private System.Windows.Forms.Button FiyatDegisBtn;
        private System.Windows.Forms.Button AdDegisBtn;
        private LokantaOtomasyon1DataSetİcecekler lokantaOtomasyon1DataSetİcecekler;
        private System.Windows.Forms.BindingSource iceceklerBindingSource;
        private LokantaOtomasyon1DataSetİceceklerTableAdapters.İceceklerTableAdapter İceceklerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sıraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn icecekAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
    }
}