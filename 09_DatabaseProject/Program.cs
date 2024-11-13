using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** C# Veri Tabanli Urun - Kategori  Bilgi sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Urunler");
            Console.WriteLine("3-siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("lutfen getirmek istediğiniz tablo numarasını giriniz: ");

            string tableNumber = Console.ReadLine();
            Console.WriteLine("------------------------");

            SqlConnection connection = new SqlConnection("Data Source=BKARACA\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("select * from TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
