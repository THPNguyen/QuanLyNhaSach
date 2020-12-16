using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using DAL_QLNS;
using ET_QLNS;

namespace DAL_QLNS
{
    public class DAL_HoaDon : DBConnect
    {
        String[] strNameParametor = { "MaHD", "NgayXuatHoaDon", "TongTien", "LoaiHoaDon", "MaNV", "MaKH"};

        public DataTable getHoaDon()
        {
            DataTable dt = new DataTable();
            try
            {
                openDB();
                SqlCommand cmd = HandleCMD.proc("sp_TruyXuatNhaCungCap", _con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                return null;
            }
            finally
            {
                closeDB();
            }
        }
        //----------------------------------------------------------------
        //THEM, XOA, SUA
        public bool themHD(ET_HoaDon et_GH)
        {
            try
            {
                openDB();
                SqlCommand cmd = HandleCMD.proc("sp_LayThongTinBangHoaDon", _con);

                addParameter(cmd, et_GH, strNameParametor);

                if (this.cmdExecuted(cmd))
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                return false;
            }
            finally
            {
                closeDB();
            }
            return false;
        }
        public bool suaHD(ET_HoaDon eT_HoaDon)
        {
            try
            {
                openDB();
                SqlCommand cmd = HandleCMD.proc("sp_CapNhapHoaDon", _con);
                addParameter(cmd, eT_HoaDon, strNameParametor);

                if (this.cmdExecuted(cmd))
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                return false;
            }
            finally
            {
                closeDB();
            }
            return false;
        }
        public bool xoaHD(string maHD)
        {
            try
            {
                openDB();
                SqlCommand cmd = HandleCMD.proc("sp_XoaHoaDon", _con);
                SqlParameter pt = new SqlParameter("@MaHD", maHD);
                cmd.Parameters.Add(pt);
                if (this.cmdExecuted(cmd))
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                return false;
            }
            finally
            {
                closeDB();
            }
            return false;
        }
        //----------------------------------------------------------------
        //HAM PHU
        public void addParameter(SqlCommand cmd, ET_HoaDon hoaDon, String[] strNameParametor)
        { 

            ArrayList list = hoaDon.getAllProperties();

            foreach (string item in strNameParametor)
            {
                SqlParameter pt = new SqlParameter(item, list[Array.IndexOf(strNameParametor, item)]);
                cmd.Parameters.Add(pt);
            }
        }
    }
}
