namespace NusantaraLaundry.transaksi.input_paket
{
    partial class ViewInputPaket
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnOrder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.inputAlamat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.inputNama = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.inputNoTelp = new System.Windows.Forms.TextBox();
            this.inputHarga = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.inputPaketId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridviewPaket = new System.Windows.Forms.DataGridView();
            this.inputLayananNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.paketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layananDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputHarga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewPaket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrder
            // 
            this.btnOrder.Enabled = false;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.btnOrder.Location = new System.Drawing.Point(529, 438);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(123, 36);
            this.btnOrder.TabIndex = 37;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.inputAlamat);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.inputNama);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.inputNoTelp);
            this.groupBox1.Location = new System.Drawing.Point(296, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 173);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pelanggan";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label9.Location = new System.Drawing.Point(16, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 18);
            this.label9.TabIndex = 22;
            this.label9.Text = "Alamat";
            // 
            // inputAlamat
            // 
            this.inputAlamat.Location = new System.Drawing.Point(110, 128);
            this.inputAlamat.Name = "inputAlamat";
            this.inputAlamat.ReadOnly = true;
            this.inputAlamat.Size = new System.Drawing.Size(175, 22);
            this.inputAlamat.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label8.Location = new System.Drawing.Point(16, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Nama";
            // 
            // inputNama
            // 
            this.inputNama.Location = new System.Drawing.Point(110, 85);
            this.inputNama.Name = "inputNama";
            this.inputNama.ReadOnly = true;
            this.inputNama.Size = new System.Drawing.Size(175, 22);
            this.inputNama.TabIndex = 19;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(113, 55);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(214, 16);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Tidak ada data? pelanggan baru +";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label7.Location = new System.Drawing.Point(16, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "No Telepon";
            // 
            // inputNoTelp
            // 
            this.inputNoTelp.Location = new System.Drawing.Point(110, 30);
            this.inputNoTelp.Name = "inputNoTelp";
            this.inputNoTelp.Size = new System.Drawing.Size(175, 22);
            this.inputNoTelp.TabIndex = 16;
            this.inputNoTelp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputNoTelp_KeyDown);
            // 
            // inputHarga
            // 
            this.inputHarga.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.inputHarga.Location = new System.Drawing.Point(73, 330);
            this.inputHarga.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.inputHarga.Name = "inputHarga";
            this.inputHarga.ReadOnly = true;
            this.inputHarga.Size = new System.Drawing.Size(144, 22);
            this.inputHarga.TabIndex = 31;
            this.inputHarga.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label5.Location = new System.Drawing.Point(4, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "Harga";
            // 
            // inputPaketId
            // 
            this.inputPaketId.Location = new System.Drawing.Point(73, 255);
            this.inputPaketId.Name = "inputPaketId";
            this.inputPaketId.ReadOnly = true;
            this.inputPaketId.Size = new System.Drawing.Size(144, 22);
            this.inputPaketId.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label3.Location = new System.Drawing.Point(4, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Id Paket";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Pilih Layanan";
            // 
            // gridviewPaket
            // 
            this.gridviewPaket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridviewPaket.AutoGenerateColumns = false;
            this.gridviewPaket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridviewPaket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewPaket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.layananDataGridViewTextBoxColumn,
            this.totalUnitDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn});
            this.gridviewPaket.DataSource = this.paketBindingSource;
            this.gridviewPaket.Location = new System.Drawing.Point(3, 44);
            this.gridviewPaket.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.gridviewPaket.Name = "gridviewPaket";
            this.gridviewPaket.RowHeadersWidth = 51;
            this.gridviewPaket.RowTemplate.Height = 24;
            this.gridviewPaket.Size = new System.Drawing.Size(651, 204);
            this.gridviewPaket.TabIndex = 20;
            this.gridviewPaket.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewPaket_CellDoubleClick);
            // 
            // inputLayananNama
            // 
            this.inputLayananNama.Location = new System.Drawing.Point(73, 292);
            this.inputLayananNama.Name = "inputLayananNama";
            this.inputLayananNama.ReadOnly = true;
            this.inputLayananNama.Size = new System.Drawing.Size(144, 22);
            this.inputLayananNama.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label2.Location = new System.Drawing.Point(4, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 38;
            this.label2.Text = "Layanan";
            // 
            // paketBindingSource
            // 
            this.paketBindingSource.DataSource = typeof(NusantaraLaundry.Paket);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id Paket";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            // 
            // layananDataGridViewTextBoxColumn
            // 
            this.layananDataGridViewTextBoxColumn.DataPropertyName = "Layanan";
            this.layananDataGridViewTextBoxColumn.HeaderText = "Layanan";
            this.layananDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.layananDataGridViewTextBoxColumn.Name = "layananDataGridViewTextBoxColumn";
            // 
            // totalUnitDataGridViewTextBoxColumn
            // 
            this.totalUnitDataGridViewTextBoxColumn.DataPropertyName = "TotalUnit";
            this.totalUnitDataGridViewTextBoxColumn.HeaderText = "Jumlah";
            this.totalUnitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalUnitDataGridViewTextBoxColumn.Name = "totalUnitDataGridViewTextBoxColumn";
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "Harga";
            dataGridViewCellStyle3.Format = "C0";
            dataGridViewCellStyle3.NullValue = null;
            this.hargaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.hargaDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.hargaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            // 
            // ViewInputPaket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.inputLayananNama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.inputHarga);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputPaketId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridviewPaket);
            this.Name = "ViewInputPaket";
            this.Size = new System.Drawing.Size(657, 498);
            this.Load += new System.EventHandler(this.ViewInputPaket_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputHarga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewPaket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paketBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox inputAlamat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox inputNama;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inputNoTelp;
        private System.Windows.Forms.NumericUpDown inputHarga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputPaketId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridviewPaket;
        private System.Windows.Forms.TextBox inputLayananNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource paketBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn layananDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
    }
}
