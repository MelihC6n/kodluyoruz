using System;

namespace Encapsulation_ve_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci()
            {
                Ad="Murat",
                Soyad="Çelik",
                OgrenciNo=6516,
                Sinif=5 
            };
            ogrenci.OgrenciBilgiBastir();
            
            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgiBastir();

            Ogrenci ogrenci2=new Ogrenci("Esma","Demir",352565,1);
            ogrenci2.OgrenciBilgiBastir();
            ogrenci2.SinifDusur();
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgiBastir();
        }
    }

    class Ogrenci
    {
        private string ad;
        private string soyad;
        private int ogrenciNo;
        private int sinif;

        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif 
        { 
            get => sinif; 
            set
            {
                if(value<1)
                {
                    Console.WriteLine("Sınıf 1'den küçük olamaz!");
                    value=1;
                }
                else if(value>8)
                {
                    Console.WriteLine("Sınıf 8'den büyük olamaz!");
                    value=8;
                }
                sinif=value;
            } 
        }

        public Ogrenci(string ad, string soyad, int ogrenciNo, int sinif)
        {
            Ad = ad;
            Soyad = soyad;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci(){}

        public void OgrenciBilgiBastir()
        {
            Console.WriteLine("****** Öğrenci Bilgileri ******");
            Console.WriteLine("Öğrencinin Adı = {0}",this.Ad);
            Console.WriteLine("Öğrencinin Soyadı = {0}",this.Soyad);
            Console.WriteLine("Öğrencinin No = {0}",this.OgrenciNo);
            Console.WriteLine("Öğrencinin Sınıfı = {0}",this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif += 1;
        }

        public void SinifDusur()
        {
            this.Sinif -= 1;
        }
    }
}
