using System;
using System.Collections;
using System.Collections.Generic;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //array list kolleksiyon tipindedir her tip veri alır
            ArrayList liste = new ArrayList();
            // liste.Add("Leyla");
            // liste.Add(2);
            // liste.Add(true);
            // liste.Add('A');

            // Console.WriteLine(liste[1]);
            // foreach (var item in liste)
            // {
            //         Console.WriteLine(item);
            // }

            // //range ekleme

            // string[] renkler={"kırmızı","sarı","yeşil"};
            // liste.AddRange(renkler);

            List<int> sayilar = new List<int>(){1,3,6,8,9,8,5,8,7,56};
            liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("*****************");
            liste.Sort();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(liste.BinarySearch(5));


        }
    }
}
