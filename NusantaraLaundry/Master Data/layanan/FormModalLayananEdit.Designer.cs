namespace NusantaraLaundry.Master_Data.layanan
{
    partial class FormModalLayananEdit
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
            this.label6 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.inputEstimasiDurasi = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.inputHarga = new System.Windows.Forms.NumericUpDown();
            this.inputUnit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputKategori = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputNama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inputEstimasiDurasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputHarga)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(397, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 27;
            this.label6.Text = "Menit";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(351, 188);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(90, 39);
            this.btnupdate.TabIndex = 26;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Red;
            this.btnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(261, 188);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(85, 39);
            this.btnHapus.TabIndex = 25;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // inputEstimasiDurasi
            // 
            this.inputEstimasiDurasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.inputEstimasiDurasi.Location = new System.Drawing.Point(261, 126);
            this.inputEstimasiDurasi.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.inputEstimasiDurasi.Name = "inputEstimasiDurasi";
            this.inputEstimasiDurasi.Size = new System.Drawing.Size(130, 28);
            this.inputEstimasiDurasi.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(257, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 22);
            this.label5.TabIndex = 23;
            this.label5.Text = "Estimasi Durasi";
            // 
            // inputHarga
            // 
            this.inputHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.inputHarga.Location = new System.Drawing.Point(261, 54);
            this.inputHarga.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.inputHarga.Name = "inputHarga";
            this.inputHarga.Size = new System.Drawing.Size(163, 28);
            this.inputHarga.TabIndex = 22;
            this.inputHarga.ThousandsSeparator = true;
            // 
            // inputUnit
            // 
            this.inputUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.inputUnit.FormattingEnabled = true;
            this.inputUnit.Location = new System.Drawing.Point(24, 197);
            this.inputUnit.Margin = new System.Windows.Forms.Padding(3, 3, 3, 18);
            this.inputUnit.Name = "inputUnit";
            this.inputUnit.Size = new System.Drawing.Size(163, 30);
            this.inputUnit.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "Unit";
            // 
            // inputKategori
            // 
            this.inputKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.inputKategori.FormattingEnabled = true;
            this.inputKategori.Location = new System.Drawing.Point(24, 124);
            this.inputKategori.Margin = new System.Windows.Forms.Padding(3, 3, 3, 18);
            this.inputKategori.Name = "inputKategori";
            this.inputKategori.Size = new System.Drawing.Size(163, 30);
            this.inputKategori.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Harga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Kategori";
            // 
            // inputNama
            // 
            this.inputNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNama.Location = new System.Drawing.Point(24, 53);
            this.inputNama.Margin = new System.Windows.Forms.Padding(3, 3, 3, 18);
            this.inputNama.Name = "inputNama";
            this.inputNama.Size = new System.Drawing.Size(163, 28);
            this.inputNama.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nama";
            // 
            // FormModalLayananEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 273);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.inputEstimasiDurasi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputHarga);
            this.Controls.Add(this.inputUnit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputKategori);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputNama);
            this.Controls.Add(this.label1);
            this.Name = "FormModalLayananEdit";
            this.Text = "FormModalLayananEdit";
            this.Load += new System.EventHandler(this.FormModalLayananEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputEstimasiDurasi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputHarga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.NumericUpDown inputEstimasiDurasi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown inputHarga;
        private System.Windows.Forms.ComboBox inputUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox inputKategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputNama;
        private System.Windows.Forms.Label label1;
    }
}