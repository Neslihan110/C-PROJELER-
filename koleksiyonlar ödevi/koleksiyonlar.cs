using System;
using System.Collections;

namespace koleksiyonlar
{
    class Program
    {

       //ödev 1

        static void Main(string[] args)
        {

            ArrayList sayilarListesi = new ArrayList();

            try
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.Write("Lütfen {0}. pozitif sayıyı giriniz: ", i + 1);
                    string strSayi = Console.ReadLine();
                    int sayi = int.Parse(strSayi);

                    if (sayi < 0)
                    {
                        Console.Write("Hata oluştu! Lütfen pozitif bir sayı giriniz.");
                        break;
                    }
                    else
                        sayilarListesi.Add(sayi);
                }
            }
            catch (FormatException exc)
            {
                Console.WriteLine("Hata oluştu! Lütfen rakam giriniz. \n" + exc.Message);
            }

            ArrayList asalSayilarListesi = new ArrayList();
            ArrayList asalOlmayanSayilarListesi = new ArrayList();

            foreach (int sayi in sayilarListesi)
            {
                if (AsalMi(sayi))
                    asalSayilarListesi.Add(sayi);
                else
                    asalOlmayanSayilarListesi.Add(sayi);
            }

            asalSayilarListesi.Sort();
            asalSayilarListesi.Reverse();
            Console.WriteLine();
            Console.WriteLine("Asal sayıların büyükten küçüğe sıralı listesi: ");
            ListeYazdir(asalSayilarListesi);
            Console.WriteLine("Asal sayılar listesinin eleman sayısı: {0}  ve ortalaması: {1}",
                asalSayilarListesi.Count, OrtalamaYazdir(asalSayilarListesi));

            asalOlmayanSayilarListesi.Sort();
            asalOlmayanSayilarListesi.Reverse();
            Console.WriteLine("Asal olmayan sayıların büyükten küçüğe sıralı listesi: ");
            ListeYazdir(asalOlmayanSayilarListesi);
            Console.WriteLine("Asal olmayan sayılar listesinin eleman sayısı: {0}  ve ortalaması: {1}",
                asalOlmayanSayilarListesi.Count, OrtalamaYazdir(asalOlmayanSayilarListesi));
        }
        static bool AsalMi(int sayi)
        {
            bool durum = false;
            int kontrol = 0;
            if (sayi <= 1) durum = false;

            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    kontrol = 1;
                    break;
                }
            }
            if (kontrol == 1)
                durum = false;
            else
                durum = true;

            return durum;
        }
        static void ListeYazdir(ArrayList liste)
        {
            for (int i = 0; i < liste.Count; i++)
            {
                Console.Write(liste[i] + " ");
            }
            Console.WriteLine();
        }
        static double OrtalamaYazdir(ArrayList liste)
        {
            int toplam = 0;
            for (int i = 0; i < liste.Count; i++)
            {
                toplam += Convert.ToInt32(liste[i]);
            }
            double ortalama = (double)toplam / liste.Count;
            return ortalama;
        }

        //ödev 2

         static void Main(string[] args)
        {

            int[] numbers = new int[20];
           
            try
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.Write("Lütfen {0}. pozitif tam sayıyı giriniz: ", i + 1);
                    string strNumber = Console.ReadLine();
                    int number = Convert.ToInt32(strNumber);
                    if (number < 0)
                    {
                        Console.WriteLine("Hata oluştu! Lütfen pozitif bir tam sayı giriniz.");
                        break;
                    }
                    else
                        numbers[i] = number;
                }
            }
            catch (FormatException exc)
            {

                Console.WriteLine("Hata oluştu! " + exc.Message);
            }

            Array.Sort(numbers);
            Console.WriteLine("Küçükten büyüğe sıralı liste: ");
            foreach (var number in numbers)
                Console.Write(number + " ");
                Console.WriteLine();

            int[] minThreeNumberList = new int[3];
            int[] maxThreeNumberList = new int[3];
            int minThreeNumberTotal = 0;
            int maxThreeNumberTotal = 0;

            for (int i = 0; i < 3; i++)
            {
                minThreeNumberList[i] = numbers[i];
                minThreeNumberTotal += minThreeNumberList[i];
            }

            for (int i = numbers.Length - 1; i > numbers.Length - 4; i--)
            {
                maxThreeNumberList[(numbers.Length - 1) - i] = numbers[i];
                maxThreeNumberTotal += maxThreeNumberList[(numbers.Length - 1) - i];
            }

            double avgMinThreeNumber = (double)minThreeNumberTotal / minThreeNumberList.Length;
            double avgMaxThreeNumber = (double)maxThreeNumberTotal / maxThreeNumberList.Length;

            Console.WriteLine("En küçük üç sayının ortalaması: {0} En büyük üç sayının ortalaması: {1}", avgMinThreeNumber, avgMaxThreeNumber);
            Console.WriteLine("Bulunan ortalamaların toplamı: {0}", (avgMinThreeNumber + avgMaxThreeNumber));
        }

        //ödev 3

         static void Main(string[] args)

        {
            Console.WriteLine("Lütfen bir cümle yazınız: ");
            string cumle = Console.ReadLine();
            char[] cumleHarflerDizisi = cumle.ToLower().ToCharArray();

            char[] sesliHarflerDizisi = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

            List<char> cumleSesliHarfListesi = new List<char>();

            for (int i = 0; i < cumleHarflerDizisi.Length; i++)
            {
                for (int j = 0; j < sesliHarflerDizisi.Length; j++)
                {
                    if (cumleHarflerDizisi[i] == sesliHarflerDizisi[j])
                        cumleSesliHarfListesi.Add(cumleHarflerDizisi[i]);
                }
            }
            cumleSesliHarfListesi.Sort();
            Console.WriteLine("Cümle içerisindeki sesli harflerin sıralanarak yazılması: ");

            foreach (char harf in cumleSesliHarfListesi)
                Console.Write(harf + " ");
        }
    }

}