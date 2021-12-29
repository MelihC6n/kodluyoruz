using System;

namespace Rekürsif_ve_Extension_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi=2;
            int us=5;
            Metot ornek=new();
            Console.WriteLine(ornek.UsAl(sayi, us));


            //Extension metotlar

            string cumle = "selam naber iyi senden";
            Console.WriteLine(cumle.IsThereSpace());
            if(cumle.IsThereSpace())
                Console.WriteLine(cumle.ClearThoseSpaces());

            Console.WriteLine(cumle.VeryBigLetters());

            int[] dizi={5,2,97,45,7,2,65,83,895};
            dizi.SortAndWrite();
        }
    }

    public class Metot
    {
        public int UsAl(int sayi, int us)   //rekürsif metot
        {
            if(us==1)
                return sayi;
            return UsAl(sayi,us-1)*sayi;
        }
    }

    public static class Extension
    {
        public static bool IsThereSpace(this string param)
        {
            return param.Contains(" ");
        }

        public static string ClearThoseSpaces(this string param)
        {
            string[] dizi=param.Split(" ");
            return string.Join("",dizi);
        }

        public static string VeryBigLetters(this string param)
        {
            return param.ToUpper();
        }

        public static void SortAndWrite(this int[] param)
        {
            Array.Sort(param);
            foreach (int item in param)
            {
                Console.WriteLine(item);
            }
        }
        
    }
}
