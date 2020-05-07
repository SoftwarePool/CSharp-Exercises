using System;

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            
          
           
           

            int sifre = 1234;
            Console.WriteLine("Hoşgeldiniz!");
            Console.WriteLine("Sisteme Erişebilmek İçin Lütfen 4 Haneli Şifrenizi Giriniz:");
            int girilen = int.Parse(Console.ReadLine());  
            int basamak1 = (girilen / 1000) % 10;
            int basamak2 = (girilen / 100) % 10;
            int basamak3 = (girilen / 10) % 10;
            int basamak4 = (girilen % 10);
            
            if (girilen == sifre)
            {
                
                Console.WriteLine("Sifre Doğru!");
                Console.WriteLine("Güvenliğiniz İçin Şifrenizin İki Ve Üçüncü Basamağını Yer Değiştirip Tekrar Deneyin.");
                int giris = int.Parse(Console.ReadLine());
                int sayi = 1324;
                if (giris == sayi)
                {
                    Console.WriteLine("İşlem Başarılı");
                }
                else
                {
                    Console.WriteLine("Hatalı Şifre. Sisteme Erişiminiz Engellendi.");
                }
            }
            else
            {
                Console.WriteLine("Hatalı Şifre. Sisteme Erişiminiz Engellendi.");
            }
        }
    }
}
