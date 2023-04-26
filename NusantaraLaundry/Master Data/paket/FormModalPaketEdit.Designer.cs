namespace NusantaraLaundry.Master_Data.paket
{
    partial class FormModalPaketEdit
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
            this.inputTotalUnit = new System.Windows.Forms.NumericUpDown();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.inputHarga = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.inputLayanan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inputTotalUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputHarga)).BeginInit();
            this.SuspendLayout();
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
            this.inputTotalUnit.TabIndex = 35;
            this.inputTotalUnit.ThousandsSeparator = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(232, 114);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 39);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(310, 114);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 39);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.inputHarga.TabIndex = 32;
            this.inputHarga.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 22);
            this.label4.TabIndex = 31;
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
            this.inputLayanan.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 22);
            this.label3.TabIndex = 29;
            this.label3.Text = "Harga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "Layanan";
            // 
            // FormModalPaketEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 179);
            this.Controls.Add(this.inputTotalUnit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.inputHarga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputLayanan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormModalPaketEdit";
            this.Text = "FormModalPaketEdit";
            this.Load += new System.EventHandler(this.FormModalPaketEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputTotalUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputHarga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown inputTotalUnit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.NumericUpDown inputHarga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox inputLayanan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}