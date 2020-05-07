using System;

namespace Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[2];
            Console.Write("1. Sayı : ");
            dizi[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayı : ");
            dizi[1] = Convert.ToInt32(Console.ReadLine());
            Array.Sort(dizi);
            Console.WriteLine("--------------");
            Console.WriteLine("Ortak Bölenler");
            Console.WriteLine("--------------");
            for (int i = 1; i <= dizi[0]; i++)
            {
                if (dizi[0] % i == 0 && dizi[1] % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();

        }
    }

    }

