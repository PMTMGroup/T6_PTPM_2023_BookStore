using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KeDat
    {
        public DTO_KeDat() { }
        public DTO_KeDat(string maKe, string tenKe)
        {
            this.maKe = maKe;
            this.tenKe = tenKe;
        }
        private string maKe;
        private string tenKe;
        public string MaKe
        {
            get { return maKe; }
            set { maKe = value; }
        }
        public string TenKe
        {
            get { return tenKe; }
            set { tenKe = value; }
        }
    }
}
