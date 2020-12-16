using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ET_QLNS
{
    public class ET_TheLoai
    {
        String MaTL;
        String TenTL;
        String MaNCC;

        public ET_TheLoai()
        {
        }

        public ET_TheLoai(string maTL, string tenTL, string maNCC)
        {
            MaTL = maTL;
            TenTL = tenTL;
            MaNCC = maNCC;
        }

        public string MaTL1 { get => MaTL; set => MaTL = value; }
        public string TenTL1 { get => TenTL; set => TenTL = value; }
        public string MaNCC1 { get => MaNCC; set => MaNCC = value; }

        public ArrayList getAllProperties()
        {
            ArrayList list = new ArrayList() { MaTL1, TenTL1, MaNCC1 };
            return list;
        }
    }
}
