using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud-->Create-Read-Update-Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("-------------------------------");

            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=BKARACA\\SQLEXPRESS;Initial Catalog=EgitimKampiDb ;integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Kategori başarıyla eklendi. ");
            #endregion

            #region  Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            ////bool productSatus;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=BKARACA\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (productName,productPrice,productStatus) values (@productName,@productPrice,@productStatus)",connection);
            //command.Parameters.AddWithValue("@productName",productName);
            //command.Parameters.AddWithValue("@productPrice",productPrice);
            //command.Parameters.AddWithValue("@productStatus", true); //productStatusu dışarıdan almayacağım o yüzden direkt olarak true diyebiliyorum
            //command.ExecuteNonQuery(); //değişiklikleri kaydet ve bunu veri tabanına yansıt
            //connection.Close();
            //Console.WriteLine("Ürün eklemesi başarılı!");

            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection= new SqlConnection("Data Source=BKARACA\\SQLEXPRESS; Initial Catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();
            //SqlCommand cmd = new SqlCommand("Select * From TblProduct",connection);//connection ekleyerek bağlantımla ilişkilendiriyorum 
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd); //Sql deen verileri  çekerken bir köprügörevi gören komuttur.
            //DataTable dataTable = new DataTable();//Verileri geçici belleğe almak için datatable isimli bir sınıf var bu sınıftan nesne örneği oluşturuyorum
            //adapter.Fill(dataTable);
            //foreach (DataRow row in dataTable.Rows) // bu kod datatable da satırın tamamına giriyor 
            //{
            //    foreach (var item in row.ItemArray)// ilgili  satırların sütunları içerisine giriyorum.
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün Id: ");
            //int productId=int.Parse(Console.ReadLine());

            //SqlConnection conn = new SqlConnection("Data Source=BKARACA\\SQLEXPRESS; Initial Catalog=EgitimKampiDb; integrated security=true");
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("Delete From TblProduct Where ProductId=@productId",conn);
            //cmd.Parameters.AddWithValue("@productId",productId);
            //cmd.ExecuteNonQuery();

            //conn.Close();

            //Console.WriteLine("Silme işlemi yapıldı");

            #endregion

            #region Ürün Güncelleme İşlemi

            Console.Write("Güncellenecek Ürün Id: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Güncellenecek Ürün Adı: ");
            string productName = Console.ReadLine();

            Console.Write("Güncellenecek Ürün Fiyatı: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection conn = new SqlConnection("Data Source=BKARACA\\SQLEXPRESS; Initial Catalog=EgitimKampiDb; integrated security=true");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update TblProduct Set ProductName=@productName, ProductPrice=@productPrice Where ProductId=@productId ", conn);
            cmd.Parameters.AddWithValue("@productName", productName);
            cmd.Parameters.AddWithValue("@productPrice", productPrice);
            cmd.Parameters.AddWithValue("@productId", productId);
            cmd.ExecuteNonQuery();

            conn.Close();

            Console.WriteLine("Güncelleme başarılı!");

            #endregion

            Console.Read();
        }
    }
}
