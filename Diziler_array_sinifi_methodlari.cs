using System;

namespace Diziler_arrat_sinifi_methodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int[] sayiDizisi = { 2, 15, 19, 23, 17, 95, 55, 78 };

            Console.WriteLine("--sırasız liste--");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            
            Console.WriteLine("--sıralı liste");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //Clear
            Console.WriteLine("--array clear--");
            //sayı dizisi elemanlarını kullanarak 2. indeksten itibaren 2 elemanı 0 olarak değiştirdik
            Array.Clear(sayiDizisi, 2, 2);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //Reverse
            Console.WriteLine("--array reverse--");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //Index of
            Console.WriteLine("--array Indexof--");
            Console.WriteLine(Array.IndexOf(sayiDizisi,15));

            //Resize
            Console.WriteLine("--array resize--");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
        }
    }
}