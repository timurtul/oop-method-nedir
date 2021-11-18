using System;

namespace methodornekler
{
    class Program
    {

        static void Main(string[] args)
        {
          

            Console.WriteLine("1. Sayıyı Giriniz");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2. Sayıyı Giriniz");
            
            int sayi2 = int.Parse(Console.ReadLine());

            methodlar sanalisim = new methodlar();
            Console.WriteLine(sanalisim.Toplama(sayi1, sayi2));


            Console.ReadKey();
        }

        
    }
}
