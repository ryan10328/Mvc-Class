using MvcFirstApplication.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            ProductService p = new ProductService();

            var dt = p.GetProducts();

            foreach (DataRow item in dt.Rows)
            {
                Console.WriteLine(string.Format("Product ID:{0}, ProductName:{1}",
                    item["ProductID"].ToString(), item["ProductName"].ToString()));
            }
            Console.Read();

        }

    }
}
