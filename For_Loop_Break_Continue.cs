using System;

namespace for_loop_break_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrana girilen sayıya kadar olan tek sayıları yazdır
            Console.WriteLine("Lütfen birsayı giriniz!");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 0; i <= sayac; i++)
            {
                if (i %2 ==1)
                {
                    Console.WriteLine(i);
                }
                //Komutlar
            }

            //1-1000 arasında tek ve çift sayıların toplamlarının elde dilmesi
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 ==1)
                {
                    tekToplam += i; //tekToplam + tekToplam
                }
                else
                {
                    ciftToplam += i; //ciftToplam + ciftToplam
                }
               
            }
            Console.WriteLine("TekToplam:" + tekToplam);
            Console.WriteLine("ÇiftToplam:" + ciftToplam);

            //Break - Continue

            for (int i = 1; i < 10; i++)
            {
                if(i == 4)
                break;
                Console.WriteLine(i);
            }
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }

        }
    }
}