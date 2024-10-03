using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Degiskenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyati: " + applePrice + "TL");
            //Console.WriteLine("---- Portakal Birim Fiyati: " + orangePrice + "TL");
            //Console.WriteLine("---- Cilek Birim Fiyati: " + strawberryPrice + "TL");
            //Console.WriteLine("---- Patates Birim Fiyati: " + potatoPrice + "TL");
            //Console.WriteLine("---- Domates Birim Fiyati: " + tomatoPrice + "TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleKilogram, orangeKilogram, strawberryKilogram, potatoKilogram, tomatoKilogram;

            //appleKilogram = 1.245;
            //orangeKilogram = 2.650;
            //strawberryKilogram = 0.750;
            //potatoKilogram = 4.859;
            //tomatoKilogram = 3.745;

            //double appleTotalPrice = applePrice * appleKilogram;
            //double orangeTotalPrice = orangePrice * orangeKilogram;
            //double strawberryTotalPrice = strawberryPrice * strawberryKilogram;
            //double potatoTotalPrice = potatoPrice * potatoKilogram;
            //double tomatoTotalPrice = tomatoPrice * tomatoKilogram;
            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine("Alinan Urun |" + "Birim Fiyati |" + "Kilogram         |" + "Toplam Fiyat");
            //Console.WriteLine("Elma        |" + applePrice + "        |" + appleKilogram + "            |" + appleTotalPrice);
            //Console.WriteLine("Portakal    |" + orangePrice + "        |" + orangeKilogram + "             |" + orangeTotalPrice);
            //Console.WriteLine("Cilek       |" + strawberryPrice + "           |" + strawberryKilogram + "             |" + strawberryTotalPrice);
            //Console.WriteLine("Patates     |" + potatoPrice + "         |" + potatoKilogram + "            |" + potatoTotalPrice);
            //Console.WriteLine("Domates     |" + tomatoPrice + "         |" + tomatoKilogram + "            |" + tomatoTotalPrice);
            //Console.WriteLine();
            //Console.WriteLine("Alisveris Toplam Tutari ------------------> " + shoppingTotalPrice);

            #endregion

            #region Char Degiskenler

            //char symbol = 'a';
            //Console.WriteLine(symbol);


            #endregion

            #region Klavyeden Veri Girisleri String Degiskenler

            //Console.WriteLine("**** Sharp Hava Yollari ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;


            //Console.Write("Yolcu TC Kimlik Numarasi: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.Write("Yolcu Adi: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadi: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Ilce Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Sehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yasi: ");
            //passengerAge = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("------------------------");
            //Console.WriteLine("Yolcu TC Kimlik Numarası: " + passengerIdentityNumber + " - Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " " + passengerDistrict + " / " + passengerCity + " " + passengerAge);






            #endregion

            #region Klavyeden Tam Sayi Girisleri ve Donusumler 

            //ABC12D hepsi string olarak alınıyor

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lutfen Aldiginiz Ayakkabi Sayisini Giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine()); //donusmurmek icicn kullanılan bir metot (Parse)

            //Console.Write("Lutfen Aldiginiz Bilgisayar Sayisini Giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lutfen Aldiginiz Sandalye Sayisini Giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lutfen Aldiginiz Televizyon Sayisini Giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Odemeniz Gereken Tutar: " + totalPrice + " TL");


            #endregion

            #region Klavyeden Ondalikli Sayi İslemleri


            //double exam1, exam2, exam3, result;

            //Console.Write(" Lutfen 1. Sinav Notunu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write(" Lutfen 2. Sinav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write(" Lutfen 3. Sinav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());


            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sinav Oralamanaiz: " + result);





            #endregion

            #region Klavyeden Karakter Girisleri

            //char gender;

            //Console.Write(" Lutfen Cinsiyet Seciniz: ");

            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine(" Sectiginiz Cinsiyet: " + gender);


            #endregion

            Console.Read();
        }
    }
}
