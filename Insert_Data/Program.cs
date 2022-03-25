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
                    + "insert into Kasir(Id_Kasir, Nama_Kasir, Jenis_Kelamin) values ('K05', 'Sindi', 'P')",

                    
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