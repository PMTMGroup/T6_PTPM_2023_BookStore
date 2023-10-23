namespace Frm_DangNhap
{
    partial class Frm_QLKhoHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gv_dsSachSapHet = new System.Windows.Forms.DataGridView();
            this.num_soLuong = new System.Windows.Forms.NumericUpDown();
            this.btn_DSSachSapHet_loc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.num_gianhap = new System.Windows.Forms.NumericUpDown();
            this.btn_TTHDK_lamMoi = new System.Windows.Forms.Button();
            this.btn_TTHDK_xacNhan = new System.Windows.Forms.Button();
            this.txt_ghiChu = new System.Windows.Forms.TextBox();
            this.num_slkho = new System.Windows.Forms.NumericUpDown();
            this.txt_maSach = new System.Windows.Forms.TextBox();
            this.txt_ngayLap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_TTHDK_loaiHoaDon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_xoahet = new System.Windows.Forms.Button();
            this.btn_chiTietHoaDonKho_lapHoaDon = new System.Windows.Forms.Button();
            this.gv_chiTietHoaDonKho = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_DSHoaDonKho_loc = new System.Windows.Forms.Button();
            this.cbo_loaiHoaDon = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gv_dsHoaDonKho = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_dsSachSapHet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_soLuong)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_gianhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_slkho)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_chiTietHoaDonKho)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_dsHoaDonKho)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gv_dsSachSapHet);
            this.groupBox1.Controls.Add(this.num_soLuong);
            this.groupBox1.Controls.Add(this.btn_DSSachSapHet_loc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(49, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 447);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách các sách sắp hết:";
            // 
            // gv_dsSachSapHet
            // 
            this.gv_dsSachSapHet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_dsSachSapHet.Location = new System.Drawing.Point(29, 87);
            this.gv_dsSachSapHet.Name = "gv_dsSachSapHet";
            this.gv_dsSachSapHet.RowHeadersWidth = 62;
            this.gv_dsSachSapHet.RowTemplate.Height = 24;
            this.gv_dsSachSapHet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_dsSachSapHet.Size = new System.Drawing.Size(776, 330);
            this.gv_dsSachSapHet.TabIndex = 36;
            this.gv_dsSachSapHet.SelectionChanged += new System.EventHandler(this.gv_dsSachSapHet_SelectionChanged);
            // 
            // num_soLuong
            // 
            this.num_soLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_soLuong.Location = new System.Drawing.Point(253, 31);
            this.num_soLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_soLuong.Name = "num_soLuong";
            this.num_soLuong.Size = new System.Drawing.Size(77, 30);
            this.num_soLuong.TabIndex = 39;
            this.num_soLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_DSSachSapHet_loc
            // 
            this.btn_DSSachSapHet_loc.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_DSSachSapHet_loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DSSachSapHet_loc.Location = new System.Drawing.Point(384, 28);
            this.btn_DSSachSapHet_loc.Name = "btn_DSSachSapHet_loc";
            this.btn_DSSachSapHet_loc.Size = new System.Drawing.Size(148, 39);
            this.btn_DSSachSapHet_loc.TabIndex = 38;
            this.btn_DSSachSapHet_loc.Text = "Lọc";
            this.btn_DSSachSapHet_loc.UseVisualStyleBackColor = false;
            this.btn_DSSachSapHet_loc.Click += new System.EventHandler(this.btn_DSSachSapHet_loc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Nhập số lượng tồn (dưới):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.num_gianhap);
            this.groupBox2.Controls.Add(this.btn_TTHDK_lamMoi);
            this.groupBox2.Controls.Add(this.btn_TTHDK_xacNhan);
            this.groupBox2.Controls.Add(this.txt_ghiChu);
            this.groupBox2.Controls.Add(this.num_slkho);
            this.groupBox2.Controls.Add(this.txt_maSach);
            this.groupBox2.Controls.Add(this.txt_ngayLap);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(49, 519);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(831, 409);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hóa đơn kho:";
            // 
            // num_gianhap
            // 
            this.num_gianhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_gianhap.Location = new System.Drawing.Point(166, 223);
            this.num_gianhap.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.num_gianhap.Name = "num_gianhap";
            this.num_gianhap.Size = new System.Drawing.Size(164, 30);
            this.num_gianhap.TabIndex = 52;
            // 
            // btn_TTHDK_lamMoi
            // 
            this.btn_TTHDK_lamMoi.BackColor = System.Drawing.Color.White;
            this.btn_TTHDK_lamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TTHDK_lamMoi.Location = new System.Drawing.Point(503, 344);
            this.btn_TTHDK_lamMoi.Name = "btn_TTHDK_lamMoi";
            this.btn_TTHDK_lamMoi.Size = new System.Drawing.Size(148, 39);
            this.btn_TTHDK_lamMoi.TabIndex = 51;
            this.btn_TTHDK_lamMoi.Text = "Làm mới";
            this.btn_TTHDK_lamMoi.UseVisualStyleBackColor = false;
            this.btn_TTHDK_lamMoi.Click += new System.EventHandler(this.btn_TTHDK_lamMoi_Click);
            // 
            // btn_TTHDK_xacNhan
            // 
            this.btn_TTHDK_xacNhan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_TTHDK_xacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TTHDK_xacNhan.Location = new System.Drawing.Point(657, 344);
            this.btn_TTHDK_xacNhan.Name = "btn_TTHDK_xacNhan";
            this.btn_TTHDK_xacNhan.Size = new System.Drawing.Size(148, 39);
            this.btn_TTHDK_xacNhan.TabIndex = 50;
            this.btn_TTHDK_xacNhan.Text = "Xác nhận";
            this.btn_TTHDK_xacNhan.UseVisualStyleBackColor = false;
            this.btn_TTHDK_xacNhan.Click += new System.EventHandler(this.btn_TTHDK_xacNhan_Click);
            // 
            // txt_ghiChu
            // 
            this.txt_ghiChu.Location = new System.Drawing.Point(166, 280);
            this.txt_ghiChu.Multiline = true;
            this.txt_ghiChu.Name = "txt_ghiChu";
            this.txt_ghiChu.Size = new System.Drawing.Size(444, 30);
            this.txt_ghiChu.TabIndex = 49;
            // 
            // num_slkho
            // 
            this.num_slkho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_slkho.Location = new System.Drawing.Point(166, 162);
            this.num_slkho.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_slkho.Name = "num_slkho";
            this.num_slkho.Size = new System.Drawing.Size(164, 30);
            this.num_slkho.TabIndex = 40;
            this.num_slkho.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_maSach
            // 
            this.txt_maSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maSach.Location = new System.Drawing.Point(166, 104);
            this.txt_maSach.Multiline = true;
            this.txt_maSach.Name = "txt_maSach";
            this.txt_maSach.Size = new System.Drawing.Size(444, 30);
            this.txt_maSach.TabIndex = 47;
            // 
            // txt_ngayLap
            // 
            this.txt_ngayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ngayLap.Location = new System.Drawing.Point(166, 43);
            this.txt_ngayLap.Multiline = true;
            this.txt_ngayLap.Name = "txt_ngayLap";
            this.txt_ngayLap.ReadOnly = true;
            this.txt_ngayLap.Size = new System.Drawing.Size(444, 30);
            this.txt_ngayLap.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "Ghi chú:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Ngày lập:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "Giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Mã sách:";
            // 
            // cbo_TTHDK_loaiHoaDon
            // 
            this.cbo_TTHDK_loaiHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_TTHDK_loaiHoaDon.FormattingEnabled = true;
            this.cbo_TTHDK_loaiHoaDon.Items.AddRange(new object[] {
            "Nhập kho",
            "Xuất kho"});
            this.cbo_TTHDK_loaiHoaDon.Location = new System.Drawing.Point(152, 350);
            this.cbo_TTHDK_loaiHoaDon.Name = "cbo_TTHDK_loaiHoaDon";
            this.cbo_TTHDK_loaiHoaDon.Size = new System.Drawing.Size(189, 28);
            this.cbo_TTHDK_loaiHoaDon.TabIndex = 36;
            this.cbo_TTHDK_loaiHoaDon.Text = "--- Chọn ---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Loại hóa đơn:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_xoahet);
            this.groupBox3.Controls.Add(this.btn_chiTietHoaDonKho_lapHoaDon);
            this.groupBox3.Controls.Add(this.gv_chiTietHoaDonKho);
            this.groupBox3.Controls.Add(this.cbo_TTHDK_loaiHoaDon);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(909, 519);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(803, 409);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết hóa đơn kho:";
            // 
            // btn_xoahet
            // 
            this.btn_xoahet.BackColor = System.Drawing.Color.White;
            this.btn_xoahet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoahet.Location = new System.Drawing.Point(405, 339);
            this.btn_xoahet.Name = "btn_xoahet";
            this.btn_xoahet.Size = new System.Drawing.Size(135, 48);
            this.btn_xoahet.TabIndex = 53;
            this.btn_xoahet.Text = "Xóa hết";
            this.btn_xoahet.UseVisualStyleBackColor = false;
            this.btn_xoahet.Click += new System.EventHandler(this.btn_xoahet_Click);
            // 
            // btn_chiTietHoaDonKho_lapHoaDon
            // 
            this.btn_chiTietHoaDonKho_lapHoaDon.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_chiTietHoaDonKho_lapHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chiTietHoaDonKho_lapHoaDon.Location = new System.Drawing.Point(546, 339);
            this.btn_chiTietHoaDonKho_lapHoaDon.Name = "btn_chiTietHoaDonKho_lapHoaDon";
            this.btn_chiTietHoaDonKho_lapHoaDon.Size = new System.Drawing.Size(231, 48);
            this.btn_chiTietHoaDonKho_lapHoaDon.TabIndex = 52;
            this.btn_chiTietHoaDonKho_lapHoaDon.Text = "Lập hóa đơn";
            this.btn_chiTietHoaDonKho_lapHoaDon.UseVisualStyleBackColor = false;
            this.btn_chiTietHoaDonKho_lapHoaDon.Click += new System.EventHandler(this.btn_chiTietHoaDonKho_lapHoaDon_Click);
            // 
            // gv_chiTietHoaDonKho
            // 
            this.gv_chiTietHoaDonKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_chiTietHoaDonKho.Location = new System.Drawing.Point(28, 41);
            this.gv_chiTietHoaDonKho.Name = "gv_chiTietHoaDonKho";
            this.gv_chiTietHoaDonKho.RowHeadersWidth = 62;
            this.gv_chiTietHoaDonKho.RowTemplate.Height = 24;
            this.gv_chiTietHoaDonKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_chiTietHoaDonKho.Size = new System.Drawing.Size(749, 281);
            this.gv_chiTietHoaDonKho.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_DSHoaDonKho_loc);
            this.groupBox4.Controls.Add(this.cbo_loaiHoaDon);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.gv_dsHoaDonKho);
            this.groupBox4.Location = new System.Drawing.Point(909, 50);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(803, 447);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách hóa đơn kho:";
            // 
            // btn_DSHoaDonKho_loc
            // 
            this.btn_DSHoaDonKho_loc.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_DSHoaDonKho_loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DSHoaDonKho_loc.Location = new System.Drawing.Point(496, 28);
            this.btn_DSHoaDonKho_loc.Name = "btn_DSHoaDonKho_loc";
            this.btn_DSHoaDonKho_loc.Size = new System.Drawing.Size(148, 39);
            this.btn_DSHoaDonKho_loc.TabIndex = 35;
            this.btn_DSHoaDonKho_loc.Text = "Lọc";
            this.btn_DSHoaDonKho_loc.UseVisualStyleBackColor = false;
            this.btn_DSHoaDonKho_loc.Click += new System.EventHandler(this.btn_DSHoaDonKho_loc_Click);
            // 
            // cbo_loaiHoaDon
            // 
            this.cbo_loaiHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_loaiHoaDon.FormattingEnabled = true;
            this.cbo_loaiHoaDon.Items.AddRange(new object[] {
            "Tất cả",
            "Nhập kho",
            "Xuất kho"});
            this.cbo_loaiHoaDon.Location = new System.Drawing.Point(152, 34);
            this.cbo_loaiHoaDon.Name = "cbo_loaiHoaDon";
            this.cbo_loaiHoaDon.Size = new System.Drawing.Size(327, 28);
            this.cbo_loaiHoaDon.TabIndex = 34;
            this.cbo_loaiHoaDon.Text = "--- Chọn ---";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 20);
            this.label10.TabIndex = 33;
            this.label10.Text = "Loại hóa đơn:";
            // 
            // gv_dsHoaDonKho
            // 
            this.gv_dsHoaDonKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_dsHoaDonKho.Location = new System.Drawing.Point(28, 87);
            this.gv_dsHoaDonKho.Name = "gv_dsHoaDonKho";
            this.gv_dsHoaDonKho.RowHeadersWidth = 62;
            this.gv_dsHoaDonKho.RowTemplate.Height = 24;
            this.gv_dsHoaDonKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_dsHoaDonKho.Size = new System.Drawing.Size(749, 330);
            this.gv_dsHoaDonKho.TabIndex = 1;
            this.gv_dsHoaDonKho.SelectionChanged += new System.EventHandler(this.gv_dsHoaDonKho_SelectionChanged);
            // 
            // Frm_QLKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1721, 939);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_QLKhoHang";
            this.Text = "Frm_QLKhoHang";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_dsSachSapHet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_soLuong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_gianhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_slkho)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_chiTietHoaDonKho)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_dsHoaDonKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView gv_chiTietHoaDonKho;
        private System.Windows.Forms.DataGridView gv_dsHoaDonKho;
        private System.Windows.Forms.Button btn_DSHoaDonKho_loc;
        private System.Windows.Forms.ComboBox cbo_loaiHoaDon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_DSSachSapHet_loc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_soLuong;
        private System.Windows.Forms.DataGridView gv_dsSachSapHet;
        private System.Windows.Forms.ComboBox cbo_TTHDK_loaiHoaDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_TTHDK_lamMoi;
        private System.Windows.Forms.Button btn_TTHDK_xacNhan;
        private System.Windows.Forms.TextBox txt_ghiChu;
        private System.Windows.Forms.NumericUpDown num_slkho;
        private System.Windows.Forms.TextBox txt_maSach;
        private System.Windows.Forms.TextBox txt_ngayLap;
        private System.Windows.Forms.Button btn_chiTietHoaDonKho_lapHoaDon;
        private System.Windows.Forms.NumericUpDown num_gianhap;
        private System.Windows.Forms.Button btn_xoahet;
    }
}