using System;

namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            double ucret = 0;
            Console.WriteLine("Kapalı Otoparka Hoşgeldiniz!");
            Console.WriteLine("Otopark Fiyat Listemiz Şu Şekildedir:");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("MAX 3 SAATE KADAR -------------> 2 TL");
            Console.WriteLine("HER 3 SAATİ AŞIMDA ------------> +0.50 TL");
            Console.WriteLine("MAX 24 SAATLİK ZAMAN DİLİMİNDE ---> 10 TL");
            Console.WriteLine("Otoparkı Ne Kadar Kullanacaksınız?");
            int girilen = int.Parse(Console.ReadLine());
            if (girilen <= 3)
            {
                Console.WriteLine("Ücretiniz:" + " " + (ucret+2));
                Console.ReadKey();
                Console.WriteLine("Saat Aşıldı mı?");
                string cevap = Console.ReadLine();
                if (cevap == "Evet")
                {
                    Console.WriteLine("Kaç Saat Aşıldı?");
                    int saat = int.Parse(Console.ReadLine());
                    ucret = ucret + saat*0.50;
                    Console.WriteLine("Ödemeniz Gereken Güncel Ücret:" + " " + ucret);

                    
                }
                else
                {
                    Console.WriteLine("Ödemeniz Gereken Güncel Ücret:" + " " + ucret+2);
                    Console.WriteLine("Tekrar Görüşmek Üzere!");
                }
            }
            else if (girilen == 24)
            {
                Console.WriteLine("Ücretiniz:" + " " + (ucret + 10));
            }
        }
    }
}
