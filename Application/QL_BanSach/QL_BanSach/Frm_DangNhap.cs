using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace Frm_DangNhap
{
    public partial class Frm_DangNhap : Form
    {
        BLL_DangNhap bllDN = new BLL_DangNhap();
        public Frm_DangNhap()
        {
            InitializeComponent();
        }

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            if(txt_matKhau.Text.Trim() == string.Empty || txt_taiKhoan.Text.Trim() == string.Empty)
                MessageBox.Show("Vui lòng điền đầy đủ thông tin đăng nhập!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string strTaiKhoan = txt_taiKhoan.Text.Trim();
                string strMatKhau = txt_matKhau.Text.Trim();

                if(bllDN.getTaiKhoan(strTaiKhoan, strMatKhau) == null)
                    MessageBox.Show("Thông tin đăng nhập không chính xác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    DTO_TaiKhoan account = bllDN.getTaiKhoan(strTaiKhoan, strMatKhau);
                    if(account.BiKhoa == 1)
                        MessageBox.Show("Tài khoản đã bị khóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        this.Visible = false;
                        Frm_Main frmOBJ = new Frm_Main(account.MaTaiKhoan);
                        frmOBJ.Show();
                    }
                }
            }
        }
    }
}
