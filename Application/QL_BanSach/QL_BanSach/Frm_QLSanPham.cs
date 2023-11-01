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
using System.IO;

namespace Frm_DangNhap
{
    public partial class Frm_QLSanPham : Form
    {
        BLL_Sach sachBLL = new BLL_Sach();
        BLL_Tang tangBLL = new BLL_Tang();
        BLL_NhaXuatBan nxbBLL = new BLL_NhaXuatBan();
        BLL_TheLoaiSach bllTheLoai = new BLL_TheLoaiSach();
        BLL_KeDat bllKeDat = new BLL_KeDat();
        public Frm_QLSanPham()
        {
            InitializeComponent();
            loadDGVSaches();
            loadAllCombobox();
        }

        private void btn_TTDS_lamMoi_Click(object sender, EventArgs e)
        {
            refreshAllData();
        }
        private void refreshAllData()
        {
            txt_TTDS_maSach.Text = "";
            txt_TTDS_tenSach.Text = "";
            txt_TTDS_tacGia.Text = "";
            txt_TTDS_soTrang.Text = "";
            txt_TTDS_giaBan.Text = "";

            ComboBox[] list = new ComboBox[] { cbo_TTDS_keDatSach, cbo_TTDS_nxb, cbo_TTDS_tangDatSach, cbo_TTDS_theLoai };
            foreach (ComboBox i in list)
            {
                i.SelectedIndex = -1;
                i.Text = "--- Chọn ---";
            }
            pic_sanPham.Image = Image.FromFile("../Debug/Products/loadingPic.png");
            lb_nameFileUpload.Text = "";
            loadDGVSaches();

        }
        private void loadAllCombobox()
        {
            List<DTO_NhaXuatBan> NXBs = nxbBLL.GetAllNXBs();
            foreach (DTO_NhaXuatBan i in NXBs)
                cbo_TTDS_nxb.Items.Add(i.TenNXB);

            List<DTO_Tang> Tangs = tangBLL.GetAllTangs();
            foreach (DTO_Tang i in Tangs)
                cbo_TTDS_tangDatSach.Items.Add(i.TenTang);

            List<DTO_TheLoaiSach> theLoai = bllTheLoai.GetAllTheLoaiSachs();
            foreach (DTO_TheLoaiSach i in theLoai)
                cbo_TTDS_theLoai.Items.Add(i.TenTheLoai);

            List<DTO_KeDat> keDat = bllKeDat.GetAllKeDats();
            foreach (DTO_KeDat i in keDat)
                cbo_TTDS_keDatSach.Items.Add(i.TenKe);
        }
        private void loadDGVSaches()
        {
            gv_dsDauSach.DataSource = null;
            List<DTO_Sach> saches = sachBLL.GetAllSaches();
            gv_dsDauSach.DataSource = saches;
        }

        private void gv_dsDauSach_SelectionChanged(object sender, EventArgs e)
        {
            if(gv_dsDauSach.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gv_dsDauSach.SelectedRows[0];
                txt_TTDS_maSach.Text = selectedRow.Cells[0].Value.ToString().Trim();
                txt_TTDS_tenSach.Text = selectedRow.Cells[1].Value.ToString().Trim();
                txt_TTDS_tacGia.Text = selectedRow.Cells[2].Value.ToString().Trim();
                txt_TTDS_soTrang.Text = selectedRow.Cells[3].Value.ToString().Trim();
                txt_TTDS_giaBan.Text = selectedRow.Cells[4].Value.ToString().Trim();
                cbo_TTDS_nxb.Text = sachBLL.getNXBfromMaNXB(selectedRow.Cells[7].Value.ToString().Trim()).TenNXB;
                cbo_TTDS_theLoai.Text = sachBLL.getTheLoaifromMaTheLoai(selectedRow.Cells[6].Value.ToString().Trim()).TenTheLoai;
                cbo_TTDS_tangDatSach.Text = sachBLL.getTangfromMaTang(selectedRow.Cells[8].Value.ToString().Trim()).TenTang;
                cbo_TTDS_keDatSach.Text = sachBLL.getKeDatfromMaKe(selectedRow.Cells[9].Value.ToString().Trim()).TenKe;
                pic_sanPham.Image = Image.FromFile("../Debug/Products/" + selectedRow.Cells[10].Value.ToString().Trim());
            }
        }

