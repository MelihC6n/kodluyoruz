using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=5;
            int b=5;
            Console.WriteLine(Topla(a,b));
            Console.WriteLine(a+" "+b);
            metotlar ornek=new metotlar();
            Console.WriteLine(ornek.refliMetot(ref a, ref b));
            Console.WriteLine(a+" "+b);

        }
        static int Topla(int deger1, int deger2)
        {
            return deger1+deger2;
        }

    }

    class metotlar
    {
        public int refliMetot(ref int deger1,ref int deger2)
        {
            deger1+=5;
            deger2+=5;
            return deger1+deger2;
        }
    }
}
