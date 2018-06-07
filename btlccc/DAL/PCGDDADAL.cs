using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
   public class PCGDDADAL:KetNoi
    {
       
            public DataTable LoadData(string sql)
            {
                Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                DataTable dt = new DataTable();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            public DataTable HienThiDS()
            {
                string sql = "select MaLop,MaMon,CanBoGiaoVien.HoTen,PhanCongGiangDay.NgayPhanCong from PhanCongGiangDay inner join CanBoGiaoVien on PhanCongGiangDay.MaCanBoGiaoVien=CanBoGiaoVien.MaCanBoGiaoVien";
            return LoadData(sql);
            }
        public DataTable getMamon()
        {
            string sql = "select MaMon,TenMon from MonHoc";
            return LoadData(sql);
        }
        public DataTable getMalop()
        {
            string sql = "select MaLop,TenLop from Lop";
            return LoadData(sql);
        }
        public DataTable getGiaovien()
        {
            string sql = "select MaCanBoGiaoVien,HoTen from CanBoGiaoVien";
            return LoadData(sql);
        }
        public int Them(PhanCongGiangDay x)
        {
            Open();
            string sql = "insert into PhanCongGiangDay values(@malop,@mamon,@magv,@ngay) ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("malop", x.MaLop);
            cmd.Parameters.AddWithValue("mamon", x.MaMon);
            cmd.Parameters.AddWithValue("magv", x.MaCanBoGV);
            cmd.Parameters.AddWithValue("ngay", x.NgayPhanCong);

            return cmd.ExecuteNonQuery();

        }
        public DataTable HienThiDataLop(string sql)
        {
            Open();
            string select = "Select Lop.TenLop,MonHoc.TenMon,CanBoGiaoVien.HoTen,PhanCongGiangDay.NgayPhanCong from PhanCongGiangDay inner join Lop on Lop.MaLop=PhanCongGiangDay.MaLop inner join MonHoc on PhanCongGiangDay.MaMon=MonHoc.MaMon inner join CanBoGiaoVien on PhanCongGiangDay.MaCanBoGiaoVien=CanBoGiaoVien.MaCanBoGiaoVien where Lop.TenLop=@tenlop";
            SqlCommand cmd = new SqlCommand(select, conn);
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("tenlop", sql);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            cmd.Connection.Close();
            return dt;

        }
        public DataTable HienThiDataMon(string sql)
        {
            Open();
            string select = "Select Lop.TenLop,MonHoc.TenMon,CanBoGiaoVien.HoTen,PhanCongGiangDay.NgayPhanCong from PhanCongGiangDay inner join Lop on Lop.MaLop=PhanCongGiangDay.MaLop inner join MonHoc on PhanCongGiangDay.MaMon=MonHoc.MaMon inner join CanBoGiaoVien on PhanCongGiangDay.MaCanBoGiaoVien=CanBoGiaoVien.MaCanBoGiaoVien where MonHoc.TenMon=@tenmon";
            SqlCommand cmd = new SqlCommand(select, conn);
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("tenmon", sql);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            cmd.Connection.Close();
            return dt;

        }
        public DataTable HienThiDataGiaoVien(string sql)
        {
            Open();
            string select = "Select Lop.TenLop,MonHoc.TenMon,CanBoGiaoVien.HoTen,PhanCongGiangDay.NgayPhanCong from PhanCongGiangDay inner join Lop on Lop.MaLop=PhanCongGiangDay.MaLop inner join MonHoc on PhanCongGiangDay.MaMon=MonHoc.MaMon inner join CanBoGiaoVien on PhanCongGiangDay.MaCanBoGiaoVien=CanBoGiaoVien.MaCanBoGiaoVien where CanBoGiaoVien.HoTen=@tencanbo";
            SqlCommand cmd = new SqlCommand(select, conn);
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("tencanbo", sql);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            cmd.Connection.Close();
            return dt;

        }
    }
    }

