using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bordro Hesaplamanız İçin İki Sayı Girin");
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int a = b * c;

            Console.WriteLine("Bordro Hesaplamanızın Sonucu:" + a + " " + "TL" + "'" +"dir");
        }
    }
}
