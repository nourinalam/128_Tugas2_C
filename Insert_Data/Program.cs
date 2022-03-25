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

                    //insert data pada tabel customer
                    + "insert into Customer(Id_Customer, Nama_Customer, Jenis_Kelamin, No_Telp) values('C01', 'Arip', 'L', '0897636478362')"
                    + "insert into Customer(Id_Customer, Nama_Customer, Jenis_Kelamin, No_Telp) values('C02', 'Sinta', 'P', '0897634678007')"
                    + "insert into Customer(Id_Customer, Nama_Customer, Jenis_Kelamin, No_Telp) values('C03', 'Jamal', 'L', '0892336478645')"
                    + "insert into Customer(Id_Customer, Nama_Customer, Jenis_Kelamin, No_Telp) values('C04', 'Dobleh', 'L', '0898936478300')"
                    + "insert into Customer(Id_Customer, Nama_Customer, Jenis_Kelamin, No_Telp) values('C05', 'Intan', 'P', '0896736478895')"


                    //insert data pada tabel produk
                    + "insert into Produk(Id_Produk, Nama_Produk, Stok) values('P01', 'Pukis', '18')"
                    + "insert into Produk(Id_Produk, Nama_Produk, Stok) values('P02', 'Donat', '23')"
                    + "insert into Produk(Id_Produk, Nama_Produk, Stok) values('P03', 'Pie', '10')"
                    + "insert into Produk(Id_Produk, Nama_Produk, Stok) values('P04', 'Nagasari', '7')"
                    + "insert into Produk(Id_Produk, Nama_Produk, Stok) values('P05', 'Lapis', '3')"

                    //insert data pada tabel transaksi
                    + "insert into Transaksi(Id_Transaksi, Tanggal_Transaksi, Jumlah_Kue, Total_Pembayaran, Jenis_Pembayaran, Id_Kasir, Id_Customer, Id_Produk) values('TRX01', '12-02-2025', '5','5000','Tunai','K01','C01','P01')"
                    + "insert into Transaksi(Id_Transaksi, Tanggal_Transaksi, Jumlah_Kue, Total_Pembayaran, Jenis_Pembayaran, Id_Kasir, Id_Customer, Id_Produk) values('TRX02', '23-01-2024', '10','20000','Debit','K02','C02','P02')"
                    + "insert into Transaksi(Id_Transaksi, Tanggal_Transaksi, Jumlah_Kue, Total_Pembayaran, Jenis_Pembayaran, Id_Kasir, Id_Customer, Id_Produk) values('TRX03', '03-09-2020', '7','28000','Debit','K03','C03','P03')"
                    + "insert into Transaksi(Id_Transaksi, Tanggal_Transaksi, Jumlah_Kue, Total_Pembayaran, Jenis_Pembayaran, Id_Kasir, Id_Customer, Id_Produk) values('TRX04', '11-12-2024', '2','6000','Tunai','K04','C04','P04')"
                    + "insert into Transaksi(Id_Transaksi, Tanggal_Transaksi, Jumlah_Kue, Total_Pembayaran, Jenis_Pembayaran, Id_Kasir, Id_Customer, Id_Produk) values('TRX05', '28-04-2023', '1','2000','Tunai','K05','C05','P05')",

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