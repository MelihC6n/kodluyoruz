using System;

namespace Kurucu_Fonksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan = new Calisan()
            {
                Ad="Ayşe",
                Soyad="Kuş",
                No=541651,
                Departman="Öyle Böyle"
            };

            calisan.CalisanBilgileri();

            Calisan calisan2 = new Calisan("Ali","Kuşkonmaz",68462,"I.T.");
            calisan2.CalisanBilgileri();

            Calisan calisan3 = new Calisan("Emre","Gül");
            calisan3.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad=ad;
            this.Soyad=soyad;
            this.No=no;
            this.Departman=departman;        
        }

        public Calisan(string ad,string soyad)
        {
            this.Ad=ad;
            this.Soyad=soyad;
        }

        public Calisan(){}

        public void CalisanBilgileri()
        {
            Console.WriteLine("Calışanın adı = {0}",Ad);
            Console.WriteLine("Calışanın Soyadı = {0}",Soyad);
            Console.WriteLine("Calışanın No = {0}",No);
            Console.WriteLine("Calışanın Departman = {0}",Departman);
        }
    }
}
