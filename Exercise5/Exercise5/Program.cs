using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İki Tam Sayı Giriniz:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = a / b;
            if (a>b && c%2==0)
            {
                Console.WriteLine(a+" "+"sayısı"+" "+b+" "+"'nın katıdır.");
            }
            else if(a<b)
            {
                Console.WriteLine(a + " " + "sayısı" + " " + b + " " + "'nın katı değildir.");
            }
        }
    }
}
