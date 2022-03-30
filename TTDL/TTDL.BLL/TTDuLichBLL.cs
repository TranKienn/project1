using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTDL.DAL;
using TTDL.DTO;

namespace TTDL.BLL
{
    public class TTDuLichBLL
    {
        TTDuLichDAL dalDanhMuc = new TTDuLichDAL();
        public List<TTDuLich> GetAll()
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

        public bool Insert(TTDuLich dm)
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

        public bool Update(TTDuLich dm)
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

        public bool Delete(TTDuLich dm)
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
