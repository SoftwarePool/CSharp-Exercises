using System;

namespace Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
             int atisSayisi = 0;
            int turaYuzdesi = 0;

            Console.WriteLine("Atış Sayısı Giriniz:");
            atisSayisi = Convert.ToInt32(Console.ReadLine());

            while(atisSayisi % 2 != 0)
            {
                Console.WriteLine("Atış Sayısı Giriniz:");
                atisSayisi = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Tura Hile Yüzdesi Giriniz:");
            turaYuzdesi = Convert.ToInt32(Console.ReadLine());

            para p = new para();
            islemSonuc s = p.firlat(atisSayisi, turaYuzdesi);

            Console.WriteLine("Toplam Atış Sayısı: " + s.kacdefa +"(%"+ (float)s.kacdefa / (float)s.kacdefa * 100 +")");
            Console.WriteLine("Toplam Tura Sayısı: "+ s.turaSayisi + "(%" + (float)s.turaSayisi / (float)s.kacdefa * 100 + ")");
            Console.WriteLine("Toplam Yazı Sayısı: " + s.yaziSayisi + "(%" + (float)s.yaziSayisi / (float)s.kacdefa * 100 + ")");

            foreach (string x in s.gelenYuzler)
                Console.WriteLine(x);

            Console.ReadKey();
        
    }
    }
}
