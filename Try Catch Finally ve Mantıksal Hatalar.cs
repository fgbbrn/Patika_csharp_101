using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
           /* try
            {
                Console.WriteLine("Bir sayı giriniz");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı :" + sayi1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata : " + ex.Message.ToString());
                throw;
            }
            finally
            {
                Console.Write("İşlem tamamlandı.");
            }*/
            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("text");
                int a = int.Parse("-98765432198");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok küçük  ya da çok büyük bir değer girdiniz");
                Console.WriteLine(ex);
            }
            finally{
                Console.WriteLine("İşlem başarı ile tamamlandı.");
            } 
           
        }
    }
}
