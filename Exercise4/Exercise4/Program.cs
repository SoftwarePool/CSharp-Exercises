using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesaplamak İstediğiniz Dairenin Yarıçapını Giriniz:");
            int r = int.Parse(Console.ReadLine());

            int cap = r * 2;
            Console.WriteLine("Dairenizin Çapı:" + cap);

            double cevre = 2 * r * 3.14;
            Console.WriteLine("Daireinizin Çevresi:" + cevre);
        }
    }
}
