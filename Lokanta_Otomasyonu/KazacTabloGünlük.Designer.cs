namespace Lokanta_Otomasyonu_1
{
    partial class KazacTabloGünlük
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KazacTabloGünlük));
            this.btngeri = new System.Windows.Forms.Button();
            this.Cikis = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.Transparent;
            this.btngeri.BackgroundImage = global::Lokanta_Otomasyonu_1.Properties.Resources.Restart;
            this.btngeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btngeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngeri.Location = new System.Drawing.Point(2, 104);
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
            this.Cikis.Location = new System.Drawing.Point(323, 104);
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(60, 58);
            this.Cikis.TabIndex = 36;
            this.Cikis.UseVisualStyleBackColor = false;
            this.Cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(131, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(176, 44);
            this.dateTimePicker1.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(158, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 45);
            this.button1.TabIndex = 40;
            this.button1.Text = "GETİR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(68, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(249, 421);
            this.dataGridView1.TabIndex = 43;
            // 
            // KazacTabloGünlük
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lokanta_Otomasyonu_1.Properties.Resources.background_dimension_3d_graphic_message_board_for_text_and_message_design_line_shadow_for_modern_web_design_free_vector;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(387, 526);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.Cikis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KazacTabloGünlük";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KazacTabloGünlük";
            this.Load += new System.EventHandler(this.KazacTabloGünlük_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Button Cikis;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}