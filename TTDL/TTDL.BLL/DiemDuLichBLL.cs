using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTDL.DAL;
using TTDL.DTO;

namespace TTDL.BLL
{
    public class DiemDuLichBLL
    {
        DiemDuLichDAL dalDanhMuc = new DiemDuLichDAL();
        public List<DiemDuLich> GetAll()
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

        public bool Insert(DiemDuLich dm)
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

        public bool Update(DiemDuLich dm)
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

        public bool Delete(DiemDuLich dm)
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
    }
}
