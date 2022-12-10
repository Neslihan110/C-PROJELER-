using System;

namespace algoritma-ödevleri
{
    class Program
    {
        //ödev 1
        
      static void Main(string[] args)
        {
            ////Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            try
            {
                
                
                Console.Write("Pozitif bir sayi giriniz: ");

                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Lütfen {0} adet pozitif sayi giriniz: ", n);

                int[] sayiDizisi = new int[n];

                for (int i = 0; i < n; i++)
                {
                    sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());

                    if (sayiDizisi[i] < 0)
                    {
                        Console.WriteLine("Negatif sayi girdiniz. Tekrar deneyin!");
                        break;
                    }
                }
                Console.WriteLine("Çift Sayilar");
                int sayac = 0;
                foreach (int sayi in sayiDizisi)
                {
                    if (sayi < 0)
                        break;
                    else if (sayi % 2 == 0)
                    {
                        Console.WriteLine(sayi);
                        sayac++;
                    }
                }
                Console.WriteLine("{0} adet çift sayi bulundu.", sayac);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());
            }
        }

       //ödev 2

      static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            try
            {
                Console.WriteLine("Lütfen pozitif iki sayi giriniz: ");
                int[] sayiConsole = new int[2];
                for (int i = 0; i < sayiConsole.Length; i++)
                {
                    Console.Write("{0}. sayi: ", i + 1);
                    sayiConsole[i] = Convert.ToInt32(Console.ReadLine());
                }
                int n = sayiConsole[0];
                int m = sayiConsole[1];

                Console.WriteLine("Lütfen {0} adet pozitif sayi giriniz: ", n);
                int[] sayiDizisi = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write("{0}. sayi: ", i + 1);
                    sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("{0} sayisina eşit veya tam bölünen sayilar", m);
                foreach (int sayi in sayiDizisi)
                {
                    if (sayi == m || sayi % m == 0)
                        Console.WriteLine(sayi);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());
            }
        }

        //ödev 3

      static void Main(string[] args)
        {
           //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            try
            {
                Console.Write("Lütfen pozitif bir sayi giriniz: ");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Lütfen {0} adet kelime giriniz: ", n);
                string[] kelimeDizisi = new string[n];
                for (int i = 0; i < n; i++)
                    kelimeDizisi[i] = Console.ReadLine();

                Array.Reverse(kelimeDizisi);
                Console.WriteLine("Sondan başa doğru girilen kelimeler");
                foreach (string kelime in kelimeDizisi)
                    Console.WriteLine(kelime);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());
            }
        }

        //ödev 4
        
      static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            Console.Write("Lütfen bir cümle giriniz: ");
            string ifade = Console.ReadLine();

            string[] kelimeDizisi = ifade.Split(" ");
            int kelimeSayisi = kelimeDizisi.Length;

            string harfDizisi = string.Join("", kelimeDizisi);

            char[] harf = harfDizisi.ToCharArray();
            int harfSayisi = harf.Length;

            Console.WriteLine("Girilen cümledeki toplam kelime sayisi: {0}", kelimeSayisi);
            Console.WriteLine("Girilen cümledeki toplam harf sayisi: {0}", harfSayisi);
        }

    }
}