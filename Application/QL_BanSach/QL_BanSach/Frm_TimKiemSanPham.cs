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
    public partial class Frm_TimKiemSanPham : Form
    {
        BLL_TimKiemSanPham bllTKSP = new BLL_TimKiemSanPham();
        public Frm_TimKiemSanPham()
        {
            InitializeComponent();
            loadCombobox();
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            refreshFieldInput();
            txt_maSach.Enabled = true;
            rdo_maSach.Checked = true;
        }

        private void rdo_maSach_CheckedChanged(object sender, EventArgs e)
        {
            refreshFieldInput();
            txt_maSach.Enabled = true;
        }

        private void refreshFieldInput()
        {
            txt_maSach.Text = "";
            txt_tenSach.Text = "";
            txt_tacGia.Text = "";
            cbo_nxb.Text = "--- Chọn ---";
            cbo_nxb.SelectedIndex = -1;
            cbo_theLoai.SelectedIndex = -1;
            cbo_theLoai.Text = "--- Chọn ---";

            txt_maSach.Enabled = txt_tacGia.Enabled = txt_tenSach.Enabled = cbo_nxb.Enabled = cbo_theLoai.Enabled = false;
            gv_dsTimKiem.DataSource = null;
            pn_1.BackColor = pn_2.BackColor = pn_3.BackColor = pn_4.BackColor = Color.WhiteSmoke;
            pn_a.BackColor = pn_b.BackColor = pn_c.BackColor = pn_d.BackColor = pn_e.BackColor = Color.WhiteSmoke;
        }

        private void rdo_tenSach_CheckedChanged(object sender, EventArgs e)
        {
            refreshFieldInput();
            txt_tenSach.Enabled = true;
        }

        private void rdo_tacGia_CheckedChanged(object sender, EventArgs e)
        {
            refreshFieldInput();
            txt_tacGia.Enabled = true;
        }

        private void rdo_nxb_CheckedChanged(object sender, EventArgs e)
        {
            refreshFieldInput();
            cbo_nxb.Enabled = true;
        }

        private void rdo_theLoai_CheckedChanged(object sender, EventArgs e)
        {
            refreshFieldInput();
            cbo_theLoai.Enabled = true;
        }

        private void loadCombobox()
        {
            List<DTO_NhaXuatBan> _lstNXB = bllTKSP.GetAllNXBs();
            foreach (DTO_NhaXuatBan nxb in _lstNXB)
            {
                cbo_nxb.Items.Add(nxb.TenNXB);
            }

            List<DTO_TheLoaiSach> _lstTL = bllTKSP.GetAllTheLoaiSachs();
            foreach (DTO_TheLoaiSach tl in _lstTL)
            {
                cbo_theLoai.Items.Add(tl.TenTheLoai);
            }
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            if(rdo_maSach.Checked)
            {
                if (txt_maSach.Text.Trim() == string.Empty)
                    MessageBox.Show("Vui lòng điền thông tin Mã sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    DTO_Sach _sach = bllTKSP.getSachfromMaSach(txt_maSach.Text.Trim());
                    if (_sach == null)
                        MessageBox.Show("Không tìm thấy thông tin của Sách từ Mã sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        txt_tangDatSach.Text = bllTKSP.getTangfromMaTang(_sach.MaTang).TenTang;
                        txt_keDatSach.Text = bllTKSP.getKetDatfromMaKe(_sach.MaKe).TenKe;

                        setColorForTang(_sach.MaTang.Trim());
                        setColorForKeDat(_sach.MaKe.Trim());

                        gv_dsTimKiem.DataSource = null;
                        gv_dsTimKiem.DataSource = new List<DTO_Sach> { _sach };
                    }
                }
            }

            if (rdo_tenSach.Checked)
            {
                if (txt_tenSach.Text.Trim() == string.Empty)
                    MessageBox.Show("Vui lòng điền thông tin Tên sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    DTO_Sach _sach = bllTKSP.getSachfromTenSach(txt_tenSach.Text.Trim());
                    if (_sach == null)
                        MessageBox.Show("Không tìm thấy thông tin của Sách từ Tên sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        txt_tangDatSach.Text = bllTKSP.getTangfromMaTang(_sach.MaTang).TenTang;
                        txt_keDatSach.Text = bllTKSP.getKetDatfromMaKe(_sach.MaKe).TenKe;

                        setColorForTang(_sach.MaTang.Trim());
                        setColorForKeDat(_sach.MaKe.Trim());

                        gv_dsTimKiem.DataSource = null;
                        gv_dsTimKiem.DataSource = new List<DTO_Sach> { _sach };
                    }
                }
            }

            if (rdo_tacGia.Checked)
            {
                if (txt_tacGia.Text.Trim() == string.Empty)
                    MessageBox.Show("Vui lòng điền thông tin Tên tác giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    List<DTO_Sach> _ds = bllTKSP.getListSachfromTacGia(txt_tacGia.Text.Trim());
                    if (_ds == null)
                        MessageBox.Show("Không tìm thấy thông tin của Sách từ Tác giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        gv_dsTimKiem.DataSource = null;
                        gv_dsTimKiem.DataSource = _ds;
                    }
                }
            }

            if (rdo_nxb.Checked)
            {
                if (cbo_nxb.SelectedIndex < 0 )
                    MessageBox.Show("Vui lòng chọn thông tin Nhà xuất bản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    List<DTO_Sach> _ds = bllTKSP.getListSachfromMaNXB(bllTKSP.getNXBfromTenNXB(cbo_nxb.SelectedItem.ToString().Trim()).MaNXB);
                    if (_ds == null)
                        MessageBox.Show("Không tìm thấy thông tin của Sách từ Nhà xuất bản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        gv_dsTimKiem.DataSource = null;
                        gv_dsTimKiem.DataSource = _ds;
                    }
                }
            }

            if (rdo_theLoai.Checked)
            {
                if (cbo_theLoai.SelectedIndex < 0)
                    MessageBox.Show("Vui lòng chọn thông tin Thể loại sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    List<DTO_Sach> _ds = bllTKSP.getListSachfromMaTheLoai(bllTKSP.getTheLoaifromTenTheLoai(cbo_theLoai.SelectedItem.ToString().Trim()).MaTheLoai);
                    if (_ds == null)
                        MessageBox.Show("Không tìm thấy thông tin của Sách từ Thể loại sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        gv_dsTimKiem.DataSource = null;
                        gv_dsTimKiem.DataSource = _ds;
                    }
                }
            }
        }

        private void setColorForTang(string maTang)
        {
            pn_1.BackColor = pn_2.BackColor = pn_3.BackColor = pn_4.BackColor = Color.WhiteSmoke;
            if (maTang == "T01")
                pn_1.BackColor = Color.Green;
            if (maTang == "T02")
                pn_2.BackColor = Color.Green;
            if (maTang == "T03")
                pn_3.BackColor = Color.Green;
            if (maTang == "T04")
                pn_4.BackColor = Color.Green;
        }

        private void setColorForKeDat(string maKD)
        {
            pn_a.BackColor = pn_b.BackColor = pn_c.BackColor = pn_d.BackColor = pn_e.BackColor = Color.WhiteSmoke;
            if (maKD == "K01")
                pn_a.BackColor = Color.Blue;
            if (maKD == "K02")
                pn_b.BackColor = Color.Blue;
            if (maKD == "K03")
                pn_c.BackColor = Color.Blue;
            if (maKD == "K04")
                pn_d.BackColor = Color.Blue;
            if (maKD == "K05")
                pn_e.BackColor = Color.Blue;
        }

        private void gv_dsTimKiem_SelectionChanged(object sender, EventArgs e)
        {
            if(gv_dsTimKiem.SelectedRows.Count > 0)
            {
                DataGridViewRow gv = gv_dsTimKiem.SelectedRows[0];

                txt_tangDatSach.Text = bllTKSP.getTangfromMaTang(gv.Cells[8].Value.ToString().Trim()).TenTang;
                txt_keDatSach.Text = bllTKSP.getKetDatfromMaKe(gv.Cells[9].Value.ToString().Trim()).TenKe;

                setColorForTang(gv.Cells[8].Value.ToString().Trim());
                setColorForKeDat(gv.Cells[9].Value.ToString().Trim());
            }
        }

        private void cbo_nxb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
