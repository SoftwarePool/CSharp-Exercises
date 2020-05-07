using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saatlik Km bilginizi giriniz");
            int km = int.Parse(Console.ReadLine());
            Console.WriteLine("Saatte giden benzin bilginizi giriniz");
            int benzin = int.Parse(Console.ReadLine());
            Console.WriteLine("kaç saat yol gideceksiniz?");
            int yol = int.Parse(Console.ReadLine());
            int z = yol*benzin;
            Console.WriteLine("Ortalama Gidecek Benzininiz:" +z);
        }
    }
}
