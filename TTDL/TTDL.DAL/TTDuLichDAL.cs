using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTDL.DTO;

namespace TTDL.DAL
{
    public class TTDuLichDAL
    {
        DbLib db = null;
        //Phương thức load dữ liệu từ bảng ChucVu
        public List<TTDuLich> GetAll()
        {
            List<TTDuLich> list = new List<TTDuLich>();
            DataTable table = new DataTable();
            db = new DbLib();
            try
            {
                table = db.FillDataTable("sp_SelectTTDuLich", CommandType.StoredProcedure);
                foreach (DataRow dr in table.Rows)
                {
                    TTDuLich dl = new TTDuLich();
                    dl.MaTTDL = dr[0].ToString();
                    dl.MaDiemDL = dr[1].ToString();
                    dl.DiemXuatPhat = dr[2].ToString();
                    dl.NgayKhoiHanh = DateTime.Parse(dr[3].ToString());
                    dl.PhuongTien = dr[4].ToString();
                    dl.Gia = dr[5].ToString();
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
        public bool Insert(TTDuLich dl)
        {
            bool check;
            try
            {
                db = new DbLib();
                db.AddParameter("@MaTTDL", dl.MaTTDL);
                db.AddParameter("@MaDiemDL", dl.MaDiemDL);
                db.AddParameter("@DiemXuatPhat", dl.DiemXuatPhat);
                db.AddParameter("@NgayKhoiHanh", dl.NgayKhoiHanh);
                db.AddParameter("@PhuongTien", dl.PhuongTien);
                db.AddParameter("@Gia", dl.Gia);
                check = db.ExecuteNonQuery("sp_InsertTTDuLich", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return check;
        }

        //Phương thức cập nhật dữ liệu vào bảng ChucVu
        public bool Update(TTDuLich dl)
        {
            bool check;
            try
            {
                db = new DbLib();
                db.AddParameter("@MaTTDL", dl.MaTTDL);
                db.AddParameter("@MaDiemDL", dl.MaDiemDL);
                db.AddParameter("@DiemXuatPhat", dl.DiemXuatPhat);
                db.AddParameter("@NgayKhoiHanh", dl.NgayKhoiHanh);
                db.AddParameter("@PhuongTien", dl.PhuongTien);
                db.AddParameter("@Gia", dl.Gia);
                check = db.ExecuteNonQuery("sp_UpdateTTDuLich", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return check;
        }

        //Phương thức thêm dữ liệu vào bảng ChucVu
        public bool Delete(TTDuLich dl)
        {
            bool check;
            try
            {
                db = new DbLib();
                db.AddParameter("@MaTTDL", dl.MaTTDL);
                check = db.ExecuteNonQuery("sp_DeleteTTDuLich", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return check;
        }
    }
}
