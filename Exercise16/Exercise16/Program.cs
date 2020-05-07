using System;

namespace Exercise16
{
    class Program
    {
        static void Main(string[] args)
        {
            double k1, k2, hipotenus;
            Console.Write("Birinci Dik Kenarı Girin:");
            k1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci Dik Kenarı Girin:");
            k2 = Convert.ToDouble(Console.ReadLine());
            hipotenus = Math.Sqrt((k1 * k1) + (k2 * k2));
            Console.WriteLine("Hipotenüs değeri:{0}", hipotenus);
            Console.ReadKey();
        }
    }
}
