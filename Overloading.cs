using System;

namespace overloading
{
    class overloading
    {
        static void Main(string[] args)
        {
            // out parametreler Değer tipi referans tipte gönderilir.TryParse ile kullanımı vardır.
            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız!");
            }

            Metotlar instance = new Metotlar();

            instance.Topla(4, 5, out int toplamSonuc);
            Console.WriteLine(toplamSonuc);

            int sayi1;
            int sayi2 = 20;
            instance.Topla(out sayi1, sayi2);

            // Metot imzasının değiştirilerek aynı isimdeki metodun birden farklı versiyonun yaratılmasıdır.
            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Murat ","Neslihan");
        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }
        public void Topla(out int a, int b)
        {
            a = 10;
            int toplam = a + b;
            Console.WriteLine(toplam);
        }
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }
    }
}
