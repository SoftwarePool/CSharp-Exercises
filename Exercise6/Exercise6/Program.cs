using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adınızı ve Soyadınızı Giriniz");
            String ad = Console.ReadLine();
            String soyad = Console.ReadLine();

            Console.WriteLine("Adınız ve Soyadınız:" + ad + " " + soyad);
        }
    }
}
