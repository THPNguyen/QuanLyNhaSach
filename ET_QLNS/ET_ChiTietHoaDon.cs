using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ET_QLNS
{
    public class ET_ChiTietHoaDon
    {
        String MaSach;
        String MaHD;
        int SoLuong;

        public ET_ChiTietHoaDon()
        {
        }

        public ET_ChiTietHoaDon(string maSach, string maHD, int soLuong)
        {
            MaSach = maSach;
            MaHD = maHD;
            SoLuong = soLuong;
        }

        public string MaSach1 { get => MaSach; set => MaSach = value; }
        public string MaHD1 { get => MaHD; set => MaHD = value; }
        public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
        public ArrayList getAllProperties()
        {
            ArrayList list = new ArrayList() { MaSach1, MaHD1, SoLuong1};
            return list;
        }
    }
}
