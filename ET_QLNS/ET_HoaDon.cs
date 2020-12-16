using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ET_QLNS
{
    public class ET_HoaDon
    {
        String MaHD;
        String MaNV;
        String MaKH;
        String LoaiHoaDon;
        float TongTien;
        String NgayXuatHD;

        public ET_HoaDon()
        {
        }

        public ET_HoaDon(string maHD, string maNV, string maKH, string loaiHoaDon, float tongTien, string ngayXuatHD)
        {
            MaHD = maHD;
            MaNV = maNV;
            MaKH = maKH;
            LoaiHoaDon = loaiHoaDon;
            TongTien = tongTien;
            NgayXuatHD = ngayXuatHD;
        }

        public string _MaHD { get => MaHD; set => MaHD = value; }
        public string _MaNV { get => MaNV; set => MaNV = value; }
        public string _MaKH { get => MaKH; set => MaKH = value; }
        public string _LoaiHoaDon { get => LoaiHoaDon; set => LoaiHoaDon = value; }
        public float _TongTien { get => TongTien; set => TongTien = value; }
        public string _NgayXuatHD { get => NgayXuatHD; set => NgayXuatHD = value; }

        public ArrayList getAllProperties()
        {
            ArrayList list = new ArrayList() { _MaHD, _MaNV, _MaKH, _LoaiHoaDon, _TongTien, _NgayXuatHD};
            return list;
        }
    }
}
