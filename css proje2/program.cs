using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_Uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            UyeListesi uyelist = new UyeListesi();
            KartlarListesi kartlist = new KartlarListesi();

            bool process = false;
            while (process != true)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Board Listelemek");
                Console.WriteLine("(2) Board'a Kart Eklemek");
                Console.WriteLine("(3) Board'dan Kart Silmek");
                Console.WriteLine("(4) Kart Taşımak");
                string selected = Console.ReadLine();
                switch (selected)
                {
                    case "1":
                        {
                            KartlariListele.Liste();
                            break;
                        }
                    case "2":
                        {
                            KartEkle.Ekle();
                            break;
                        }
                    case "3":
                        {
                            KartSil.Sil(KartlarListesi.cardsTodo,KartlarListesi.cardsInTodo, KartlarListesi.cardsTodo);
                            break;
                        }
                    case "4":
                        {
                            KartTasi.Tasi(KartlarListesi.cardsTodo, KartlarListesi.cardsInTodo, KartlarListesi.cardsTodo);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Geçerli Bir Değer Giriniz.");
                            break;
                        }
                }



            }
        }
    }
}