using System;

namespace Static_Sınıf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan sayısı = {0}",Calisan.CalisanSayisi);

            Calisan calisan=new Calisan("Mert","Dumanlı","Arge");

            Console.WriteLine("Çalışan sayısı = {0}",Calisan.CalisanSayisi);

            Calisan calisan1=new Calisan("Ali","Veli","İK");
            Calisan calisan2=new Calisan("Ayşe","Fatma","İK");

            Console.WriteLine("Çalışan sayısı = {0}",Calisan.CalisanSayisi);

            Console.WriteLine(Islemler.Topla(Calisan.CalisanSayisi,30));
            Console.WriteLine(Islemler.Cikar(Calisan.CalisanSayisi,1));

        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }

        private string Ad;
        private string Soyad;
        private string Departman;

        static Calisan()
        {
            calisanSayisi=0;
        }
        public Calisan(string ad, string soyad, string departman)
        {
            Ad = ad;
            Soyad = soyad;
            Departman = departman;
            calisanSayisi++;
        }
    }
    static class Islemler
    {
        public static int Topla(int a, int b)
        {
            return a+b;
        }

        public static int Cikar(int a, int b)
        {
            return a-b;
        }
    }
}
