using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_Uygulamasi
{
    class KartlariListele
    {
        public static void Liste()
        {
            Console.WriteLine("TODO Line");
            Console.WriteLine("************************");
            if (KartlarListesi.cardsTodo.Count == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }
            else
            {
                foreach (var item in KartlarListesi.cardsTodo)
                {
                    Console.WriteLine("Başlık      : {0}", item.Spor);
                    Console.WriteLine("İçerik      : {0}", item.Dal);
                    Console.WriteLine("Atanan Kişi : {0}", item.Uye.Ad);
                    Console.WriteLine("Büyüklük    : {0}", item.Size);
                    Console.WriteLine("-");
                }
            }
            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("************************");
            if (KartlarListesi.cardsDone.Count == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }
            else
            {
                foreach (var item in KartlarListesi.cardsInTodo)
                {
                    Console.WriteLine("Başlık      : {0}", item.Spor);
                    Console.WriteLine("İçerik      : {0}", item.Dal);
                    Console.WriteLine("Atanan Kişi : {0}", item.Uye.Ad);
                    Console.WriteLine("Büyüklük    : {0}", item.Size);
                    Console.WriteLine("-");
                }
            }
            Console.WriteLine("DONE Line");
            Console.WriteLine("************************");
            if (KartlarListesi.cardsDone.Count == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }
            else
            {
                foreach (var item in KartlarListesi.cardsDone)
                {
                    Console.WriteLine("Başlık      : {0}", item.Spor);
                    Console.WriteLine("İçerik      : {0}", item.Dal);
                    Console.WriteLine("Atanan Kişi : {0}", item.Uye.Ad);
                    Console.WriteLine("Büyüklük    : {0}", item.Size);
                    Console.WriteLine("-");
                }
            }
        }
    }
}