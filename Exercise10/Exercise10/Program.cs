using System;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
           

            int main()
            { 
                int birler, onlar, binler, onbinler, sayi, yuzler;
                Console.WriteLine("5 basamakli bir sayi giriniz:");
                sayi = int.Parse(Console.ReadLine());
                birler = sayi % 10;
                onlar = (sayi / 10) % 10;
                yuzler = (sayi / 100) % 10;
                binler = (sayi / 1000) % 10;
                onbinler = (sayi / 10000) % 10;
               
                if ((birler == onbinler) && (onlar == binler) && (yuzler == yuzler))
                {
                       Console.WriteLine(sayi+"sayisi palindromdur");
                }
                    
                else
                {
                    Console.WriteLine(sayi+"sayisi palindrom değildir");
                    return main();
                }
                   
                
                return 0;
            }

        }
    }
}
