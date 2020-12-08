using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DAL_QLNS;
using ET_QLNS;

namespace BUS_QLNS
{
    public class BUS_NhaCungCap
    {
        DAL_NhaCungCap dal_NCC = new DAL_NhaCungCap();
        public DataTable getNCC()
        {
            return dal_NCC.getNCC();
        }
        public bool themNCC(ET_NhaCungCap et_NCC)
        {
            return dal_NCC.themNCC(et_NCC);
        }
        public bool suaNCC(ET_NhaCungCap et_NCC)
        {
            return dal_NCC.suaNCC(et_NCC);
        }
        public bool xoaGH(string strMaNCC)
        {
            return dal_NCC.xoaNCC(strMaNCC);
        }
    }
}
