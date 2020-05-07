using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İki Sayı Giriniz:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Girdiğiniz Sayıların Toplamı:" + (a + b));
            Console.WriteLine("Girdiğiniz Sayıların Çarpımı:" + (a * b));
            Console.WriteLine("Girdiğiniz Sayıların Bölümü:" + (a / b));
            Console.WriteLine("Girdiğiniz Sayıların Farkı:" + (a - b));

        }
    }
}
