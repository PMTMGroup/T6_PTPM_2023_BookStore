namespace Frm_DangNhap
{
    partial class Frm_QLPhieuGiamGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_QLPhieuGiamGia));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtp_ngayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtp_ngayBatDau = new System.Windows.Forms.DateTimePicker();
            this.txt_maGiamGia = new System.Windows.Forms.TextBox();
            this.num_phanTramGiam = new System.Windows.Forms.NumericUpDown();
            this.gv_thongTinUuDai = new System.Windows.Forms.DataGridView();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_lamMoi = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_tenUuDai = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_phanTramGiam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_thongTinUuDai)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtp_ngayKetThuc);
            this.groupBox3.Controls.Add(this.dtp_ngayBatDau);
            this.groupBox3.Controls.Add(this.txt_maGiamGia);
            this.groupBox3.Controls.Add(this.num_phanTramGiam);
            this.groupBox3.Controls.Add(this.gv_thongTinUuDai);
            this.groupBox3.Controls.Add(this.btn_luu);
            this.groupBox3.Controls.Add(this.btn_lamMoi);
            this.groupBox3.Controls.Add(this.btn_xoa);
            this.groupBox3.Controls.Add(this.btn_them);
            this.groupBox3.Controls.Add(this.txt_tenUuDai);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Location = new System.Drawing.Point(52, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1644, 393);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quản lý thông tin ưu đãi:";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dtp_ngayKetThuc
            // 
            this.dtp_ngayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngayKetThuc.Location = new System.Drawing.Point(210, 248);
            this.dtp_ngayKetThuc.Name = "dtp_ngayKetThuc";
            this.dtp_ngayKetThuc.Size = new System.Drawing.Size(350, 27);
            this.dtp_ngayKetThuc.TabIndex = 43;
            // 
            // dtp_ngayBatDau
            // 
            this.dtp_ngayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngayBatDau.Location = new System.Drawing.Point(210, 193);
            this.dtp_ngayBatDau.Name = "dtp_ngayBatDau";
            this.dtp_ngayBatDau.Size = new System.Drawing.Size(350, 27);
            this.dtp_ngayBatDau.TabIndex = 42;
            // 
            // txt_maGiamGia
            // 
            this.txt_maGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maGiamGia.Location = new System.Drawing.Point(210, 41);
            this.txt_maGiamGia.Name = "txt_maGiamGia";
            this.txt_maGiamGia.Size = new System.Drawing.Size(588, 27);
            this.txt_maGiamGia.TabIndex = 41;
            // 
            // num_phanTramGiam
            // 
            this.num_phanTramGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_phanTramGiam.Location = new System.Drawing.Point(210, 144);
            this.num_phanTramGiam.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_phanTramGiam.Name = "num_phanTramGiam";
            this.num_phanTramGiam.Size = new System.Drawing.Size(119, 27);
            this.num_phanTramGiam.TabIndex = 40;
            this.num_phanTramGiam.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gv_thongTinUuDai
            // 
            this.gv_thongTinUuDai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_thongTinUuDai.Location = new System.Drawing.Point(861, 41);
            this.gv_thongTinUuDai.Name = "gv_thongTinUuDai";
            this.gv_thongTinUuDai.RowHeadersWidth = 62;
            this.gv_thongTinUuDai.RowTemplate.Height = 24;
            this.gv_thongTinUuDai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_thongTinUuDai.Size = new System.Drawing.Size(761, 319);
            this.gv_thongTinUuDai.TabIndex = 39;
            this.gv_thongTinUuDai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_thongTinUuDai_CellContentClick);
            this.gv_thongTinUuDai.SelectionChanged += new System.EventHandler(this.gv_thongTinUuDai_SelectionChanged);
            // 
            // btn_luu
            // 
            this.btn_luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_luu.Image")));
            this.btn_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_luu.Location = new System.Drawing.Point(299, 310);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_luu.Size = new System.Drawing.Size(163, 50);
            this.btn_luu.TabIndex = 38;
            this.btn_luu.Text = "    Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_lamMoi.Image")));
            this.btn_lamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lamMoi.Location = new System.Drawing.Point(635, 310);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_lamMoi.Size = new System.Drawing.Size(163, 50);
            this.btn_lamMoi.TabIndex = 37;
            this.btn_lamMoi.Text = "      Làm mới";
            this.btn_lamMoi.UseVisualStyleBackColor = true;
            this.btn_lamMoi.Click += new System.EventHandler(this.btn_lamMoi_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(467, 310);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_xoa.Size = new System.Drawing.Size(163, 50);
            this.btn_xoa.TabIndex = 36;
            this.btn_xoa.Text = "   Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(131, 310);
            this.btn_them.Name = "btn_them";
            this.btn_them.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_them.Size = new System.Drawing.Size(163, 50);
            this.btn_them.TabIndex = 35;
            this.btn_them.Text = "    Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_tenUuDai
            // 
            this.txt_tenUuDai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenUuDai.Location = new System.Drawing.Point(210, 92);
            this.txt_tenUuDai.Name = "txt_tenUuDai";
            this.txt_tenUuDai.Size = new System.Drawing.Size(588, 27);
            this.txt_tenUuDai.TabIndex = 28;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(33, 253);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(116, 20);
            this.label20.TabIndex = 5;
            this.label20.Text = "Ngày kết thúc:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(33, 198);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(112, 20);
            this.label21.TabIndex = 4;
            this.label21.Text = "Ngày bắt đầu:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(33, 146);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(132, 20);
            this.label25.TabIndex = 2;
            this.label25.Text = "Phần trăm giảm:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(33, 95);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(92, 20);
            this.label26.TabIndex = 1;
            this.label26.Text = "Tên ưu đãi:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(33, 44);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(105, 20);
            this.label27.TabIndex = 0;
            this.label27.Text = "Mã giảm giá:";
            // 
            // Frm_QLPhieuGiamGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1721, 882);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_QLPhieuGiamGia";
            this.Text = "Frm_QLPhieuGiamGia";
            this.Load += new System.EventHandler(this.Frm_QLPhieuGiamGia_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_phanTramGiam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_thongTinUuDai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gv_thongTinUuDai;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_lamMoi;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_tenUuDai;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txt_maGiamGia;
        private System.Windows.Forms.NumericUpDown num_phanTramGiam;
        private System.Windows.Forms.DateTimePicker dtp_ngayKetThuc;
        private System.Windows.Forms.DateTimePicker dtp_ngayBatDau;
    }
}