using DAL_QLNS;
using ET_QLNS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BUS_QLNS
{
    public class BUS_TheLoai
    {
        DAL_TheLoai dal_TheLoai = new DAL_TheLoai();
        public DataTable getTheLoai()
        {
            return dal_TheLoai.getTL();
        }
        public bool themTL(ET_TheLoai eT_TheLoai)
        {
            return dal_TheLoai.themTL(eT_TheLoai);
        }
        public bool suaTL(ET_TheLoai eT_TheLoai)
        {
            return dal_TheLoai.suaTL(eT_TheLoai);
        }
        public bool xoaTL(string strMaTL)
        {
            return dal_TheLoai.xoaTL(strMaTL);
        }
    }
}
