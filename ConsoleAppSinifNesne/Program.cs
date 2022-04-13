using System;

namespace ConsoleAppSinifNesne
{
    
    
   class Program
    {
        static void Main(string[] args)
        {

            // Arac tipinden otomobil nesnesini oluşturuyoruz
            arac otomobil = new arac();

            // nesnemize özellik değerlerini giriyoruz
            otomobil.hiz = 180;
            otomobil.yakit = "LPG";
            otomobil.renk = "Beyaz";
            otomobil.marka = "Şahin";


            // Bilgileri ekrana yazdıracak metodu çağırıyoruz
            otomobil.aracInfo();

        }
    }
     
         public class arac
    {

        public String yakit;// Aracın yakıtı
        public int hiz; // Aracın  hızı 
        public String renk; // Aracın rengi
        public String marka; // Aracın markası


        // Aracın bilgilerini ekrana yazdıran metot
        public void aracInfo()
        {
            String tasit = "TAŞITIN MARKASI: " + marka + " RENGİ: " + renk + " YAKIT TİPİ: " + yakit + " HIZI: " + hiz;

            System.Console.WriteLine(tasit);
        }

    }
    
          
    



}
