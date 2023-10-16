using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhaXuatBan
    {
        public DTO_NhaXuatBan() { }
        public DTO_NhaXuatBan(string maNXB, string tenNXB)
        {
            this.maNXB = maNXB;
            this.tenNXB = tenNXB;
        }
        private string maNXB;

        public string MaNXB
        {
            get { return maNXB; }
            set { maNXB = value; }
        }
        private string tenNXB;

        public string TenNXB
        {
            get { return tenNXB; }
            set { tenNXB = value; }
        }
    }
}
