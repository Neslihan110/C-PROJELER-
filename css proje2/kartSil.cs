using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_Uygulamasi
{
    class KartSil
    {
        public static void Sil(List<Kart> cardsToDo, List<Kart> cardsInToDo, List<Kart> cardsDone)
        {
            bool find = false;
            while (find != true)
            {
                Console.WriteLine("Öncelikle Silmek İstediğiniz Kartı Seçiniz.");
                Console.Write("Lütfen Spor Başlığını Yazınız: ");
                string title = Console.ReadLine();
                foreach (Kart item in cardsToDo)
                {
                    if (item.Spor == title)
                    {
                        KartlarListesi.cardsTodo.Remove(item);
                        find = true;
                        break;
                    }
                }
                foreach (Kart item in cardsInToDo)
                {
                    if (item.Spor == title)
                    {
                        KartlarListesi.cardsInTodo.Remove(item);
                        find = true;
                        break;
                    }
                }
                foreach (Kart item in cardsDone)
                {
                    if (item.Spor == title)
                    {
                        KartlarListesi.cardsDone.Remove(item);
                        find = true;
                        break;
                    }
                }
                if (find == false)
                {
                    Console.WriteLine("Aradığınız Krtiterlere Uygun Spor Başlığı Board'da Bulunamadı. Lütfen Bir Seçim Yapınız.");
                    Console.WriteLine("* Silmeyi Sonlandırmak İçin : (1)");
                    Console.WriteLine("* Yeniden Denemek İçin : (2)");
                    string value = Console.ReadLine();
                    switch (value)
                    {
                        case "1":
                            {
                                find = true;
                                break;
                            }
                        case "2":
                            {
                                break;
                            }

                        default:
                            {
                                Console.WriteLine("Yanlış değer girdiniz programdan çıkılıyor...");
                                find = true;
                                break;
                            }
                    }
                }
            }
        }
    }
}
