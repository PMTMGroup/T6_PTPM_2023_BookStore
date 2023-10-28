namespace Frm_DangNhap
{
    partial class Frm_QLHoaDonBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_QLHoaDonBan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gv_dsHoaDonBanHang = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_lamMoi = new System.Windows.Forms.Button();
            this.btn_timKiem = new System.Windows.Forms.Button();
            this.rdo_nguoiLap = new System.Windows.Forms.RadioButton();
            this.rdo_maTV = new System.Windows.Forms.RadioButton();
            this.rdo_ngayLap = new System.Windows.Forms.RadioButton();
            this.rdo_soHD = new System.Windows.Forms.RadioButton();
            this.txt_nguoiLap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_maThanhVien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_soHoaDon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gv_chiTietHoaDonBanHang = new System.Windows.Forms.DataGridView();
            this.date_NgayLap = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_dsHoaDonBanHang)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_chiTietHoaDonBanHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gv_dsHoaDonBanHang);
            this.groupBox1.Location = new System.Drawing.Point(28, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1056, 717);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hóa đơn bán hàng:";
            // 
            // gv_dsHoaDonBanHang
            // 
            this.gv_dsHoaDonBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_dsHoaDonBanHang.Location = new System.Drawing.Point(23, 43);
            this.gv_dsHoaDonBanHang.Name = "gv_dsHoaDonBanHang";
            this.gv_dsHoaDonBanHang.RowHeadersWidth = 62;
            this.gv_dsHoaDonBanHang.RowTemplate.Height = 24;
            this.gv_dsHoaDonBanHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_dsHoaDonBanHang.Size = new System.Drawing.Size(1010, 655);
            this.gv_dsHoaDonBanHang.TabIndex = 0;
            this.gv_dsHoaDonBanHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_dsHoaDonBanHang_CellContentClick);
            this.gv_dsHoaDonBanHang.SelectionChanged += new System.EventHandler(this.gv_dsHoaDonBanHang_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.date_NgayLap);
            this.groupBox2.Controls.Add(this.btn_lamMoi);
            this.groupBox2.Controls.Add(this.btn_timKiem);
            this.groupBox2.Controls.Add(this.rdo_nguoiLap);
            this.groupBox2.Controls.Add(this.rdo_maTV);
            this.groupBox2.Controls.Add(this.rdo_ngayLap);
            this.groupBox2.Controls.Add(this.rdo_soHD);
            this.groupBox2.Controls.Add(this.txt_nguoiLap);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_maThanhVien);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_soHoaDon);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(28, 756);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1690, 203);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm hóa đơn bán hàng:";
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_lamMoi.Image")));
            this.btn_lamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lamMoi.Location = new System.Drawing.Point(1248, 138);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_lamMoi.Size = new System.Drawing.Size(200, 50);
            this.btn_lamMoi.TabIndex = 36;
            this.btn_lamMoi.Text = "    Làm mới";
            this.btn_lamMoi.UseVisualStyleBackColor = true;
            this.btn_lamMoi.Click += new System.EventHandler(this.btn_lamMoi_Click);
            // 
            // btn_timKiem
            // 
            this.btn_timKiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_timKiem.Image")));
            this.btn_timKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timKiem.Location = new System.Drawing.Point(1454, 138);
            this.btn_timKiem.Name = "btn_timKiem";
            this.btn_timKiem.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btn_timKiem.Size = new System.Drawing.Size(216, 50);
            this.btn_timKiem.TabIndex = 35;
            this.btn_timKiem.Text = "    Tìm kiếm";
            this.btn_timKiem.UseVisualStyleBackColor = true;
            this.btn_timKiem.Click += new System.EventHandler(this.btn_timKiem_Click);
            // 
            // rdo_nguoiLap
            // 
            this.rdo_nguoiLap.AutoSize = true;
            this.rdo_nguoiLap.Location = new System.Drawing.Point(1299, 89);
            this.rdo_nguoiLap.Name = "rdo_nguoiLap";
            this.rdo_nguoiLap.Size = new System.Drawing.Size(17, 16);
            this.rdo_nguoiLap.TabIndex = 34;
            this.rdo_nguoiLap.UseVisualStyleBackColor = true;
            this.rdo_nguoiLap.CheckedChanged += new System.EventHandler(this.rdo_nguoiLap_CheckedChanged);
            // 
            // rdo_maTV
            // 
            this.rdo_maTV.AutoSize = true;
            this.rdo_maTV.Location = new System.Drawing.Point(847, 89);
            this.rdo_maTV.Name = "rdo_maTV";
            this.rdo_maTV.Size = new System.Drawing.Size(17, 16);
            this.rdo_maTV.TabIndex = 33;
            this.rdo_maTV.UseVisualStyleBackColor = true;
            this.rdo_maTV.CheckedChanged += new System.EventHandler(this.rdo_maTV_CheckedChanged);
            // 
            // rdo_ngayLap
            // 
            this.rdo_ngayLap.AutoSize = true;
            this.rdo_ngayLap.Location = new System.Drawing.Point(442, 89);
            this.rdo_ngayLap.Name = "rdo_ngayLap";
            this.rdo_ngayLap.Size = new System.Drawing.Size(17, 16);
            this.rdo_ngayLap.TabIndex = 32;
            this.rdo_ngayLap.UseVisualStyleBackColor = true;
            this.rdo_ngayLap.CheckedChanged += new System.EventHandler(this.rdo_ngayLap_CheckedChanged);
            // 
            // rdo_soHD
            // 
            this.rdo_soHD.AutoSize = true;
            this.rdo_soHD.Checked = true;
            this.rdo_soHD.Location = new System.Drawing.Point(23, 89);
            this.rdo_soHD.Name = "rdo_soHD";
            this.rdo_soHD.Size = new System.Drawing.Size(17, 16);
            this.rdo_soHD.TabIndex = 31;
            this.rdo_soHD.TabStop = true;
            this.rdo_soHD.UseVisualStyleBackColor = true;
            this.rdo_soHD.CheckedChanged += new System.EventHandler(this.rdo_soHD_CheckedChanged);
            // 
            // txt_nguoiLap
            // 
            this.txt_nguoiLap.Enabled = false;
            this.txt_nguoiLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nguoiLap.Location = new System.Drawing.Point(1415, 48);
            this.txt_nguoiLap.Name = "txt_nguoiLap";
            this.txt_nguoiLap.Size = new System.Drawing.Size(255, 27);
            this.txt_nguoiLap.TabIndex = 30;
            this.txt_nguoiLap.TextChanged += new System.EventHandler(this.txt_nguoiLap_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1295, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Người lập:";
            // 
            // txt_maThanhVien
            // 
            this.txt_maThanhVien.Enabled = false;
            this.txt_maThanhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maThanhVien.Location = new System.Drawing.Point(979, 48);
            this.txt_maThanhVien.Name = "txt_maThanhVien";
            this.txt_maThanhVien.Size = new System.Drawing.Size(255, 27);
            this.txt_maThanhVien.TabIndex = 28;
            this.txt_maThanhVien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_maThanhVien_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(843, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Mã thành viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(438, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ngày lập:";
            // 
            // txt_soHoaDon
            // 
            this.txt_soHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soHoaDon.Location = new System.Drawing.Point(142, 48);
            this.txt_soHoaDon.Name = "txt_soHoaDon";
            this.txt_soHoaDon.Size = new System.Drawing.Size(241, 27);
            this.txt_soHoaDon.TabIndex = 24;
            this.txt_soHoaDon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soHoaDon_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Số hóa đơn:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gv_chiTietHoaDonBanHang);
            this.groupBox3.Location = new System.Drawing.Point(1109, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(609, 717);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết hóa đơn bán hàng:";
            // 
            // gv_chiTietHoaDonBanHang
            // 
            this.gv_chiTietHoaDonBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_chiTietHoaDonBanHang.Location = new System.Drawing.Point(22, 43);
            this.gv_chiTietHoaDonBanHang.Name = "gv_chiTietHoaDonBanHang";
            this.gv_chiTietHoaDonBanHang.RowHeadersWidth = 62;
            this.gv_chiTietHoaDonBanHang.RowTemplate.Height = 24;
            this.gv_chiTietHoaDonBanHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_chiTietHoaDonBanHang.Size = new System.Drawing.Size(567, 655);
            this.gv_chiTietHoaDonBanHang.TabIndex = 1;
            // 
            // date_NgayLap
            // 
            this.date_NgayLap.Enabled = false;
            this.date_NgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_NgayLap.Location = new System.Drawing.Point(542, 48);
            this.date_NgayLap.Name = "date_NgayLap";
            this.date_NgayLap.Size = new System.Drawing.Size(246, 27);
            this.date_NgayLap.TabIndex = 37;
            // 
            // Frm_QLHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1730, 978);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_QLHoaDonBan";
            this.Text = "Frm_QLHoaDonBan";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_dsHoaDonBanHang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_chiTietHoaDonBanHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gv_dsHoaDonBanHang;
        private System.Windows.Forms.DataGridView gv_chiTietHoaDonBanHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_soHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_maThanhVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nguoiLap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdo_nguoiLap;
        private System.Windows.Forms.RadioButton rdo_maTV;
        private System.Windows.Forms.RadioButton rdo_ngayLap;
        private System.Windows.Forms.RadioButton rdo_soHD;
        private System.Windows.Forms.Button btn_lamMoi;
        private System.Windows.Forms.Button btn_timKiem;
        private System.Windows.Forms.DateTimePicker date_NgayLap;
    }
}