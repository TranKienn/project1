using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTDL.DTO;
using System.Data;

namespace TTDL.DAL
{
    public class DanhMucDAL
    {
        DbLib db = null;
        //Phương thức load dữ liệu từ bảng ChucVu
        public List<DanhMuc> GetAll()
        {
            List<DanhMuc> list = new List<DanhMuc>();
            DataTable table = new DataTable();
            db = new DbLib();
            try
            {
                table = db.FillDataTable("sp_SelectDanhMuc", CommandType.StoredProcedure);
                foreach (DataRow dr in table.Rows)
                {
                    DanhMuc dm = new DanhMuc();
                    dm.MaDanhMuc = dr[0].ToString();
                    dm.TenDanhMuc = dr[1].ToString();
                    list.Add(dm);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }

        //Phương thức thêm dữ liệu vào bảng ChucVu
        public bool Insert(DanhMuc dm)
        {
            bool check;
            try
            {
                db = new DbLib();
                db.AddParameter("@MaDanhMuc", dm.MaDanhMuc);
                db.AddParameter("@TenDanhMuc", dm.TenDanhMuc);
                check = db.ExecuteNonQuery("sp_InsertDanhMuc", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return check;
        }

        //Phương thức cập nhật dữ liệu vào bảng ChucVu
        public bool Update(DanhMuc dm)
        {
            bool check;
            try
            {
                db = new DbLib();
                db.AddParameter("@MaDanhMuc", dm.MaDanhMuc);
                db.AddParameter("@TenDanhMuc", dm.TenDanhMuc);
                check = db.ExecuteNonQuery("sp_UpdateDanhMuc", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return check;
        }

        //Phương thức thêm dữ liệu vào bảng ChucVu
        public bool Delete(DanhMuc dm)
        {
            bool check;
            try
            {
                db = new DbLib();
                db.AddParameter("@MaDanhMuc", dm.MaDanhMuc);
                check = db.ExecuteNonQuery("sp_DeleteDanhMuc", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return check;
        }

        public List<DanhMuc> TimKiem()
        {
            List<DanhMuc> list = new List<DanhMuc>();
            DataTable table = new DataTable();
            db = new DbLib();
            try
            {
                table = db.FillDataTable("sp_TimKiemDanhMuc", CommandType.StoredProcedure);
                foreach (DataRow dr in table.Rows)
                {
                    DanhMuc dm = new DanhMuc();
                    dm.MaDanhMuc = dr[0].ToString();
                    dm.TenDanhMuc = dr[1].ToString();
                    list.Add(dm);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }

    }
}
