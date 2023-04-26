namespace NusantaraLaundry.Master_Data.pelanggan
{
    partial class FormModalPelangganAdd
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
            this.inputNoTelp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputAlamat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // inputNama
            // 
            this.inputNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNama.Location = new System.Drawing.Point(16, 55);
            this.inputNama.Name = "inputNama";
            this.inputNama.Size = new System.Drawing.Size(291, 28);
            this.inputNama.TabIndex = 1;
            // 
            // inputNoTelp
            // 
            this.inputNoTelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNoTelp.Location = new System.Drawing.Point(16, 132);
            this.inputNoTelp.Name = "inputNoTelp";
            this.inputNoTelp.Size = new System.Drawing.Size(291, 28);
            this.inputNoTelp.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "No Telepon";
            // 
            // inputAlamat
            // 
            this.inputAlamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputAlamat.Location = new System.Drawing.Point(16, 212);
            this.inputAlamat.Multiline = true;
            this.inputAlamat.Name = "inputAlamat";
            this.inputAlamat.Size = new System.Drawing.Size(291, 79);
            this.inputAlamat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(12, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alamat";
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(16, 321);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(291, 39);
            this.btnSimpan.TabIndex = 6;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormModalPelangganAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 388);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.inputAlamat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputNoTelp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputNama);
            this.Controls.Add(this.label1);
            this.Name = "FormModalPelangganAdd";
            this.Text = "FormModalPelangganAdd";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputNama;
        private System.Windows.Forms.TextBox inputNoTelp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputAlamat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}