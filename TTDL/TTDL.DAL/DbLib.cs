using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TTDL.DAL
{
    public class DbLib
    {
        private SqlConnection cnn;
        private SqlCommand cmd;

        public DbLib()
        {
            string strcnn = "Server=DESKTOP-G1MGVGE;Database=QLTTDL;Integrated Security=True";
            cnn = new SqlConnection(strcnn);

            cmd = new SqlCommand();
            cmd.Connection = cnn;
        }

        public void Open()
        {
            if (cnn.State != System.Data.ConnectionState.Open)
            {
                cnn.Open();
            }
        }

        public void Close()
        {
            if(cnn.State != System.Data.ConnectionState.Closed)
            {
                cnn.Close();
            }
        }

        public bool ExecuteNonQuery(string cmdText, System.Data.CommandType cmdType)
        {
            int count = 0;
            try
            {
                this.Open();
                cmd.CommandText = cmdText;
                cmd.CommandType = cmdType;
                count = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e.Message);
            }
            return count > 0;
        }

        public void AddParameter(string name, object value)
        {
            SqlParameter para = new SqlParameter();
            para.ParameterName = name;
            para.Value = value;
            cmd.Parameters.Add(para);
        }

        public void AddParameter(string name, object value, ParameterDirection direction)
        {
            SqlParameter para = new SqlParameter();
            para.ParameterName = name;
            para.Value = value;
            para.Direction = direction;
            cmd.Parameters.Add(para);
        }

        //Phương thức điền dữ liệu vào DataTable
        public DataTable FillDataTable(string cmdText, CommandType cmdType)
        {
            DataTable table = null;
            try
            {
                this.Open();
                cmd.CommandText = cmdText;
                cmd.CommandType = cmdType;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                table = new DataTable();
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return table;
        }

        public DataTable FillDataTable(string cmdText, CommandType cmdType, string[] arrPara,
                            object[] arrValue, SqlDbType[] arrDbType)
        {
            DataTable table = null;
            try
            {
                this.Open();
                cmd.CommandText = cmdText;
                cmd.CommandType = cmdType;
                SqlParameter para = null;
                for (int i = 0; i < arrPara.Length; i++)
                {
                    para = new SqlParameter();
                    para.ParameterName = arrPara[i];
                    para.Value = arrValue[i];
                    para.SqlDbType = arrDbType[i];
                    cmd.Parameters.Add(para);
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                table = new DataTable();
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return table;
        }
    }
}
