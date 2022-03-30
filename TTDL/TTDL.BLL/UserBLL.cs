using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTDL.DAL;
using TTDL.DTO;

namespace TTDL.BLL
{
    public class UserBLL
    {
        UserDAL dalDanhMuc = new UserDAL();
        public List<User> GetAll()
        {
            try
            {
                return dalDanhMuc.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Insert(User dm)
        {
            try
            {
                return dalDanhMuc.Insert(dm);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Update(User dm)
        {
            try
            {
                return dalDanhMuc.Update(dm);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Delete(User dm)
        {
            try
            {
                return dalDanhMuc.Delete(dm);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool DangNhap(string username, string password)
        {
            dalDanhMuc = new UserDAL();
            try
            {
                return dalDanhMuc.DangNhap(username, password);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
