using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_Uygulamasi
{
    class KartTasi
    {
        public static void Tasi(List<Kart> cardsToDo, List<Kart> cardsInToDo, List<Kart> cardsDone)
        {
            bool find = false;
            while (find != true)
            {
                Console.WriteLine("Öncelikle Taşımak İstediğiniz Spor Başlığı Seçmeniz Gerekiyor.");
                Console.Write("Lütfen Spor Başlığını yazınız: ");
                string title = Console.ReadLine();
                foreach (Kart item in cardsToDo)
                {
                    if (item.Spor == title)
                    {
                        Console.WriteLine("Bulunan Kart Bilgileri:");
                        Console.WriteLine("**************************************");
                        Console.WriteLine("Başlık      : {0}", item.Spor);
                        Console.WriteLine("İçerik      : {0}", item.Dal);
                        Console.WriteLine("Atanan Kişi : {0}", item.Uye.Ad);
                        Console.WriteLine("Büyüklük    : {0}", item.Size);
                        Console.WriteLine("Line        : TODO");
                        Console.WriteLine("\nLütfen taşımak istediğiniz Line'ı seçiniz: ");
                        Console.WriteLine("(1) TODO");
                        Console.WriteLine("(2) IN PROGRESS");
                        Console.WriteLine("(3) DONE");
                        string val = Console.ReadLine();
                        switch (val)
                        {
                            case "1":
                                {
                                    Console.WriteLine("Zaten Bu Line'da");
                                    break;
                                }
                            case "2":
                                {
                                    KartlarListesi.cardsInTodo.Add(item);
                                    KartlarListesi.cardsTodo.Remove(item);
                                    break;
                                }
                            case "3":
                                {
                                    KartlarListesi.cardsDone.Add(item);
                                    KartlarListesi.cardsTodo.Remove(item);
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Yanlış Değer Girdiniz. Programdan Çıkılıyor...");
                                    find = true;
                                    break;
                                }
                        }
                        find = true;
                        break;
                    }
                }
                if (find)
                {
                    break;
                }


                foreach (Kart item in cardsInToDo)
                {
                    if (item.Spor == title)
                    {
                        Console.WriteLine("Bulunan Kart Bilgileri:");
                        Console.WriteLine("**************************************");
                        Console.WriteLine("Başlık      : {0}", item.Spor);
                        Console.WriteLine("İçerik      : {0}", item.Dal);
                        Console.WriteLine("Atanan Kişi : {0}", item.Uye.Ad);
                        Console.WriteLine("Büyüklük    : {0}", item.Size);
                        Console.WriteLine("Line        : IN PROGRESS");
                        Console.WriteLine("\nLütfen taşımak istediğiniz Line'ı seçiniz: ");
                        Console.WriteLine("(1) TODO");
                        Console.WriteLine("(2) IN PROGRESS");
                        Console.WriteLine("(3) DONE");
                        string val = Console.ReadLine();
                        switch (val)
                        {
                            case "1":
                                {
                                    KartlarListesi.cardsTodo.Add(item);
                                    KartlarListesi.cardsInTodo.Remove(item);
                                    break;
                                }
                            case "2":
                                {
                                    Console.WriteLine("Zaten Bu Line'da");
                                    break;
                                }
                            case "3":
                                {
                                    KartlarListesi.cardsDone.Add(item);
                                    KartlarListesi.cardsInTodo.Remove(item);
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Yanlış Değer Girdiniz. Programdan Çıkılıyor...");
                                    find = true;
                                    break;
                                }
                        }
                        find = true;
                        break;
                    }
                }
                if (find)
                {
                    break;
                }
                foreach (Kart item in cardsDone)
                {
                    if (item.Spor == title)
                    {
                        Console.WriteLine("Bulunan Kart Bilgileri:");
                        Console.WriteLine("**************************************");
                        Console.WriteLine("Başlık      : {0}", item.Spor);
                        Console.WriteLine("İçerik      : {0}", item.Dal);
                        Console.WriteLine("Atanan Kişi : {0}", item.Uye.Ad);
                        Console.WriteLine("Büyüklük    : {0}", item.Size);
                        Console.WriteLine("Line        : Done");
                        Console.WriteLine("\nLütfen taşımak istediğiniz Line'ı seçiniz: ");
                        Console.WriteLine("(1) TODO");
                        Console.WriteLine("(2) IN PROGRESS");
                        Console.WriteLine("(3) DONE");
                        string val = Console.ReadLine();
                        switch (val)
                        {
                            case "1":
                                {
                                    KartlarListesi.cardsTodo.Add(item);
                                    KartlarListesi.cardsDone.Remove(item);
                                    break;
                                }
                            case "2":
                                {
                                    KartlarListesi.cardsInTodo.Add(item);
                                    KartlarListesi.cardsDone.Remove(item);
                                    break;
                                }
                            case "3":
                                {
                                    Console.WriteLine("Zaten Bu Line'da");
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Yanlış Değer Girdiniz. Programdan Çıkılıyor...");
                                    find = true;
                                    break;
                                }
                        }
                        find = true;
                        break;
                    }
                }
                if (find == false)
                {
                    Console.WriteLine("Aradığınız krtiterlere Spor Başlığı board'da bulunamadı. Lütfen Bir Seçim Yapınız.");
                    Console.WriteLine("* Taşımayı Sonlandırmak İçin : (1)");
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
                                Console.WriteLine("Yanlış Değer Girdiniz Programdan Çıkılıyor...");
                                find = true;
                                break;
                            }
                    }
                }
            }
        }
    }
}