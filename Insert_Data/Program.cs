using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Insert_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().InsertData();
        }

        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source =LAPTOP-8JHE7APE\\ALAM;database=Toko_Bakery_Alam;UserID-sa;password=123456");
                con.Open();

                SqlCommand cm = new SqlCommand("insert into Kasir(Id_Kasir, Nama_Kasir, Jenis_Kelamin) values('K01', 'Nourin', 'L')"
                    + "insert into Kasir(Id_Kasir, Nama_Kasir, Jenis_Kelamin) values ('K02', 'Alam', 'L')"
                    + "insert into Kasir(Id_Kasir, Nama_Kasir, Jenis_Kelamin) values ('K03', 'Adzani', 'L')"
                    + "insert into Kasir(Id_Kasir, Nama_Kasir, Jenis_Kelamin) values ('K04', 'Putri', 'P')"
                    + "insert into Kasir(Id_Kasir, Nama_Kasir, Jenis_Kelamin) values ('K05', 'Sindi', 'P')"

                    + "insert into Customer(Id_Customer, Nama_Customer, Jenis_Kelamin, No_Telp) values('C01', 'Arip', 'L', '0897636478362')"
                    + "insert into Customer(Id_Customer, Nama_Customer, Jenis_Kelamin, No_Telp) values('C02', 'Sinta', 'P', '0897634678007')"
                    + "insert into Customer(Id_Customer, Nama_Customer, Jenis_Kelamin, No_Telp) values('C03', 'Jamal', 'L', '0892336478645')"
                    + "insert into Customer(Id_Customer, Nama_Customer, Jenis_Kelamin, No_Telp) values('C04', 'Dobleh', 'L', '0898936478300')"
                    + "insert into Customer(Id_Customer, Nama_Customer, Jenis_Kelamin, No_Telp) values('C05', 'Intan', 'P', '0896736478895')"

                    + "insert into Produk(Id_Produk, Nama_Produk, Stok) values('P01', 'Pukis', '18')"
                    + "insert into Produk(Id_Produk, Nama_Produk, Stok) values('P02', 'Donat', '23')"
                    + "insert into Produk(Id_Produk, Nama_Produk, Stok) values('P03', 'Pie', '10')"
                    + "insert into Produk(Id_Produk, Nama_Produk, Stok) values('P04', 'Nagasari', '7')"
                    + "insert into Produk(Id_Produk, Nama_Produk, Stok) values('P05', 'Lapis', '3')",

                    con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses menambahkan data");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal menambahkan data. " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
    }
}