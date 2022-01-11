using System;
using System.Collections.Generic;

namespace Generic_Koleksiyonlar_ve_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T>
            //T object tipindedir
            //system.collections.generic

            List<int> sayilar=new List<int>();
            sayilar.Add(25);
            sayilar.Add(245);
            sayilar.Add(56);
            sayilar.Add(235);
            sayilar.Add(534);
            sayilar.Add(98);

            List<string> bruh=new List<string>();
            
            bruh.Add("askljdf");
            bruh.Add("dlk");
            bruh.Add("slm");
            bruh.Add("cnm");
            bruh.Add("nbr");

            Console.WriteLine(sayilar.Count);
            Console.WriteLine(bruh.Count);

            //foreach ve list.foreach kullanımı
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }

            foreach (var soz in bruh)
            {
                Console.WriteLine(soz);
            }

            sayilar.ForEach(sayi=> Console.WriteLine(sayi));
            bruh.ForEach(soz=> Console.WriteLine(soz));

            //Liste içerisinde arama
            if(sayilar.Contains(56))
                    Console.WriteLine("Sayilarda var");


            //Eleman ile index'e erişme
            Console.WriteLine(bruh.BinarySearch("slm"));

            //Diziyi List'e çevirme
            string[] hayvanlar = {"kaplumbağa","kedi","kuzu","panda"};
            List<string> hayvanListesi=new List<string>(hayvanlar);
            hayvanListesi.ForEach(hayvan=>Console.WriteLine(hayvan));
            hayvanListesi.ForEach(hayvan=>bruh.Add(hayvan));
            bruh.ForEach(b=>Console.WriteLine(b)); 

            //List içerisined nesne tutma
            List<Kullanıcılar> kullanıcıList = new List<Kullanıcılar>();
            Kullanıcılar kullanici1=new Kullanıcılar();
            kullanici1.Isim="Ahmet";
            kullanici1.Soyad="Su";
            kullanici1.Yas=99;

            Kullanıcılar kullanici2=new Kullanıcılar();
            kullanici2.Isim="Mehmet";
            kullanici2.Soyad="Ateş";
            kullanici2.Yas=98;

            kullanıcıList.Add(kullanici1);
            kullanıcıList.Add(kullanici2);
            kullanıcıList.Add(new Kullanıcılar()
            {
                Isim="Murat",
                Soyad="Yep",
                Yas=101
            });

            foreach (var kullanici in kullanıcıList)
            {
                Console.WriteLine("Kullanıcı adı = "+kullanici.Isim+" soyadı = "+kullanici.Soyad+" yası = "+kullanici.Yas);
            }
         
        }
        
    }

    public class Kullanıcılar
    {
        private string isim;
        private string soyad;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
