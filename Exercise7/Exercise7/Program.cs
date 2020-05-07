using System;
using System.Linq;

namespace Exercise7
{
    class Program
    {
        public static int kelimeara(String[] dizi, String kelime, int uzunluk) {
            if (uzunluk < 0) return 0;
            else if (dizi[uzunluk] == kelime) 
            return 1 + kelimeara(dizi, kelime, uzunluk - 1); 
            else return kelimeara(dizi, kelime, uzunluk - 1); 
        }
        
        static void Main(string[] args)
        {
            String[] dizi = { "On the first day of Christmas", "my true love sent to me:", "A Partridge in a Pear Tree", "On the second day of Christmas", "my true love sent to me:" }; 
            String kelime = "my true love sent to me:"; 
            int uzunluk = dizi.Length; 
            Console.WriteLine("Aradığınız Kelime Sayısı:"+kelimeara(dizi, kelime, uzunluk - 1));
          

        }
    }
}
