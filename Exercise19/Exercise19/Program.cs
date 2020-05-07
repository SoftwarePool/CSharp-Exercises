using System;
using System.Linq;

namespace Exercise19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[20];
            Random rastgele = new Random();
            int i = 0;
            while (i < 20)
            {
                int sayi = rastgele.Next(10, 100);
                if (sayilar.Contains(sayi))
                    continue;
                sayilar[i] = sayi;
                i++;
            }
            Array.Sort(sayilar);
            foreach (int sayi in sayilar)
                Console.WriteLine(sayi);
            Console.ReadKey();
        }
    }

    }


