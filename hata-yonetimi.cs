using System;

namespace hata-yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // int a = int.Parse(null);
                // int a = int.Parse("test");
                int a = int.Parse("1500000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz.");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil.");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok küçük ya da çok büyük değer girdiniz.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
            }

        }
    }
}