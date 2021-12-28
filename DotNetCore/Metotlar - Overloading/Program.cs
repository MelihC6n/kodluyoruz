using System;

namespace metot_oveloading
{
    class Program
    {
        static void Main(string[] args)
        {
                string sayi="999";
                
                bool cevir= int.TryParse(sayi, out int outInt); //tryparse girilen değişkenin inte çevrilip çevirelemeyeceğini konrol edip
                if(cevir)                                       //boolean geri dönüş verir ve çevriliyorsa out da int şeklinde değişkene
                {                                               //çevirip atar
                    Console.WriteLine("Başarılı : "+ outInt);
                }
                else
                {
                    Console.WriteLine("Başarısız");
                }

                Metot metot = new Metot();
                metot.Carp(5, 6, out int sonuc); //metodu çağırırkende parametresini geri gelecek şekilde out ile ayarla
                Console.WriteLine(sonuc);

                string bas="selam";
                metot.EkranaYazdir(bas);
                metot.EkranaYazdir(182);   //metot overloading
                                           //metot imzasına göre çalışır
                                        //metot adı + parametre sayısı + parametre
                metot.EkranaYazdir(200, 300);
        }
    }

    class Metot
    {
        public void Carp(int a, int b, out int outInt) //return vermeden bi değişkeni geri döndürebiliriz
        {
            outInt=a*b;
        }

        public void EkranaYazdir(string yazdir)
        {
            Console.WriteLine(yazdir);
        }
        public void EkranaYazdir(int yazdir)
        {
            Console.WriteLine(yazdir);
        }
        public void EkranaYazdir(int yazdir, int yazdir2)
        {
            Console.WriteLine(yazdir+yazdir2);
        }
    }
}
