using System;
namespace alistirma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayiyi giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sonuc = 1;
            for (int i=sayi; i>=1; i--)
            {
                sonuc *= i; 
            }
            Console.WriteLine("{0} sayisinin faktoriyelinin sonucu {1}",sayi,sonuc);
        }
    }
}