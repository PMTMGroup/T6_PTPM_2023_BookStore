using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Quyen
    {
        public DTO_Quyen() { }
        public DTO_Quyen(string maQuyen, string tenQuyen)
        {
            this.maQuyen = maQuyen;
            this.tenQuyen = tenQuyen;
        }
        private string maQuyen;

        public string MaQuyen
        {
            get { return maQuyen; }
            set { maQuyen = value; }
        }
        private string tenQuyen;

        public string TenQuyen
        {
            get { return tenQuyen; }
            set { tenQuyen = value; }
        }

    }
}
