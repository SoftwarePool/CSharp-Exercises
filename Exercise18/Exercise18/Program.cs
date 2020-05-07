using System;

namespace Exercise18
{
    class Program
    {
        static void Main(string[] args)
        {
            double ucret = 0;
            Console.WriteLine("Aşağıda Ücretler Verilmiştir. Hangi Ücret Aralığında Çalışmaktasın?");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("a) 200 $ - 299 $");
            Console.WriteLine("b) 300 $ - 399 $");
            Console.WriteLine("c) 400 $ -499 $");
            Console.WriteLine("d) 500 $ - 599 $");
            Console.WriteLine("e) 600 $ - 699 $");
            Console.WriteLine("f) 700 $ - 799 $");
            Console.WriteLine("g) 800 $ - 899 $");
            Console.WriteLine("h) 900 $ - 999 $");
            Console.WriteLine("i) 1000 dolar ve üstü");
            string girilen = Console.ReadLine();
            if (girilen == "a")
            {
                ucret = 200+200 * (9 / 100);
                Console.WriteLine("Ücretiniz:" + " " + ucret);
            }
            else if (girilen == "b")
            {
                ucret = 300 +300* (9 / 100);
                Console.WriteLine("Ücretiniz:" + " " + ucret);
            }
            else if (girilen == "c")
            {
                ucret = 400+400 * (9 / 100);
                Console.WriteLine("Ücretiniz:" + " " + ucret);
            }
            else if (girilen == "d")
            {
                ucret = 500 +500 * (9 / 100);
                Console.WriteLine("Ücretiniz:" + " " + ucret);
            }
            else if (girilen == "e")
            {
                ucret = 600+600 * (9 / 100);
                Console.WriteLine("Ücretiniz:" + " " + ucret);
            }
            else if (girilen == "f")
            {
                ucret = 700+700 * (9 / 100);
                Console.WriteLine("Ücretiniz:" + " " + ucret);
            }
            else if (girilen == "g")
            {
                ucret = 800+800 * (9 / 100);
                Console.WriteLine("Ücretiniz:" + " " + ucret);
            }
            else if (girilen == "h")
            {
                ucret = 900+900 * (9 / 100);
                Console.WriteLine("Ücretiniz:" + " " + ucret);
            }
            else if (girilen == "i")
            {
                ucret =1000+ 1000* (0.9 / 100);
                Console.WriteLine("Ücretiniz:" + " " + ucret);
            }

        }
    }
}
