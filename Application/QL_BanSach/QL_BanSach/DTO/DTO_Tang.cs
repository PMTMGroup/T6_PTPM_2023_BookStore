using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Tang
    {
        public DTO_Tang() { }
        public DTO_Tang(string maTang, string tenTang)
        {
            this.maTang = maTang;
            this.tenTang = tenTang;
        }
        public string maTang;

        public string MaTang
        {
            get { return maTang; }
            set { maTang = value; }
        }
        public string tenTang;

        public string TenTang
        {
            get { return tenTang; }
            set { tenTang = value; }
        }
    }
}
