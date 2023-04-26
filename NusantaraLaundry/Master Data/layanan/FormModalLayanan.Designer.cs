namespace NusantaraLaundry.Master_Data.layanan
{
    partial class FormModalLayanan
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputKategori = new System.Windows.Forms.ComboBox();
            this.inputUnit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputHarga = new System.Windows.Forms.NumericUpDown();
            this.inputEstimasiDurasi = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inputHarga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputEstimasiDurasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // inputNama
            // 
            this.inputNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNama.Location = new System.Drawing.Point(34, 62);
            this.inputNama.Margin = new System.Windows.Forms.Padding(3, 3, 3, 18);
            this.inputNama.Name = "inputNama";
            this.inputNama.Size = new System.Drawing.Size(163, 28);
            this.inputNama.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Harga";
            // 
            // inputKategori
            // 
            this.inputKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.inputKategori.FormattingEnabled = true;
            this.inputKategori.Location = new System.Drawing.Point(34, 133);
            this.inputKategori.Margin = new System.Windows.Forms.Padding(3, 3, 3, 18);
            this.inputKategori.Name = "inputKategori";
            this.inputKategori.Size = new System.Drawing.Size(163, 30);
            this.inputKategori.TabIndex = 6;
            // 
            // inputUnit
            // 
            this.inputUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.inputUnit.FormattingEnabled = true;
            this.inputUnit.Location = new System.Drawing.Point(34, 206);
            this.inputUnit.Margin = new System.Windows.Forms.Padding(3, 3, 3, 18);
            this.inputUnit.Name = "inputUnit";
            this.inputUnit.Size = new System.Drawing.Size(163, 30);
            this.inputUnit.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Unit";
            // 
            // inputHarga
            // 
            this.inputHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.inputHarga.Location = new System.Drawing.Point(271, 63);
            this.inputHarga.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.inputHarga.Name = "inputHarga";
            this.inputHarga.Size = new System.Drawing.Size(163, 28);
            this.inputHarga.TabIndex = 9;
            this.inputHarga.ThousandsSeparator = true;
            // 
            // inputEstimasiDurasi
            // 
            this.inputEstimasiDurasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.inputEstimasiDurasi.Location = new System.Drawing.Point(271, 135);
            this.inputEstimasiDurasi.Name = "inputEstimasiDurasi";
            this.inputEstimasiDurasi.Size = new System.Drawing.Size(130, 28);
            this.inputEstimasiDurasi.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(267, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Estimasi Durasi";
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(349, 197);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(85, 39);
            this.btnSimpan.TabIndex = 12;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(271, 197);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(72, 39);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(407, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Menit";
            // 
            // FormModalLayanan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(483, 282);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSimpan);
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
            this.Name = "FormModalLayanan";
            this.Text = "FormModalLayanan";
            this.Load += new System.EventHandler(this.FormModalLayanan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputHarga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputEstimasiDurasi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox inputKategori;
        private System.Windows.Forms.ComboBox inputUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown inputHarga;
        private System.Windows.Forms.NumericUpDown inputEstimasiDurasi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label6;
    }
}