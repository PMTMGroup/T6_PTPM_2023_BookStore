﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_Sach
    {
        private DAL_Sach sachDAL = new DAL_Sach();

        public List<DTO_Sach> GetAllSaches()
        {
            return sachDAL.GetAllSaches();
        }
    }
}
