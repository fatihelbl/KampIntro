using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            String kurs1 = "Yazilim Gelistirici Yetiştirme Kampı";
            String kurs2 = "Programlamaya başlangıç için temel kurs";
            String kurs3 = "Java";

            string[] kurslar = new string[] { "Yazilim Gelistirici Yetiştirme Kampı",
                                              "Programlamaya başlangıç için temel kurs",
                                              "Java" ,
                                              "python" ,
                                              "C#" };
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }
            Console.WriteLine("sayfa sonu-for bitti");

            foreach (string kurs in kurslar) // BU şekilde daha hızlı ve kısa şekilde dizileri döndürebikiriz.
            {
                Console.WriteLine(kurs);

            }
            Console.WriteLine("foreach bitti");
        }
    }
}
