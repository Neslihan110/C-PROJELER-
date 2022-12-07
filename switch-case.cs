using System;

namespace switch-case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1:
                    Console.WriteLine("1. ay Ocak");
                    break;
                case 2:
                    Console.WriteLine("2. ay Şubat");
                    break;
                case 3:
                    Console.WriteLine("3. ay Mart");
                    break;
                default:
                    Console.WriteLine("Yanlış veri girişi.");
                    break;
            }

            // Birden fazla koşulda switch case kullanımı 
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış ayındayız.");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar ayındayız.");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz ayındayız.");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar ayındayız.");
                    break;
                default:
                    break;

            }
        }
    }
}