using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTDL.DAL;
using TTDL.DTO;

namespace TTDL.BLL
{
    public class DanhMucBLL
    {
        DanhMucDAL dalDanhMuc = new DanhMucDAL();
        public List<DanhMuc> GetAll()
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

        public bool Insert(DanhMuc dm)
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

        public bool Update(DanhMuc dm)
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

        public bool Delete(DanhMuc dm)
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

        public List<DanhMuc> TimKiem()
        {
            try
            {
                return dalDanhMuc.TimKiem();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
