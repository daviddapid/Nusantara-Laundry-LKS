namespace NusantaraLaundry.transaksi.input_transaksi
{
    partial class ViewInputTransaksi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridviewLayanan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gridViewDetailOrder = new System.Windows.Forms.DataGridView();
            this.LayananId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaLayanan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHapusOrderDetail = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.inputNamaLayanan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputQuantity = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonTambahLayanan = new System.Windows.Forms.Button();
            this.inputHarga = new System.Windows.Forms.NumericUpDown();
            this.inputIdTransaksi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.inputAlamat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.inputNama = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.inputNoTelp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.inputGrandtotal = new System.Windows.Forms.NumericUpDown();
            this.btnOrder = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estimastiDurasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layananBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewLayanan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetailOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputHarga)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputGrandtotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layananBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridviewLayanan
            // 
            this.gridviewLayanan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridviewLayanan.AutoGenerateColumns = false;
            this.gridviewLayanan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridviewLayanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewLayanan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.namaDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.hargaUnitDataGridViewTextBoxColumn,
            this.estimastiDurasiDataGridViewTextBoxColumn,
            this.kategoriDataGridViewTextBoxColumn});
            this.gridviewLayanan.DataSource = this.layananBindingSource;
            this.gridviewLayanan.Location = new System.Drawing.Point(3, 41);
            this.gridviewLayanan.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.gridviewLayanan.Name = "gridviewLayanan";
            this.gridviewLayanan.RowHeadersWidth = 51;
            this.gridviewLayanan.RowTemplate.Height = 24;
            this.gridviewLayanan.Size = new System.Drawing.Size(826, 204);
            this.gridviewLayanan.TabIndex = 0;
            this.gridviewLayanan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewLayanan_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pilih Layanan";
            // 
            // gridViewDetailOrder
            // 
            this.gridViewDetailOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewDetailOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewDetailOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewDetailOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LayananId,
            this.NamaLayanan,
            this.Qty,
            this.Harga});
            this.gridViewDetailOrder.Location = new System.Drawing.Point(3, 334);
            this.gridViewDetailOrder.Name = "gridViewDetailOrder";
            this.gridViewDetailOrder.RowHeadersWidth = 51;
            this.gridViewDetailOrder.RowTemplate.Height = 24;
            this.gridViewDetailOrder.Size = new System.Drawing.Size(662, 204);
            this.gridViewDetailOrder.TabIndex = 2;
            this.gridViewDetailOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewDetailOrder_CellClick);
            // 
            // LayananId
            // 
            this.LayananId.DataPropertyName = "LayananId";
            this.LayananId.HeaderText = "ID Layanan";
            this.LayananId.MinimumWidth = 6;
            this.LayananId.Name = "LayananId";
            // 
            // NamaLayanan
            // 
            this.NamaLayanan.DataPropertyName = "NamaLayanan";
            this.NamaLayanan.HeaderText = "Nama Layanan";
            this.NamaLayanan.MinimumWidth = 6;
            this.NamaLayanan.Name = "NamaLayanan";
            this.NamaLayanan.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.DataPropertyName = "Qty";
            this.Qty.HeaderText = "QTY";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // Harga
            // 
            this.Harga.DataPropertyName = "Harga";
            dataGridViewCellStyle3.Format = "C0";
            dataGridViewCellStyle3.NullValue = null;
            this.Harga.DefaultCellStyle = dataGridViewCellStyle3;
            this.Harga.HeaderText = "Harga";
            this.Harga.MinimumWidth = 6;
            this.Harga.Name = "Harga";
            this.Harga.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.Location = new System.Drawing.Point(3, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Detail Order";
            // 
            // btnHapusOrderDetail
            // 
            this.btnHapusOrderDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHapusOrderDetail.Enabled = false;
            this.btnHapusOrderDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.btnHapusOrderDetail.Location = new System.Drawing.Point(688, 334);
            this.btnHapusOrderDetail.Name = "btnHapusOrderDetail";
            this.btnHapusOrderDetail.Size = new System.Drawing.Size(123, 36);
            this.btnHapusOrderDetail.TabIndex = 4;
            this.btnHapusOrderDetail.Text = "Hapus";
            this.btnHapusOrderDetail.UseVisualStyleBackColor = true;
            this.btnHapusOrderDetail.Click += new System.EventHandler(this.btnHapusOrderDetail_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label3.Location = new System.Drawing.Point(4, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nama Layanan";
            // 
            // inputNamaLayanan
            // 
            this.inputNamaLayanan.Location = new System.Drawing.Point(117, 252);
            this.inputNamaLayanan.Name = "inputNamaLayanan";
            this.inputNamaLayanan.ReadOnly = true;
            this.inputNamaLayanan.Size = new System.Drawing.Size(144, 22);
            this.inputNamaLayanan.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label4.Location = new System.Drawing.Point(296, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "QTY";
            // 
            // inputQuantity
            // 
            this.inputQuantity.Enabled = false;
            this.inputQuantity.Location = new System.Drawing.Point(340, 253);
            this.inputQuantity.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.inputQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputQuantity.Name = "inputQuantity";
            this.inputQuantity.Size = new System.Drawing.Size(81, 22);
            this.inputQuantity.TabIndex = 8;
            this.inputQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputQuantity.ValueChanged += new System.EventHandler(this.inputQuantity_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label5.Location = new System.Drawing.Point(457, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Harga";
            // 
            // buttonTambahLayanan
            // 
            this.buttonTambahLayanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.buttonTambahLayanan.Location = new System.Drawing.Point(716, 252);
            this.buttonTambahLayanan.Name = "buttonTambahLayanan";
            this.buttonTambahLayanan.Size = new System.Drawing.Size(95, 29);
            this.buttonTambahLayanan.TabIndex = 11;
            this.buttonTambahLayanan.Text = "Tambah";
            this.buttonTambahLayanan.UseVisualStyleBackColor = true;
            this.buttonTambahLayanan.Click += new System.EventHandler(this.buttonTambahLayanan_Click);
            // 
            // inputHarga
            // 
            this.inputHarga.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.inputHarga.Location = new System.Drawing.Point(511, 252);
            this.inputHarga.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.inputHarga.Name = "inputHarga";
            this.inputHarga.ReadOnly = true;
            this.inputHarga.Size = new System.Drawing.Size(120, 22);
            this.inputHarga.TabIndex = 12;
            this.inputHarga.ThousandsSeparator = true;
            // 
            // inputIdTransaksi
            // 
            this.inputIdTransaksi.Location = new System.Drawing.Point(98, 547);
            this.inputIdTransaksi.Name = "inputIdTransaksi";
            this.inputIdTransaksi.Size = new System.Drawing.Size(100, 22);
            this.inputIdTransaksi.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label6.Location = new System.Drawing.Point(4, 548);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Id Transaksi";
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
            this.groupBox1.Location = new System.Drawing.Point(7, 583);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 173);
            this.groupBox1.TabIndex = 15;
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
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label10.Location = new System.Drawing.Point(386, 548);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "Grandtotal";
            // 
            // inputGrandtotal
            // 
            this.inputGrandtotal.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.inputGrandtotal.Location = new System.Drawing.Point(480, 548);
            this.inputGrandtotal.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.inputGrandtotal.Name = "inputGrandtotal";
            this.inputGrandtotal.ReadOnly = true;
            this.inputGrandtotal.Size = new System.Drawing.Size(185, 22);
            this.inputGrandtotal.TabIndex = 18;
            this.inputGrandtotal.ThousandsSeparator = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrder.Enabled = false;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.btnOrder.Location = new System.Drawing.Point(542, 593);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(123, 36);
            this.btnOrder.TabIndex = 19;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            // 
            // hargaUnitDataGridViewTextBoxColumn
            // 
            this.hargaUnitDataGridViewTextBoxColumn.DataPropertyName = "HargaUnit";
            dataGridViewCellStyle1.Format = "C0";
            dataGridViewCellStyle1.NullValue = null;
            this.hargaUnitDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.hargaUnitDataGridViewTextBoxColumn.HeaderText = "HargaUnit";
            this.hargaUnitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargaUnitDataGridViewTextBoxColumn.Name = "hargaUnitDataGridViewTextBoxColumn";
            // 
            // estimastiDurasiDataGridViewTextBoxColumn
            // 
            this.estimastiDurasiDataGridViewTextBoxColumn.DataPropertyName = "EstimastiDurasi";
            dataGridViewCellStyle2.Format = "# menit";
            dataGridViewCellStyle2.NullValue = null;
            this.estimastiDurasiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.estimastiDurasiDataGridViewTextBoxColumn.HeaderText = "EstimastiDurasi";
            this.estimastiDurasiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estimastiDurasiDataGridViewTextBoxColumn.Name = "estimastiDurasiDataGridViewTextBoxColumn";
            // 
            // kategoriDataGridViewTextBoxColumn
            // 
            this.kategoriDataGridViewTextBoxColumn.DataPropertyName = "Kategori";
            this.kategoriDataGridViewTextBoxColumn.HeaderText = "Kategori";
            this.kategoriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kategoriDataGridViewTextBoxColumn.Name = "kategoriDataGridViewTextBoxColumn";
            // 
            // layananBindingSource
            // 
            this.layananBindingSource.DataSource = typeof(NusantaraLaundry.Layanan);
            // 
            // ViewInputTransaksi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.inputGrandtotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inputIdTransaksi);
            this.Controls.Add(this.inputHarga);
            this.Controls.Add(this.buttonTambahLayanan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputNamaLayanan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHapusOrderDetail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridViewDetailOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridviewLayanan);
            this.Name = "ViewInputTransaksi";
            this.Size = new System.Drawing.Size(832, 779);
            this.Load += new System.EventHandler(this.ViewInputTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewLayanan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetailOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputHarga)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputGrandtotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layananBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridviewLayanan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource layananBindingSource;
        private System.Windows.Forms.DataGridView gridViewDetailOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHapusOrderDetail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown inputQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonTambahLayanan;
        private System.Windows.Forms.TextBox inputNamaLayanan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estimastiDurasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown inputHarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn LayananId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaLayanan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga;
        private System.Windows.Forms.TextBox inputIdTransaksi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inputNoTelp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox inputAlamat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox inputNama;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown inputGrandtotal;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
