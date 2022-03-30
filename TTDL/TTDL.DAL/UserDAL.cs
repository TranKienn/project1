using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTDL.DTO;

namespace TTDL.DAL
{
    public class UserDAL
    {
        DbLib db = null;
        //Phương thức load dữ liệu từ bảng ChucVu
        public List<User> GetAll()
        {
            List<User> list = new List<User>();
            DataTable table = new DataTable();
            db = new DbLib();
            try
            {
                table = db.FillDataTable("sp_SelectUser", CommandType.StoredProcedure);
                foreach (DataRow dr in table.Rows)
                {
                    User dl = new User();
                    dl.UserID = dr[0].ToString();
                    dl.UserName = dr[1].ToString();
                    dl.Password = dr[2].ToString();
                    dl.FullName = dr[3].ToString();
                    dl.Email = dr[4].ToString();
                    dl.Phone = dr[5].ToString();
                    dl.DateOfBirth = DateTime.Parse(dr[6].ToString());
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
        public bool Insert(User dl)
        {
            bool check;
            try
            {
                db = new DbLib();
                db.AddParameter("@UserID", dl.UserID);
                db.AddParameter("@UserName", dl.UserName);
                db.AddParameter("@Password", dl.Password);
                db.AddParameter("@FullName", dl.FullName);
                db.AddParameter("@Email", dl.Email);
                db.AddParameter("@Phone", dl.Phone);
                db.AddParameter("@DateOfBirth", dl.DateOfBirth);
                check = db.ExecuteNonQuery("sp_InsertUser", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return check;
        }

        //Phương thức cập nhật dữ liệu vào bảng ChucVu
        public bool Update(User dl)
        {
            bool check;
            try
            {
                db = new DbLib();
                db.AddParameter("@UserID", dl.UserID);
                db.AddParameter("@UserName", dl.UserName);
                db.AddParameter("@Password", dl.Password);
                db.AddParameter("@FullName", dl.FullName);
                db.AddParameter("@Email", dl.Email);
                db.AddParameter("@Phone", dl.Phone);
                db.AddParameter("@DateOfBirth", dl.DateOfBirth);
                check = db.ExecuteNonQuery("sp_UpdateUser", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return check;
        }

        //Phương thức thêm dữ liệu vào bảng ChucVu
        public bool Delete(User dl)
        {
            bool check;
            try
            {
                db = new DbLib();
                db.AddParameter("@UserID", dl.UserID);
                check = db.ExecuteNonQuery("sp_DeleteUser", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return check;
        }

        public bool DangNhap(string username, string password)
        {
            bool check = false;
            try
            {
                db = new DbLib();
                DataTable table = new DataTable();
                string[] arrPara = new string[2] {"@UserName", "@Password" };
                object[] arrValue = new object[2] {username, password };
                SqlDbType[] arrDbType = new SqlDbType[2] { SqlDbType.VarChar, SqlDbType.VarChar};
                table = db.FillDataTable("sp_DangNhap", CommandType.StoredProcedure,
                    arrPara, arrValue, arrDbType);
                if (table.Rows.Count > 0)
                    check = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return check;
        }
    }
}
