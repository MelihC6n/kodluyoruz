using System;

namespace slm
{
    class Program
    {
        static void Main(string[] args)
        {
            // try
            // {
            //     Console.WriteLine("bir sayı giriniz:");
            //     int number= int.Parse(Console.ReadLine());
            //     Console.WriteLine(number);
            // }
            // catch (Exception ex)//exception ile hata yakalanıp ex değişkenine atılıyor ve cathde ekrana bastırılıyor.
            // {
            //     Console.WriteLine("Hata: "+ ex.Message.ToString());
            // }
            // finally  //finally her koşulda çalışan bi yerdir.
            // {
            //     Console.WriteLine("deneme");
            // }

            try
            {
                 //int sela=int.Parse(null);
                 //int sela=int.Parse("test");
                 int sela=int.Parse("-999999999999999999");   
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Hata: Boş değer girdiniz");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {  
                Console.WriteLine("Hata: Veri tipi uygun değil");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: Çok küçük veya çok büyük bir sayı girildi");
                Console.WriteLine(ex);
            }


        }
    }
}
