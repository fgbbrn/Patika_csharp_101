using System;

namespace if_elseif_ternary_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if (time >=6 && time <11)
            {
                Console.WriteLine("Günaydın");
            }
            else if (time <=18)
            {
                Console.WriteLine("İyi Günler");
            }
            else
            {
                Console.WriteLine("İyi Geceler");
            }

            string sonuc = time <= 18 ? "İyi Günler" : "iyi Geceler";
            sonuc = time < 11 && time >= 6 ? "Günaydın" : time <= 18 ? "İyi Günler" : "İyi Geceler";
            Console.WriteLine(sonuc);
        }
    }
    
}

