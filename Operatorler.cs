using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Atama ve İşlemli Atama *****");

            //Atama ve İşlemli Atama
            int x = 3;
            int y = 4;
            y = y + 2;
            Console.WriteLine(y);

            y += 2;
            Console.WriteLine(y);

            y /= 1;
            Console.WriteLine(y);

            x += 2;
            Console.WriteLine(x);
            
            Console.WriteLine("*****Mantıksal Operatörler*****");

            //Mantıksal Operatörler
            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
                Console.WriteLine("Perfect!");

            if (isSuccess || isCompleted)
                Console.WriteLine("Great!");

            if (isSuccess && isCompleted)
                Console.WriteLine("Great!");

            Console.WriteLine("*****İlişkisel Operatörler*****");
            //İlişkisel Operatörler

            int a = 3;
            int b = 4;
            bool sonuc = a < b;
            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a < b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);

            Console.WriteLine("*****Aritmetik Operatörler*****");
            //Aritmetik Operatörler

            int c = 10;
            int d = 5;
            int sonuc1 = c + d;
            Console.WriteLine(sonuc1);
            sonuc1 = c * d;
            Console.WriteLine(sonuc1);
            sonuc1 = c - d;
            Console.WriteLine(sonuc1);
            sonuc1 = c / d;
            Console.WriteLine(sonuc1);
            int sonuc2 = 20 % 3;
            Console.WriteLine(sonuc2);


        }
    }
}