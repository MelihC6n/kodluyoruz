using System;

namespace Instance__Field__Property__Class_
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
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Calışanın adı = {0}",Ad);
            Console.WriteLine("Calışanın Soyadı = {0}",Soyad);
            Console.WriteLine("Calışanın No = {0}",No);
            Console.WriteLine("Calışanın Departman = {0}",Departman);
        }
    }
}