        private void cbo_TTDS_nxb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_TTDS_them_Click(object sender, EventArgs e)
        {
            if(!checkIsFullInfo())
                MessageBox.Show("Vui lòng điền đầy đủ thông tin Sách thêm mới!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (sachBLL.checkPrimaryKey(txt_TTDS_maSach.Text.Trim()))
                    MessageBox.Show("Mã sách thêm mới đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (lb_nameFileUpload.Text.Trim() == string.Empty)
                        MessageBox.Show("Vui lòng chọn ảnh Sách thêm mới!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        string maSach = txt_TTDS_maSach.Text.Trim();
                        string tenSach = txt_TTDS_tenSach.Text.Trim();
                        string tacGia = txt_TTDS_tacGia.Text.Trim();
                        int soTrang =Int32.Parse( txt_TTDS_soTrang.Text.Trim());
                        int giaBan = Int32.Parse(txt_TTDS_giaBan.Text.Trim());
                        string maTang = sachBLL.getTangfromTenTang(cbo_TTDS_tangDatSach.SelectedItem.ToString().Trim()).MaTang.Trim();
                        string maKe = sachBLL.getKetDatfromTenKe(cbo_TTDS_keDatSach.SelectedItem.ToString().Trim()).MaKe.Trim();
                        string maNXB = sachBLL.getNXBfromTenNXB(cbo_TTDS_nxb.SelectedItem.ToString().Trim()).MaNXB.Trim();
                        string maTheLoai = sachBLL.getTheLoaifromTenTheLoai(cbo_TTDS_theLoai.SelectedItem.ToString().Trim()).MaTheLoai.Trim();
                        string anh = lb_nameFileUpload.Text.Trim();
                        int slTon = 0; //default

                        DialogResult dialog = MessageBox.Show("Xác nhận thêm thông tin Sách mới?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                        if (dialog == DialogResult.Yes)
                        {
                            DTO_Sach sach = new DTO_Sach(maSach, tenSach, tacGia, soTrang, giaBan, slTon, maTheLoai, maNXB, maTang, maKe, anh);
                            if(sachBLL.insertSach(sach))
                            {
                                MessageBox.Show("Thêm thông tin sách mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                refreshAllData();
                            }
                            else
                                MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại sau!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private bool checkIsFullInfo()
        {
            ComboBox[] list = new ComboBox[] { cbo_TTDS_keDatSach, cbo_TTDS_nxb, cbo_TTDS_tangDatSach, cbo_TTDS_theLoai };
            foreach (ComboBox i in list)
            {
                if (i.SelectedIndex == -1)
                    return false;
            }

            TextBox[] listTB = new TextBox[] { txt_TTDS_giaBan, txt_TTDS_maSach,txt_TTDS_soTrang,txt_TTDS_tacGia,txt_TTDS_tenSach };
            foreach (TextBox i in listTB)
            {
                if (i.Text == string.Empty)
                    return false;
            }

            return true;
        }

        private void txt_TTDS_soTrang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_TTDS_giaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btn_TTDS_choAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Title = "Open Image file";
            fileOpen.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";

            if (fileOpen.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = fileOpen.FileName;
                string destinationDirectory = "Products";

                if (!Directory.Exists(destinationDirectory))
                {
                    Directory.CreateDirectory(destinationDirectory);
                }

                string fileName = Path.GetFileName(selectedFilePath);
                string targetFilePath = Path.Combine(destinationDirectory, fileName);

                int fileNumber = 1;
                while (File.Exists(targetFilePath))
                {
                    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
                    string fileExtension = Path.GetExtension(fileName);
                    fileName = fileNameWithoutExtension+"_"+fileNumber+fileExtension;
                    targetFilePath = Path.Combine(destinationDirectory, fileName);
                    fileNumber++;
                }

                File.Copy(selectedFilePath, targetFilePath, true);

                lb_nameFileUpload.Text = fileName;
                pic_sanPham.Image = Image.FromFile(targetFilePath);

            }
            fileOpen.Dispose();
        }

        private void btn_TTDS_luu_Click(object sender, EventArgs e)
        {
            if (gv_dsDauSach.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gv_dsDauSach.SelectedRows[0];
                string maSach = selectedRow.Cells[0].Value.ToString().Trim();

                if (!checkIsFullInfo())
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin Sách để cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    string tenSach = txt_TTDS_tenSach.Text.Trim();
                    string tacGia = txt_TTDS_tacGia.Text.Trim();
                    int soTrang = Int32.Parse(txt_TTDS_soTrang.Text.Trim());
                    int giaBan = Int32.Parse(txt_TTDS_giaBan.Text.Trim());
                    string maTang = sachBLL.getTangfromTenTang(cbo_TTDS_tangDatSach.SelectedItem.ToString().Trim()).MaTang.Trim();
                    string maKe = sachBLL.getKetDatfromTenKe(cbo_TTDS_keDatSach.SelectedItem.ToString().Trim()).MaKe.Trim();
                    string maNXB = sachBLL.getNXBfromTenNXB(cbo_TTDS_nxb.SelectedItem.ToString().Trim()).MaNXB.Trim();
                    string maTheLoai = sachBLL.getTheLoaifromTenTheLoai(cbo_TTDS_theLoai.SelectedItem.ToString().Trim()).MaTheLoai.Trim();
                    string anh = lb_nameFileUpload.Text.Trim() == string.Empty ? selectedRow.Cells[10].Value.ToString().Trim() : lb_nameFileUpload.Text.Trim();
                    int slTon = Int32.Parse(selectedRow.Cells[5].Value.ToString().Trim()); //default

                    DialogResult dialog = MessageBox.Show("Xác nhận cập nhật thông tin Sách?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (dialog == DialogResult.Yes)
                    {
                        DTO_Sach sach = new DTO_Sach(maSach, tenSach, tacGia, soTrang, giaBan, slTon, maTheLoai, maNXB, maTang, maKe, anh);
                        if (sachBLL.updateSach(sach))
                        {
                            MessageBox.Show("Cập nhật thông tin sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refreshAllData();
                        }
                        else
                            MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại sau!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Sách để thao tác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_TTDS_xoa_Click(object sender, EventArgs e)
        {
            if (gv_dsDauSach.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gv_dsDauSach.SelectedRows[0];
                string maSach = selectedRow.Cells[0].Value.ToString().Trim();

                if(sachBLL.checkForeignKey(maSach))
                    MessageBox.Show("Sách muốn xóa đang được sử dụng ở nơi khác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    DialogResult dialog = MessageBox.Show("Xác nhận xóa thông tin Sách?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (dialog == DialogResult.Yes)
                    {
                        if (sachBLL.deleteSach(maSach))
                        {
                            MessageBox.Show("Xóa thông tin sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refreshAllData();
                        }
                        else
                            MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại sau!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Sách để thao tác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
