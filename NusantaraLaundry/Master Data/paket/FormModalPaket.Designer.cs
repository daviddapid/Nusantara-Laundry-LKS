namespace NusantaraLaundry.Master_Data.paket
{
    partial class FormModalPaket
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.inputHarga = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.inputLayanan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputTotalUnit = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.inputHarga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTotalUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(232, 114);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(72, 39);
            this.btnReset.TabIndex = 26;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(310, 114);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(85, 39);
            this.btnSimpan.TabIndex = 25;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // inputHarga
            // 
            this.inputHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.inputHarga.Location = new System.Drawing.Point(232, 46);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "Total Unit";
            // 
            // inputLayanan
            // 
            this.inputLayanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.inputLayanan.FormattingEnabled = true;
            this.inputLayanan.Location = new System.Drawing.Point(16, 46);
            this.inputLayanan.Margin = new System.Windows.Forms.Padding(3, 3, 3, 18);
            this.inputLayanan.Name = "inputLayanan";
            this.inputLayanan.Size = new System.Drawing.Size(163, 30);
            this.inputLayanan.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Harga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Layanan";
            // 
            // inputTotalUnit
            // 
            this.inputTotalUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.inputTotalUnit.Location = new System.Drawing.Point(16, 119);
            this.inputTotalUnit.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.inputTotalUnit.Name = "inputTotalUnit";
            this.inputTotalUnit.Size = new System.Drawing.Size(163, 28);
            this.inputTotalUnit.TabIndex = 27;
            this.inputTotalUnit.ThousandsSeparator = true;
            // 
            // FormModalPaket
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(428, 197);
            this.Controls.Add(this.inputTotalUnit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.inputHarga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputLayanan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormModalPaket";
            this.Text = "FormModalPaket";
            this.Load += new System.EventHandler(this.FormModalPaket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputHarga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTotalUnit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.NumericUpDown inputHarga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox inputLayanan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown inputTotalUnit;
    }
}