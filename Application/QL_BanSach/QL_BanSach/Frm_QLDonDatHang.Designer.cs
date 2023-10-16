namespace Frm_DangNhap
{
    partial class Frm_QLDonDatHang
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
            this.btn_loc = new System.Windows.Forms.Button();
            this.cbo_trangThaiDonHang = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbo_trangThaiDonHang1 = new System.Windows.Forms.ComboBox();
            this.txt_ghiChu = new System.Windows.Forms.TextBox();
            this.txt_diaChiGiaoHang = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_hoTenNguoiNhan = new System.Windows.Forms.TextBox();
            this.txt_hinhThucThanhToan = new System.Windows.Forms.TextBox();
            this.txt_thanhTien = new System.Windows.Forms.TextBox();
            this.txt_tongGiamGia = new System.Windows.Forms.TextBox();
            this.txt_tongTien = new System.Windows.Forms.TextBox();
            this.txt_phiShip = new System.Windows.Forms.TextBox();
            this.txt_maGiamGia = new System.Windows.Forms.TextBox();
            this.txt_maThanhVien = new System.Windows.Forms.TextBox();
            this.txt_ngayLap = new System.Windows.Forms.TextBox();
            this.txt_soDonHang = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_loc);
            this.groupBox1.Controls.Add(this.cbo_trangThaiDonHang);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(73, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1015, 506);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách đơn đặt hàng:";
            // 
            // btn_loc
            // 
            this.btn_loc.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loc.Location = new System.Drawing.Point(813, 44);
            this.btn_loc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_loc.Name = "btn_loc";
            this.btn_loc.Size = new System.Drawing.Size(166, 49);
            this.btn_loc.TabIndex = 32;
            this.btn_loc.Text = "Lọc";
            this.btn_loc.UseVisualStyleBackColor = false;
            // 
            // cbo_trangThaiDonHang
            // 
            this.cbo_trangThaiDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_trangThaiDonHang.FormattingEnabled = true;
            this.cbo_trangThaiDonHang.Items.AddRange(new object[] {
            "Tất cả",
            "Đang xử lý",
            "Đang giao hàng",
            "Đã giao hàng",
            "Đã từ chối"});
            this.cbo_trangThaiDonHang.Location = new System.Drawing.Point(264, 50);
            this.cbo_trangThaiDonHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_trangThaiDonHang.Name = "cbo_trangThaiDonHang";
            this.cbo_trangThaiDonHang.Size = new System.Drawing.Size(530, 33);
            this.cbo_trangThaiDonHang.TabIndex = 32;
            this.cbo_trangThaiDonHang.Text = "--- Chọn ---";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(211, 25);
            this.label10.TabIndex = 31;
            this.label10.Text = "Trạng thái đơn hàng:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 115);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(943, 356);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.cbo_trangThaiDonHang1);
            this.groupBox2.Controls.Add(this.txt_ghiChu);
            this.groupBox2.Controls.Add(this.txt_diaChiGiaoHang);
            this.groupBox2.Controls.Add(this.txt_email);
            this.groupBox2.Controls.Add(this.txt_sdt);
            this.groupBox2.Controls.Add(this.txt_hoTenNguoiNhan);
            this.groupBox2.Controls.Add(this.txt_hinhThucThanhToan);
            this.groupBox2.Controls.Add(this.txt_thanhTien);
            this.groupBox2.Controls.Add(this.txt_tongGiamGia);
            this.groupBox2.Controls.Add(this.txt_tongTien);
            this.groupBox2.Controls.Add(this.txt_phiShip);
            this.groupBox2.Controls.Add(this.txt_maGiamGia);
            this.groupBox2.Controls.Add(this.txt_maThanhVien);
            this.groupBox2.Controls.Add(this.txt_ngayLap);
            this.groupBox2.Controls.Add(this.txt_soDonHang);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(73, 584);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1820, 595);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin đơn hàng:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1491, 502);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 64);
            this.button1.TabIndex = 31;
            this.button1.Text = "Cập Nhật";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cbo_trangThaiDonHang1
            // 
            this.cbo_trangThaiDonHang1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_trangThaiDonHang1.FormattingEnabled = true;
            this.cbo_trangThaiDonHang1.Items.AddRange(new object[] {
            "Đang xử lý",
            "Đang giao hàng",
            "Đã giao hàng",
            "Đã từ chối"});
            this.cbo_trangThaiDonHang1.Location = new System.Drawing.Point(1180, 420);
            this.cbo_trangThaiDonHang1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_trangThaiDonHang1.Name = "cbo_trangThaiDonHang1";
            this.cbo_trangThaiDonHang1.Size = new System.Drawing.Size(579, 33);
            this.cbo_trangThaiDonHang1.TabIndex = 30;
            this.cbo_trangThaiDonHang1.Text = "--- Chọn ---";
            // 
            // txt_ghiChu
            // 
            this.txt_ghiChu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_ghiChu.Location = new System.Drawing.Point(1180, 361);
            this.txt_ghiChu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ghiChu.Multiline = true;
            this.txt_ghiChu.Name = "txt_ghiChu";
            this.txt_ghiChu.ReadOnly = true;
            this.txt_ghiChu.Size = new System.Drawing.Size(579, 32);
            this.txt_ghiChu.TabIndex = 29;
            // 
            // txt_diaChiGiaoHang
            // 
            this.txt_diaChiGiaoHang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_diaChiGiaoHang.Location = new System.Drawing.Point(1180, 302);
            this.txt_diaChiGiaoHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_diaChiGiaoHang.Multiline = true;
            this.txt_diaChiGiaoHang.Name = "txt_diaChiGiaoHang";
            this.txt_diaChiGiaoHang.ReadOnly = true;
            this.txt_diaChiGiaoHang.Size = new System.Drawing.Size(579, 32);
            this.txt_diaChiGiaoHang.TabIndex = 28;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_email.Location = new System.Drawing.Point(1180, 244);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_email.Multiline = true;
            this.txt_email.Name = "txt_email";
            this.txt_email.ReadOnly = true;
            this.txt_email.Size = new System.Drawing.Size(579, 32);
            this.txt_email.TabIndex = 27;
            // 
            // txt_sdt
            // 
            this.txt_sdt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_sdt.Location = new System.Drawing.Point(1180, 185);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_sdt.Multiline = true;
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.ReadOnly = true;
            this.txt_sdt.Size = new System.Drawing.Size(579, 32);
            this.txt_sdt.TabIndex = 26;
            // 
            // txt_hoTenNguoiNhan
            // 
            this.txt_hoTenNguoiNhan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_hoTenNguoiNhan.Location = new System.Drawing.Point(1180, 126);
            this.txt_hoTenNguoiNhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_hoTenNguoiNhan.Multiline = true;
            this.txt_hoTenNguoiNhan.Name = "txt_hoTenNguoiNhan";
            this.txt_hoTenNguoiNhan.ReadOnly = true;
            this.txt_hoTenNguoiNhan.Size = new System.Drawing.Size(579, 32);
            this.txt_hoTenNguoiNhan.TabIndex = 25;
            // 
            // txt_hinhThucThanhToan
            // 
            this.txt_hinhThucThanhToan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_hinhThucThanhToan.Location = new System.Drawing.Point(1180, 68);
            this.txt_hinhThucThanhToan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_hinhThucThanhToan.Multiline = true;
            this.txt_hinhThucThanhToan.Name = "txt_hinhThucThanhToan";
            this.txt_hinhThucThanhToan.ReadOnly = true;
            this.txt_hinhThucThanhToan.Size = new System.Drawing.Size(579, 32);
            this.txt_hinhThucThanhToan.TabIndex = 24;
            // 
            // txt_thanhTien
            // 
            this.txt_thanhTien.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_thanhTien.Location = new System.Drawing.Point(251, 480);
            this.txt_thanhTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_thanhTien.Multiline = true;
            this.txt_thanhTien.Name = "txt_thanhTien";
            this.txt_thanhTien.ReadOnly = true;
            this.txt_thanhTien.Size = new System.Drawing.Size(579, 32);
            this.txt_thanhTien.TabIndex = 23;
            // 
            // txt_tongGiamGia
            // 
            this.txt_tongGiamGia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_tongGiamGia.Location = new System.Drawing.Point(251, 420);
            this.txt_tongGiamGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tongGiamGia.Multiline = true;
            this.txt_tongGiamGia.Name = "txt_tongGiamGia";
            this.txt_tongGiamGia.ReadOnly = true;
            this.txt_tongGiamGia.Size = new System.Drawing.Size(579, 32);
            this.txt_tongGiamGia.TabIndex = 22;
            // 
            // txt_tongTien
            // 
            this.txt_tongTien.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_tongTien.Location = new System.Drawing.Point(251, 361);
            this.txt_tongTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tongTien.Multiline = true;
            this.txt_tongTien.Name = "txt_tongTien";
            this.txt_tongTien.ReadOnly = true;
            this.txt_tongTien.Size = new System.Drawing.Size(579, 32);
            this.txt_tongTien.TabIndex = 21;
            // 
            // txt_phiShip
            // 
            this.txt_phiShip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_phiShip.Location = new System.Drawing.Point(251, 302);
            this.txt_phiShip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_phiShip.Multiline = true;
            this.txt_phiShip.Name = "txt_phiShip";
            this.txt_phiShip.ReadOnly = true;
            this.txt_phiShip.Size = new System.Drawing.Size(579, 32);
            this.txt_phiShip.TabIndex = 20;
            // 
            // txt_maGiamGia
            // 
            this.txt_maGiamGia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_maGiamGia.Location = new System.Drawing.Point(251, 244);
            this.txt_maGiamGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_maGiamGia.Multiline = true;
            this.txt_maGiamGia.Name = "txt_maGiamGia";
            this.txt_maGiamGia.ReadOnly = true;
            this.txt_maGiamGia.Size = new System.Drawing.Size(579, 32);
            this.txt_maGiamGia.TabIndex = 19;
            // 
            // txt_maThanhVien
            // 
            this.txt_maThanhVien.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_maThanhVien.Location = new System.Drawing.Point(251, 185);
            this.txt_maThanhVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_maThanhVien.Multiline = true;
            this.txt_maThanhVien.Name = "txt_maThanhVien";
            this.txt_maThanhVien.ReadOnly = true;
            this.txt_maThanhVien.Size = new System.Drawing.Size(579, 32);
            this.txt_maThanhVien.TabIndex = 18;
            // 
            // txt_ngayLap
            // 
            this.txt_ngayLap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_ngayLap.Location = new System.Drawing.Point(251, 126);
            this.txt_ngayLap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ngayLap.Multiline = true;
            this.txt_ngayLap.Name = "txt_ngayLap";
            this.txt_ngayLap.ReadOnly = true;
            this.txt_ngayLap.Size = new System.Drawing.Size(579, 32);
            this.txt_ngayLap.TabIndex = 17;
            // 
            // txt_soDonHang
            // 
            this.txt_soDonHang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_soDonHang.Location = new System.Drawing.Point(251, 68);
            this.txt_soDonHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_soDonHang.Multiline = true;
            this.txt_soDonHang.Name = "txt_soDonHang";
            this.txt_soDonHang.ReadOnly = true;
            this.txt_soDonHang.Size = new System.Drawing.Size(579, 32);
            this.txt_soDonHang.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(930, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Số điện thoại:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(930, 420);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(211, 25);
            this.label11.TabIndex = 13;
            this.label11.Text = "Trạng thái đơn hàng:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(930, 361);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 25);
            this.label12.TabIndex = 12;
            this.label12.Text = "Ghi chú:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(930, 302);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(192, 25);
            this.label13.TabIndex = 11;
            this.label13.Text = "Địa chỉ nhận hàng:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(930, 244);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 25);
            this.label14.TabIndex = 10;
            this.label14.Text = "Email:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(930, 126);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(194, 25);
            this.label15.TabIndex = 9;
            this.label15.Text = "Họ tên người nhận:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(930, 68);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(217, 25);
            this.label16.TabIndex = 8;
            this.label16.Text = "Hình thức thanh toán:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 480);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Thành tiền:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tổng giảm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tổng tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phí ship:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã giảm giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã thành viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày lập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số đơn hàng:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(1125, 49);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(768, 506);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết đơn đặt hàng:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(40, 54);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(692, 418);
            this.dataGridView2.TabIndex = 1;
            // 
            // Frm_QLDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_QLDonDatHang";
            this.Text = "Frm_QLDonDatHang";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbo_trangThaiDonHang1;
        private System.Windows.Forms.TextBox txt_ghiChu;
        private System.Windows.Forms.TextBox txt_diaChiGiaoHang;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_hoTenNguoiNhan;
        private System.Windows.Forms.TextBox txt_hinhThucThanhToan;
        private System.Windows.Forms.TextBox txt_thanhTien;
        private System.Windows.Forms.TextBox txt_tongGiamGia;
        private System.Windows.Forms.TextBox txt_tongTien;
        private System.Windows.Forms.TextBox txt_phiShip;
        private System.Windows.Forms.TextBox txt_maGiamGia;
        private System.Windows.Forms.TextBox txt_maThanhVien;
        private System.Windows.Forms.TextBox txt_ngayLap;
        private System.Windows.Forms.TextBox txt_soDonHang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_loc;
        private System.Windows.Forms.ComboBox cbo_trangThaiDonHang;
        private System.Windows.Forms.Label label10;
    }
}