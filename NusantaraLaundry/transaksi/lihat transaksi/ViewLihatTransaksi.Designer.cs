namespace NusantaraLaundry.transaksi.lihat_transaksi
{
    partial class ViewLihatTransaksi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridviewTransaksi = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pelangganIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pegawaiIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalTransaksiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estimasiSelesaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridviewDetailTransaksi = new System.Windows.Forms.DataGridView();
            this.detailTransaksiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.detailTransaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DetailTransaksiId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layananDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailPaketIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TanggalSelesai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelesai = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewTransaksi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewDetailTransaksi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailTransaksiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailTransaksiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.gridviewTransaksi);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(939, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaksi";
            // 
            // gridviewTransaksi
            // 
            this.gridviewTransaksi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridviewTransaksi.AutoGenerateColumns = false;
            this.gridviewTransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridviewTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewTransaksi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.pelangganIdDataGridViewTextBoxColumn,
            this.pegawaiIdDataGridViewTextBoxColumn,
            this.tanggalTransaksiDataGridViewTextBoxColumn,
            this.estimasiSelesaiDataGridViewTextBoxColumn});
            this.gridviewTransaksi.DataSource = this.transaksiBindingSource;
            this.gridviewTransaksi.Location = new System.Drawing.Point(6, 21);
            this.gridviewTransaksi.Name = "gridviewTransaksi";
            this.gridviewTransaksi.RowHeadersWidth = 51;
            this.gridviewTransaksi.RowTemplate.Height = 24;
            this.gridviewTransaksi.Size = new System.Drawing.Size(927, 228);
            this.gridviewTransaksi.TabIndex = 0;
            this.gridviewTransaksi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewTransaksi_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 50.80214F;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 47;
            // 
            // pelangganIdDataGridViewTextBoxColumn
            // 
            this.pelangganIdDataGridViewTextBoxColumn.DataPropertyName = "PelangganId";
            this.pelangganIdDataGridViewTextBoxColumn.FillWeight = 112.2995F;
            this.pelangganIdDataGridViewTextBoxColumn.HeaderText = "PelangganId";
            this.pelangganIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pelangganIdDataGridViewTextBoxColumn.Name = "pelangganIdDataGridViewTextBoxColumn";
            // 
            // pegawaiIdDataGridViewTextBoxColumn
            // 
            this.pegawaiIdDataGridViewTextBoxColumn.DataPropertyName = "PegawaiId";
            this.pegawaiIdDataGridViewTextBoxColumn.FillWeight = 112.2995F;
            this.pegawaiIdDataGridViewTextBoxColumn.HeaderText = "PegawaiId";
            this.pegawaiIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pegawaiIdDataGridViewTextBoxColumn.Name = "pegawaiIdDataGridViewTextBoxColumn";
            // 
            // tanggalTransaksiDataGridViewTextBoxColumn
            // 
            this.tanggalTransaksiDataGridViewTextBoxColumn.DataPropertyName = "TanggalTransaksi";
            this.tanggalTransaksiDataGridViewTextBoxColumn.FillWeight = 112.2995F;
            this.tanggalTransaksiDataGridViewTextBoxColumn.HeaderText = "TanggalTransaksi";
            this.tanggalTransaksiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tanggalTransaksiDataGridViewTextBoxColumn.Name = "tanggalTransaksiDataGridViewTextBoxColumn";
            // 
            // estimasiSelesaiDataGridViewTextBoxColumn
            // 
            this.estimasiSelesaiDataGridViewTextBoxColumn.DataPropertyName = "EstimasiSelesai";
            this.estimasiSelesaiDataGridViewTextBoxColumn.FillWeight = 112.2995F;
            this.estimasiSelesaiDataGridViewTextBoxColumn.HeaderText = "Tanggal Selesai";
            this.estimasiSelesaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estimasiSelesaiDataGridViewTextBoxColumn.Name = "estimasiSelesaiDataGridViewTextBoxColumn";
            // 
            // transaksiBindingSource
            // 
            this.transaksiBindingSource.DataSource = typeof(NusantaraLaundry.Transaksi);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.gridviewDetailTransaksi);
            this.groupBox2.Location = new System.Drawing.Point(3, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(939, 255);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detail Transaksi";
            // 
            // gridviewDetailTransaksi
            // 
            this.gridviewDetailTransaksi.AllowUserToAddRows = false;
            this.gridviewDetailTransaksi.AllowUserToDeleteRows = false;
            this.gridviewDetailTransaksi.AllowUserToOrderColumns = true;
            this.gridviewDetailTransaksi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridviewDetailTransaksi.AutoGenerateColumns = false;
            this.gridviewDetailTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewDetailTransaksi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DetailTransaksiId,
            this.layananDataGridViewTextBoxColumn,
            this.detailPaketIdDataGridViewTextBoxColumn,
            this.hargaUnitDataGridViewTextBoxColumn,
            this.totalUnitDataGridViewTextBoxColumn,
            this.TanggalSelesai,
            this.btnSelesai});
            this.gridviewDetailTransaksi.DataSource = this.detailTransaksiBindingSource1;
            this.gridviewDetailTransaksi.Location = new System.Drawing.Point(6, 21);
            this.gridviewDetailTransaksi.Name = "gridviewDetailTransaksi";
            this.gridviewDetailTransaksi.ReadOnly = true;
            this.gridviewDetailTransaksi.RowHeadersWidth = 51;
            this.gridviewDetailTransaksi.RowTemplate.Height = 24;
            this.gridviewDetailTransaksi.Size = new System.Drawing.Size(927, 228);
            this.gridviewDetailTransaksi.TabIndex = 0;
            this.gridviewDetailTransaksi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewDetailTransaksi_CellContentClick);
            // 
            // detailTransaksiBindingSource1
            // 
            this.detailTransaksiBindingSource1.DataSource = typeof(NusantaraLaundry.DetailTransaksi);
            // 
            // detailTransaksiBindingSource
            // 
            this.detailTransaksiBindingSource.DataSource = typeof(NusantaraLaundry.DetailTransaksi);
            // 
            // DetailTransaksiId
            // 
            this.DetailTransaksiId.DataPropertyName = "Id";
            this.DetailTransaksiId.HeaderText = "Id";
            this.DetailTransaksiId.MinimumWidth = 6;
            this.DetailTransaksiId.Name = "DetailTransaksiId";
            this.DetailTransaksiId.ReadOnly = true;
            this.DetailTransaksiId.Visible = false;
            this.DetailTransaksiId.Width = 125;
            // 
            // layananDataGridViewTextBoxColumn
            // 
            this.layananDataGridViewTextBoxColumn.DataPropertyName = "NamaLayanan";
            this.layananDataGridViewTextBoxColumn.HeaderText = "Nama Layanan";
            this.layananDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.layananDataGridViewTextBoxColumn.Name = "layananDataGridViewTextBoxColumn";
            this.layananDataGridViewTextBoxColumn.ReadOnly = true;
            this.layananDataGridViewTextBoxColumn.Width = 125;
            // 
            // detailPaketIdDataGridViewTextBoxColumn
            // 
            this.detailPaketIdDataGridViewTextBoxColumn.DataPropertyName = "PaketId";
            dataGridViewCellStyle1.NullValue = "transaksi reguler";
            this.detailPaketIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.detailPaketIdDataGridViewTextBoxColumn.HeaderText = "Id_paket";
            this.detailPaketIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.detailPaketIdDataGridViewTextBoxColumn.Name = "detailPaketIdDataGridViewTextBoxColumn";
            this.detailPaketIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.detailPaketIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // hargaUnitDataGridViewTextBoxColumn
            // 
            this.hargaUnitDataGridViewTextBoxColumn.DataPropertyName = "HargaUnit";
            dataGridViewCellStyle2.Format = "C0";
            dataGridViewCellStyle2.NullValue = null;
            this.hargaUnitDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.hargaUnitDataGridViewTextBoxColumn.HeaderText = "Harga per Unit";
            this.hargaUnitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargaUnitDataGridViewTextBoxColumn.Name = "hargaUnitDataGridViewTextBoxColumn";
            this.hargaUnitDataGridViewTextBoxColumn.ReadOnly = true;
            this.hargaUnitDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalUnitDataGridViewTextBoxColumn
            // 
            this.totalUnitDataGridViewTextBoxColumn.DataPropertyName = "TotalUnit";
            this.totalUnitDataGridViewTextBoxColumn.HeaderText = "TotalUnit";
            this.totalUnitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalUnitDataGridViewTextBoxColumn.Name = "totalUnitDataGridViewTextBoxColumn";
            this.totalUnitDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalUnitDataGridViewTextBoxColumn.Width = 125;
            // 
            // TanggalSelesai
            // 
            this.TanggalSelesai.DataPropertyName = "TanggalSelesai";
            this.TanggalSelesai.HeaderText = "TanggalSelesai";
            this.TanggalSelesai.MinimumWidth = 6;
            this.TanggalSelesai.Name = "TanggalSelesai";
            this.TanggalSelesai.ReadOnly = true;
            this.TanggalSelesai.Width = 125;
            // 
            // btnSelesai
            // 
            this.btnSelesai.DataPropertyName = "btnSelesai";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.btnSelesai.DefaultCellStyle = dataGridViewCellStyle3;
            this.btnSelesai.HeaderText = "Action";
            this.btnSelesai.MinimumWidth = 6;
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.ReadOnly = true;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseColumnTextForButtonValue = true;
            this.btnSelesai.Width = 125;
            // 
            // ViewLihatTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ViewLihatTransaksi";
            this.Size = new System.Drawing.Size(945, 631);
            this.Load += new System.EventHandler(this.ViewLihatTransaksi_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewTransaksi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewDetailTransaksi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailTransaksiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailTransaksiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridviewTransaksi;
        private System.Windows.Forms.BindingSource transaksiBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridviewDetailTransaksi;
        private System.Windows.Forms.BindingSource detailTransaksiBindingSource;
        private System.Windows.Forms.BindingSource detailTransaksiBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pelangganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pegawaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pelangganIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pegawaiIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalTransaksiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estimasiSelesaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetailTransaksiId;
        private System.Windows.Forms.DataGridViewTextBoxColumn layananDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailPaketIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TanggalSelesai;
        private System.Windows.Forms.DataGridViewButtonColumn btnSelesai;
    }
}
