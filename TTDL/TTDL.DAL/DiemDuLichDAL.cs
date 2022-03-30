using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTDL.DTO;

namespace TTDL.DAL
{
    public class DiemDuLichDAL
    {
        DbLib db = null;
        //Phương thức load dữ liệu từ bảng ChucVu
        public List<DiemDuLich> GetAll()
        {
            List<DiemDuLich> list = new List<DiemDuLich>();
            DataTable table = new DataTable();
            db = new DbLib();
            try
            {
                table = db.FillDataTable("sp_SelectDiemDuLich", CommandType.StoredProcedure);
                foreach (DataRow dr in table.Rows)
                {
                    DiemDuLich dl = new DiemDuLich();
                    dl.MaDiemDL = dr[0].ToString();
                    dl.TenDiemDL = dr[1].ToString();
                    dl.MaDanhMuc = dr[2].ToString();
                    list.Add(dl);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }

        //Phương thức thêm dữ liệu vào bảng ChucVu
        public bool Insert(DiemDuLich dl)
        {
            bool check;
            try
            {
                db = new DbLib();
                db.AddParameter("@MaDiemDL", dl.MaDiemDL);
                db.AddParameter("@TenDiemDL", dl.TenDiemDL);
                db.AddParameter("@MaDanhMuc", dl.MaDanhMuc);
                check = db.ExecuteNonQuery("sp_InsertDiemDuLich", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return check;
        }

        //Phương thức cập nhật dữ liệu vào bảng ChucVu
        public bool Update(DiemDuLich dl)
        {
            bool check;
            try
            {
                db = new DbLib();
                db.AddParameter("@MaDiemDL", dl.MaDiemDL);
                db.AddParameter("@TenDiemDL", dl.TenDiemDL);
                db.AddParameter("@MaDanhMuc", dl.MaDanhMuc);
                check = db.ExecuteNonQuery("sp_UpdateDiemDuLich", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return check;
        }

        //Phương thức thêm dữ liệu vào bảng ChucVu
        public bool Delete(DiemDuLich dl)
        {
            bool check;
            try
            {
                db = new DbLib();
                db.AddParameter("@MaDiemDL", dl.MaDiemDL);
                check = db.ExecuteNonQuery("sp_DeleteDiemDuLich", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return check;
        }
    }
}
