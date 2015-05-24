using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace MvcFirstApplication.DAL
{
    public class ProductService
    {
        private SqlConnection conn = new SqlConnection("Persist Security Info=False;Data Source=192.168.1.251;Initial Catalog=NORTHWND;User Id=sa;Password=`1qaz@WSX");

        public DataTable GetProducts()
        {

            conn.Open();
            DataTable dt = new DataTable();

            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Products", conn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }


            return dt;
        }

        public DataTable GetFirstProduct()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(new SqlCommand("SELECT TOP 1 * FROM Products", conn));

            da.Fill(dt);

            return dt;
        }


    }
}
