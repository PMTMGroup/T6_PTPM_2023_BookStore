namespace Frm_DangNhap
{
    partial class Frm_QLThanhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_QLThanhVien));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_thanhvien = new System.Windows.Forms.DataGridView();
            this.btn_TTTV_luu = new System.Windows.Forms.Button();
            this.btn_TTTV_lamMoi = new System.Windows.Forms.Button();
            this.btn_TTTV_xoa = new System.Windows.Forms.Button();
            this.btn_TTTV_them = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_TTTV_matKhau = new System.Windows.Forms.TextBox();
            this.txt_TTTV_soTienDaMua = new System.Windows.Forms.TextBox();
            this.txt_TTTV_sdt = new System.Windows.Forms.TextBox();
            this.txt_TTTV_tenThanhVien = new System.Windows.Forms.TextBox();
            this.txt_TTTV_maThanhVien = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gv_TCTTTV_ketQuaTraCuu = new System.Windows.Forms.DataGridView();
            this.btn_TCTTTV_lamMoi = new System.Windows.Forms.Button();
            this.btn_TCTTTV_traCuu = new System.Windows.Forms.Button();
            this.txt_TCTTTV_sdt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_QLLTV_luu = new System.Windows.Forms.Button();
            this.txt_QLLTV_soTienCanDat = new System.Windows.Forms.TextBox();
            this.btn_QLLTV_lamMoi = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_QLLTV_xoa = new System.Windows.Forms.Button();
            this.btn_QLLTV_them = new System.Windows.Forms.Button();
            this.txt_QLLTV_tenLoaiThanhVien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_QLLTV_phanTramGiamGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_loaiTV = new System.Windows.Forms.DataGridView();
            this.txt_QLLTV_maLoaiThanhVien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_TTTV_loaiThanhVien = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thanhvien)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_TCTTTV_ketQuaTraCuu)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaiTV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_thanhvien);
            this.groupBox3.Controls.Add(this.btn_TTTV_luu);
            this.groupBox3.Controls.Add(this.btn_TTTV_lamMoi);
            this.groupBox3.Controls.Add(this.btn_TTTV_xoa);
            this.groupBox3.Controls.Add(this.btn_TTTV_them);
            this.groupBox3.Controls.Add(this.cbo_TTTV_loaiThanhVien);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txt_TTTV_matKhau);
            this.groupBox3.Controls.Add(this.txt_TTTV_soTienDaMua);
            this.groupBox3.Controls.Add(this.txt_TTTV_sdt);
            this.groupBox3.Controls.Add(this.txt_TTTV_tenThanhVien);
            this.groupBox3.Controls.Add(this.txt_TTTV_maThanhVien);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Location = new System.Drawing.Point(33, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(835, 929);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin thành viên:";
            // 
            // dgv_thanhvien
            // 
            this.dgv_thanhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thanhvien.Location = new System.Drawing.Point(37, 449);
            this.dgv_thanhvien.Name = "dgv_thanhvien";
            this.dgv_thanhvien.RowHeadersWidth = 62;
            this.dgv_thanhvien.RowTemplate.Height = 24;
            this.dgv_thanhvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_thanhvien.Size = new System.Drawing.Size(761, 463);
            this.dgv_thanhvien.TabIndex = 39;
            this.dgv_thanhvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_thanhvien_CellContentClick);
            this.dgv_thanhvien.SelectionChanged += new System.EventHandler(this.dgv_thanhvien_SelectionChanged);
            // 
            // btn_TTTV_luu
            // 
            this.btn_TTTV_luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_TTTV_luu.Image")));
            this.btn_TTTV_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TTTV_luu.Location = new System.Drawing.Point(299, 370);
            this.btn_TTTV_luu.Name = "btn_TTTV_luu";
            this.btn_TTTV_luu.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_TTTV_luu.Size = new System.Drawing.Size(163, 50);
            this.btn_TTTV_luu.TabIndex = 38;
            this.btn_TTTV_luu.Text = "    Lưu";
            this.btn_TTTV_luu.UseVisualStyleBackColor = true;
            // 
            // btn_TTTV_lamMoi
            // 
            this.btn_TTTV_lamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_TTTV_lamMoi.Image")));
            this.btn_TTTV_lamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TTTV_lamMoi.Location = new System.Drawing.Point(635, 370);
            this.btn_TTTV_lamMoi.Name = "btn_TTTV_lamMoi";
            this.btn_TTTV_lamMoi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_TTTV_lamMoi.Size = new System.Drawing.Size(163, 50);
            this.btn_TTTV_lamMoi.TabIndex = 37;
            this.btn_TTTV_lamMoi.Text = "      Làm mới";
            this.btn_TTTV_lamMoi.UseVisualStyleBackColor = true;
            this.btn_TTTV_lamMoi.Click += new System.EventHandler(this.btn_TTTV_lamMoi_Click);
            // 
            // btn_TTTV_xoa
            // 
            this.btn_TTTV_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_TTTV_xoa.Image")));
            this.btn_TTTV_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TTTV_xoa.Location = new System.Drawing.Point(467, 370);
            this.btn_TTTV_xoa.Name = "btn_TTTV_xoa";
            this.btn_TTTV_xoa.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_TTTV_xoa.Size = new System.Drawing.Size(163, 50);
            this.btn_TTTV_xoa.TabIndex = 36;
            this.btn_TTTV_xoa.Text = "   Xóa";
            this.btn_TTTV_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_TTTV_them
            // 
            this.btn_TTTV_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_TTTV_them.Image")));
            this.btn_TTTV_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TTTV_them.Location = new System.Drawing.Point(131, 370);
            this.btn_TTTV_them.Name = "btn_TTTV_them";
            this.btn_TTTV_them.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_TTTV_them.Size = new System.Drawing.Size(163, 50);
            this.btn_TTTV_them.TabIndex = 35;
            this.btn_TTTV_them.Text = "    Thêm";
            this.btn_TTTV_them.UseVisualStyleBackColor = true;
            this.btn_TTTV_them.Click += new System.EventHandler(this.btn_TTTV_them_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(35, 309);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 20);
            this.label14.TabIndex = 33;
            this.label14.Text = "Loại thành viên:";
            // 
            // txt_TTTV_matKhau
            // 
            this.txt_TTTV_matKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TTTV_matKhau.Location = new System.Drawing.Point(210, 250);
            this.txt_TTTV_matKhau.Name = "txt_TTTV_matKhau";
            this.txt_TTTV_matKhau.PasswordChar = '*';
            this.txt_TTTV_matKhau.Size = new System.Drawing.Size(588, 27);
            this.txt_TTTV_matKhau.TabIndex = 32;
            // 
            // txt_TTTV_soTienDaMua
            // 
            this.txt_TTTV_soTienDaMua.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_TTTV_soTienDaMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TTTV_soTienDaMua.Location = new System.Drawing.Point(210, 195);
            this.txt_TTTV_soTienDaMua.Name = "txt_TTTV_soTienDaMua";
            this.txt_TTTV_soTienDaMua.ReadOnly = true;
            this.txt_TTTV_soTienDaMua.Size = new System.Drawing.Size(588, 27);
            this.txt_TTTV_soTienDaMua.TabIndex = 31;
            // 
            // txt_TTTV_sdt
            // 
            this.txt_TTTV_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TTTV_sdt.Location = new System.Drawing.Point(210, 143);
            this.txt_TTTV_sdt.Name = "txt_TTTV_sdt";
            this.txt_TTTV_sdt.Size = new System.Drawing.Size(588, 27);
            this.txt_TTTV_sdt.TabIndex = 29;
            // 
            // txt_TTTV_tenThanhVien
            // 
            this.txt_TTTV_tenThanhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TTTV_tenThanhVien.Location = new System.Drawing.Point(210, 92);
            this.txt_TTTV_tenThanhVien.Name = "txt_TTTV_tenThanhVien";
            this.txt_TTTV_tenThanhVien.Size = new System.Drawing.Size(588, 27);
            this.txt_TTTV_tenThanhVien.TabIndex = 28;
            // 
            // txt_TTTV_maThanhVien
            // 
            this.txt_TTTV_maThanhVien.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_TTTV_maThanhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TTTV_maThanhVien.Location = new System.Drawing.Point(210, 41);
            this.txt_TTTV_maThanhVien.Name = "txt_TTTV_maThanhVien";
            this.txt_TTTV_maThanhVien.ReadOnly = true;
            this.txt_TTTV_maThanhVien.Size = new System.Drawing.Size(588, 27);
            this.txt_TTTV_maThanhVien.TabIndex = 27;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(33, 253);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 20);
            this.label20.TabIndex = 5;
            this.label20.Text = "Mật khẩu:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(33, 198);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(126, 20);
            this.label21.TabIndex = 4;
            this.label21.Text = "Số tiền đã mua:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(33, 146);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(111, 20);
            this.label25.TabIndex = 2;
            this.label25.Text = "Số điện thoại:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(33, 95);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(123, 20);
            this.label26.TabIndex = 1;
            this.label26.Text = "Tên thành viên:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(33, 44);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(118, 20);
            this.label27.TabIndex = 0;
            this.label27.Text = "Mã thành viên:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.gv_TCTTTV_ketQuaTraCuu);
            this.groupBox1.Controls.Add(this.btn_TCTTTV_lamMoi);
            this.groupBox1.Controls.Add(this.btn_TCTTTV_traCuu);
            this.groupBox1.Controls.Add(this.txt_TCTTTV_sdt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(883, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 352);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tra cứu thông tin thành viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Kết quả tra cứu:";
            // 
            // gv_TCTTTV_ketQuaTraCuu
            // 
            this.gv_TCTTTV_ketQuaTraCuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_TCTTTV_ketQuaTraCuu.Location = new System.Drawing.Point(37, 210);
            this.gv_TCTTTV_ketQuaTraCuu.Name = "gv_TCTTTV_ketQuaTraCuu";
            this.gv_TCTTTV_ketQuaTraCuu.RowHeadersWidth = 62;
            this.gv_TCTTTV_ketQuaTraCuu.RowTemplate.Height = 24;
            this.gv_TCTTTV_ketQuaTraCuu.Size = new System.Drawing.Size(729, 119);
            this.gv_TCTTTV_ketQuaTraCuu.TabIndex = 39;
            // 
            // btn_TCTTTV_lamMoi
            // 
            this.btn_TCTTTV_lamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_TCTTTV_lamMoi.Image")));
            this.btn_TCTTTV_lamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TCTTTV_lamMoi.Location = new System.Drawing.Point(325, 95);
            this.btn_TCTTTV_lamMoi.Name = "btn_TCTTTV_lamMoi";
            this.btn_TCTTTV_lamMoi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_TCTTTV_lamMoi.Size = new System.Drawing.Size(163, 50);
            this.btn_TCTTTV_lamMoi.TabIndex = 37;
            this.btn_TCTTTV_lamMoi.Text = "      Làm mới";
            this.btn_TCTTTV_lamMoi.UseVisualStyleBackColor = true;
            this.btn_TCTTTV_lamMoi.Click += new System.EventHandler(this.btn_TCTTTV_lamMoi_Click);
            // 
            // btn_TCTTTV_traCuu
            // 
            this.btn_TCTTTV_traCuu.Image = ((System.Drawing.Image)(resources.GetObject("btn_TCTTTV_traCuu.Image")));
            this.btn_TCTTTV_traCuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TCTTTV_traCuu.Location = new System.Drawing.Point(494, 95);
            this.btn_TCTTTV_traCuu.Name = "btn_TCTTTV_traCuu";
            this.btn_TCTTTV_traCuu.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_TCTTTV_traCuu.Size = new System.Drawing.Size(272, 50);
            this.btn_TCTTTV_traCuu.TabIndex = 35;
            this.btn_TCTTTV_traCuu.Text = "    Tra cứu";
            this.btn_TCTTTV_traCuu.UseVisualStyleBackColor = true;
            // 
            // txt_TCTTTV_sdt
            // 
            this.txt_TCTTTV_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TCTTTV_sdt.Location = new System.Drawing.Point(210, 44);
            this.txt_TCTTTV_sdt.Name = "txt_TCTTTV_sdt";
            this.txt_TCTTTV_sdt.Size = new System.Drawing.Size(556, 27);
            this.txt_TCTTTV_sdt.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số điện thoại:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_QLLTV_luu);
            this.groupBox2.Controls.Add(this.txt_QLLTV_soTienCanDat);
            this.groupBox2.Controls.Add(this.btn_QLLTV_lamMoi);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btn_QLLTV_xoa);
            this.groupBox2.Controls.Add(this.btn_QLLTV_them);
            this.groupBox2.Controls.Add(this.txt_QLLTV_tenLoaiThanhVien);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_QLLTV_phanTramGiamGia);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dgv_loaiTV);
            this.groupBox2.Controls.Add(this.txt_QLLTV_maLoaiThanhVien);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(883, 396);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(790, 559);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản lý loại thành viên:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn_QLLTV_luu
            // 
            this.btn_QLLTV_luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_QLLTV_luu.Image")));
            this.btn_QLLTV_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QLLTV_luu.Location = new System.Drawing.Point(267, 252);
            this.btn_QLLTV_luu.Name = "btn_QLLTV_luu";
            this.btn_QLLTV_luu.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_QLLTV_luu.Size = new System.Drawing.Size(163, 50);
            this.btn_QLLTV_luu.TabIndex = 43;
            this.btn_QLLTV_luu.Text = "    Lưu";
            this.btn_QLLTV_luu.UseVisualStyleBackColor = true;
            this.btn_QLLTV_luu.Click += new System.EventHandler(this.btn_QLLTV_luu_Click);
            // 
            // txt_QLLTV_soTienCanDat
            // 
            this.txt_QLLTV_soTienCanDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_QLLTV_soTienCanDat.Location = new System.Drawing.Point(234, 150);
            this.txt_QLLTV_soTienCanDat.Name = "txt_QLLTV_soTienCanDat";
            this.txt_QLLTV_soTienCanDat.Size = new System.Drawing.Size(532, 27);
            this.txt_QLLTV_soTienCanDat.TabIndex = 43;
            this.txt_QLLTV_soTienCanDat.TextChanged += new System.EventHandler(this.txt_QLLTV_soTienCanDat_TextChanged);
            this.txt_QLLTV_soTienCanDat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_QLLTV_soTienCanDat_KeyPress);
            // 
            // btn_QLLTV_lamMoi
            // 
            this.btn_QLLTV_lamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_QLLTV_lamMoi.Image")));
            this.btn_QLLTV_lamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QLLTV_lamMoi.Location = new System.Drawing.Point(603, 252);
            this.btn_QLLTV_lamMoi.Name = "btn_QLLTV_lamMoi";
            this.btn_QLLTV_lamMoi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_QLLTV_lamMoi.Size = new System.Drawing.Size(163, 50);
            this.btn_QLLTV_lamMoi.TabIndex = 42;
            this.btn_QLLTV_lamMoi.Text = "      Làm mới";
            this.btn_QLLTV_lamMoi.UseVisualStyleBackColor = true;
            this.btn_QLLTV_lamMoi.Click += new System.EventHandler(this.btn_QLLTV_lamMoi_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "Số tiền cần đạt:";
            // 
            // btn_QLLTV_xoa
            // 
            this.btn_QLLTV_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_QLLTV_xoa.Image")));
            this.btn_QLLTV_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QLLTV_xoa.Location = new System.Drawing.Point(435, 252);
            this.btn_QLLTV_xoa.Name = "btn_QLLTV_xoa";
            this.btn_QLLTV_xoa.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_QLLTV_xoa.Size = new System.Drawing.Size(163, 50);
            this.btn_QLLTV_xoa.TabIndex = 41;
            this.btn_QLLTV_xoa.Text = "   Xóa";
            this.btn_QLLTV_xoa.UseVisualStyleBackColor = true;
            this.btn_QLLTV_xoa.Click += new System.EventHandler(this.btn_QLLTV_xoa_Click);
            // 
            // btn_QLLTV_them
            // 
            this.btn_QLLTV_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_QLLTV_them.Image")));
            this.btn_QLLTV_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QLLTV_them.Location = new System.Drawing.Point(99, 252);
            this.btn_QLLTV_them.Name = "btn_QLLTV_them";
            this.btn_QLLTV_them.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_QLLTV_them.Size = new System.Drawing.Size(163, 50);
            this.btn_QLLTV_them.TabIndex = 40;
            this.btn_QLLTV_them.Text = "    Thêm";
            this.btn_QLLTV_them.UseVisualStyleBackColor = true;
            this.btn_QLLTV_them.Click += new System.EventHandler(this.btn_QLLTV_them_Click);
            // 
            // txt_QLLTV_tenLoaiThanhVien
            // 
            this.txt_QLLTV_tenLoaiThanhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_QLLTV_tenLoaiThanhVien.Location = new System.Drawing.Point(234, 97);
            this.txt_QLLTV_tenLoaiThanhVien.Name = "txt_QLLTV_tenLoaiThanhVien";
            this.txt_QLLTV_tenLoaiThanhVien.Size = new System.Drawing.Size(532, 27);
            this.txt_QLLTV_tenLoaiThanhVien.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Tên loại thành viên:";
            // 
            // txt_QLLTV_phanTramGiamGia
            // 
            this.txt_QLLTV_phanTramGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_QLLTV_phanTramGiamGia.Location = new System.Drawing.Point(234, 203);
            this.txt_QLLTV_phanTramGiamGia.Name = "txt_QLLTV_phanTramGiamGia";
            this.txt_QLLTV_phanTramGiamGia.Size = new System.Drawing.Size(532, 27);
            this.txt_QLLTV_phanTramGiamGia.TabIndex = 41;
            this.txt_QLLTV_phanTramGiamGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_QLLTV_phanTramGiamGia_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Phần trăm giảm giá:";
            // 
            // dgv_loaiTV
            // 
            this.dgv_loaiTV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_loaiTV.Location = new System.Drawing.Point(37, 322);
            this.dgv_loaiTV.Name = "dgv_loaiTV";
            this.dgv_loaiTV.RowHeadersWidth = 62;
            this.dgv_loaiTV.RowTemplate.Height = 24;
            this.dgv_loaiTV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_loaiTV.Size = new System.Drawing.Size(729, 220);
            this.dgv_loaiTV.TabIndex = 39;
            this.dgv_loaiTV.SelectionChanged += new System.EventHandler(this.dgv_loaiTV_SelectionChanged);
            // 
            // txt_QLLTV_maLoaiThanhVien
            // 
            this.txt_QLLTV_maLoaiThanhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_QLLTV_maLoaiThanhVien.Location = new System.Drawing.Point(234, 44);
            this.txt_QLLTV_maLoaiThanhVien.Name = "txt_QLLTV_maLoaiThanhVien";
            this.txt_QLLTV_maLoaiThanhVien.Size = new System.Drawing.Size(532, 27);
            this.txt_QLLTV_maLoaiThanhVien.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã loại thành viên:";
            // 
            // cbo_TTTV_loaiThanhVien
            // 
            this.cbo_TTTV_loaiThanhVien.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_TTTV_loaiThanhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_TTTV_loaiThanhVien.FormattingEnabled = true;
            this.cbo_TTTV_loaiThanhVien.Location = new System.Drawing.Point(210, 306);
            this.cbo_TTTV_loaiThanhVien.Name = "cbo_TTTV_loaiThanhVien";
            this.cbo_TTTV_loaiThanhVien.Size = new System.Drawing.Size(257, 28);
            this.cbo_TTTV_loaiThanhVien.TabIndex = 34;
            this.cbo_TTTV_loaiThanhVien.Text = "--- Chọn ---";
            this.cbo_TTTV_loaiThanhVien.SelectedIndexChanged += new System.EventHandler(this.cbo_TTTV_loaiThanhVien_SelectedIndexChanged);
            // 
            // Frm_QLThanhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1721, 885);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_QLThanhVien";
            this.Text = "Frm_QLThanhVien";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thanhvien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_TCTTTV_ketQuaTraCuu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaiTV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_thanhvien;
        private System.Windows.Forms.Button btn_TTTV_luu;
        private System.Windows.Forms.Button btn_TTTV_lamMoi;
        private System.Windows.Forms.Button btn_TTTV_xoa;
        private System.Windows.Forms.Button btn_TTTV_them;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_TTTV_matKhau;
        private System.Windows.Forms.TextBox txt_TTTV_soTienDaMua;
        private System.Windows.Forms.TextBox txt_TTTV_sdt;
        private System.Windows.Forms.TextBox txt_TTTV_tenThanhVien;
        private System.Windows.Forms.TextBox txt_TTTV_maThanhVien;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gv_TCTTTV_ketQuaTraCuu;
        private System.Windows.Forms.Button btn_TCTTTV_lamMoi;
        private System.Windows.Forms.Button btn_TCTTTV_traCuu;
        private System.Windows.Forms.TextBox txt_TCTTTV_sdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_QLLTV_soTienCanDat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_QLLTV_tenLoaiThanhVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_QLLTV_phanTramGiamGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_loaiTV;
        private System.Windows.Forms.TextBox txt_QLLTV_maLoaiThanhVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_QLLTV_luu;
        private System.Windows.Forms.Button btn_QLLTV_lamMoi;
        private System.Windows.Forms.Button btn_QLLTV_xoa;
        private System.Windows.Forms.Button btn_QLLTV_them;
        private System.Windows.Forms.ComboBox cbo_TTTV_loaiThanhVien;
    }
}