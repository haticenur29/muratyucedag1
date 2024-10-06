using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Write ifadesi imleci en sağa atarken WriteLine ifadesi imleci aşağıya atar
            Console.Write("Hi!");

            #region YazdırmaKomutları

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Yemek Kategorileri");
            Console.WriteLine();
            Console.WriteLine("1-Çorbalar");
            Console.WriteLine("2-Ana Yemekler");
            Console.WriteLine("3-Soğuk Servisler");
            Console.WriteLine("4-Salatalar");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("6-İçecekler");
            Console.WriteLine();
            Console.WriteLine("Yemek Kategorileri");

            #endregion


            #region String Değişkenler

            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, district, city;

            customerName = "Hatice Nur";
            customerSurname = "İbiş";
            customerPhone = "+90 505 083 27 23";
            customerEmail = "hnrbs.03@gmail.com";
            district = "Tavas";
            city = "Denizli";

            Console.WriteLine();
           
            Console.WriteLine("REZERVASYON KARTI");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("Email: " + customerEmail);
            Console.WriteLine("Phone: " + customerPhone);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("----------------------------------------");

            Console.WriteLine();

            customerName = "Sevil";
            customerSurname = "İbiş";
            customerPhone = "+09 505 758 45 75";
            customerEmail = "test@gmail.com";
            district = "Nazilli";
            city = "Aydın";

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("Email: " + customerEmail);
            Console.WriteLine("Phone: " + customerPhone);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("----------------------------------------");

            #endregion


            #region Int Değişkenler

            int hamburgerPrice = 250;
            int cokePrice = 30;
            int waterPrice = 10;
            int friesPrice = 100;
            int lemonadePrice = 40;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Restoran Menü Fiyatı");
            Console.WriteLine("--------------------------");
            Console.WriteLine();
            Console.WriteLine("---Hamburger: " + hamburgerPrice + " TL---");
            Console.WriteLine("---Kola: " + cokePrice + " TL---");
            Console.WriteLine("---Su: " + waterPrice + " TL---");
            Console.WriteLine("---Kızartma: " + friesPrice + " TL---");
            Console.WriteLine("---Limonata: " + lemonadePrice + " TL---");
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Restoran Menü Fiyatı");
            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalLemonadePrice = 0;


            hamburgerCount = 3;
            cokeCount = 2;
            waterCount = 3;
            friesCount = 1;
            lemonadeCount = 1;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");

            Console.WriteLine();

            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalLemonadePrice; ;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice); 
            



            #endregion

            Console.Read();  //Hello World yazısını enter'a basana kadar ekranda tutabilmek için
            //başka bir tuşa basarsan yazı yazmaya devam eder, sadece enter'a basınca kapatır!
        }
    }
}
