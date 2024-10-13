using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinally
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Hata Yakalama Try - Catch

            ////try tek başına tanımlanamaz
            //try
            //{
            //    Console.WriteLine("Lütfen bir sayı giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Lütfen bir sayı giriniz");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());

            //    int sonuc = sayi / sayi2;

            //    Console.WriteLine("Bölüm = " + sonuc);
            //}
            //catch
            //{
            //    Console.WriteLine("Bir hata oluştu");
            //}
            //Console.WriteLine("Hata potansiyeli dışı bölge");
            #endregion

            #region Türe göre hata yakalama
            //try
            //{
            //    Console.WriteLine("Lütfen bir sayı giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Lütfen bir sayı giriniz");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());

            //    int sonuc = sayi / sayi2;

            //    Console.WriteLine("Bölüm = " + sonuc);
            //}
            //catch(FormatException ex)
            //{
            //    Console.WriteLine("Bir hata oluştu");
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.StackTrace);
            //}
            //Console.WriteLine("Hata potansiyeli dışı bölge");
            #endregion

            #region Mimari Oluşturma

            //try
            //{
            //    Console.WriteLine("Lütfen bir sayı giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Lütfen bir sayı giriniz");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());

            //    int sonuc = sayi / sayi2;
            //    string temp = null;
            //    Console.WriteLine(temp.ToUpper());

            //    Console.WriteLine("Bölüm = " + sonuc);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Format Hatası oluştu");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Sıfıra bölme işlemi tanımsızdır");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Bir hata oluştu");
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.StackTrace);
            //}
            //Console.WriteLine("Hata potansiyeli dışı bölge");

            #endregion

            #region Try Catch Finally

            //try
            //{
            //    Console.WriteLine("Lütfen bir sayı giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Lütfen bir sayı giriniz");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());

            //    int sonuc = sayi / sayi2;

            //    Console.WriteLine("Bölüm = " + sonuc);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Bir hata oluştu");
            //}
            //finally
            //{
            //    Console.WriteLine("Finally Çalıştı");
            //}
            //Console.WriteLine("Hata potansiyeli dışı bölge");

            #endregion

            #region using Kullanımı
            SqlConnection con;
            using (con = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True"))
            {
                con.Open();
                Console.WriteLine("Bağlantı Açıldı");
            }
            con = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
            con.Open();
            Console.WriteLine("Bağlantı Açıldı");

            #endregion
        }
    }
}
