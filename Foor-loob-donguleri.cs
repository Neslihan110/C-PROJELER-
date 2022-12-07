using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.Write("Lütfen bir sayı giriniz: ");
             int sayac = int.Parse(Console.ReadLine());
             
             for (int i = 1; i <= sayac; i++)
             {
                if (i % 2 == 1)
                    Console.WriteLine(i);
             }
            int tekToplam = 0;
            int ciftToplam = 0;
            
            for (int i = 1; i <= 1000; i++)
            {
               if (i % 2 == 1)
                     tekToplam += i;
               else
                     ciftToplam += i;
             }
             Console.WriteLine("Tek Toplam = " + tekToplam);
             Console.WriteLine("Çift Toplam = " + ciftToplam);

            
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
            }
            Console.WriteLine("");
            
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }
            Console.WriteLine("");
            
            // Sonsuz döngü
            for (; ; )
            {
                char ch = Convert.ToChar(Console.ReadLine());
                int intVal = int.Parse(ch.ToString());
                if (intVal == 7)
                    break;
            }

        }
    }
}