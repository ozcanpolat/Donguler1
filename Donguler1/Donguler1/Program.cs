using System;

namespace Donguler1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan başlangıç, bitiş ve artış miktarı alınarak aralıktaki
            // tüm sayıları ekrana yazdırınız.

            Console.Write("Başlangıç değerini girin: ");
            int baslangic = int.Parse(Console.ReadLine());

            Console.Write("Bitiş değerini girin: ");
            int bitis = int.Parse(Console.ReadLine());

            Console.Write("Artış değerini girin: ");
            int artis = int.Parse(Console.ReadLine());

            for(int i=baslangic; i<=bitis; i=i+artis)
            {
                Console.WriteLine(i);
   
            }
        }
    }
}
