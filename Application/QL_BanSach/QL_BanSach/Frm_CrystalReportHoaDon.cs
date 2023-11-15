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

namespace Frm_DangNhap
{
    public partial class Frm_CrystalReportHoaDon : Form
    {
        private int soHDRP;
        BLL_XuatHoaDon bllXHD = new BLL_XuatHoaDon();
        public Frm_CrystalReportHoaDon(int soHDRP)
        {
            InitializeComponent();
            this.soHDRP = soHDRP;
        }

        public Frm_CrystalReportHoaDon()
        {
            InitializeComponent();
        }

        private void Frm_CrystalReportHoaDon_Load(object sender, EventArgs e)
        {
            this.crystalReportViewer.RefreshReport();
            
            bllXHD.deleteTableXuatHoaDon();
            bllXHD.insertTableXuatHoaDon(soHDRP);

            CrystalReportHoaDon report = new CrystalReportHoaDon();
            crystalReportViewer.ReportSource = report;
            report.SetDatabaseLogon(@"CHAUCUTEVL\CHAUDZHOST", "QLCuaHangSach");
            crystalReportViewer.DisplayStatusBar = false;
            crystalReportViewer.DisplayToolbar = true;
            crystalReportViewer.Refresh();

        }
    }
}
