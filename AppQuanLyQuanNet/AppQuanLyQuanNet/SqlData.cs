using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AppQuanLyQuanNet
{
    public class SqlData
    {
        public string strConnect;
        private SqlConnection conn;

        public SqlConnection connect()
        {
            conn = new SqlConnection(strConnect);
            conn.Open();
            return conn;
        }

        public void Disconnect()
        {
            try
            {
                if (conn != null)
                    conn.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                conn = null;
            }
        }

        public SqlCommand Command(string comd, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand(comd, conn);
            return cmd;
        }
    }
}
