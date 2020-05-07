using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesap Numaranızı Giriniz:");
            int hesapNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ay Başındaki Bakiyenizi Giriniz:");
            int bakiye = int.Parse(Console.ReadLine());
            Console.WriteLine("Giderlerinizin Toplamını Giriniz:");
            int gider = int.Parse(Console.ReadLine());
            Console.WriteLine("İzin verilen kredi limitiniz:");
            int izinKredi = int.Parse(Console.ReadLine());
            Console.WriteLine("Bu Ay ki Tüm kredilerin toplamı:");
            int tkredi = int.Parse(Console.ReadLine());
            int guncelBakiye = bakiye + gider - tkredi;
            if (guncelBakiye < izinKredi)
            {
                Console.WriteLine("Kredi Limiti Aşıldı!");
            }
            else
            {
                Console.WriteLine("Limitinizi Aşmadınız,Tebrikler");
            }
        }
    }
}
