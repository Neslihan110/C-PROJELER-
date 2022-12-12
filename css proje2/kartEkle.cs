using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_Uygulamasi
{
    class KartEkle
    {
        public static void Ekle()
        {
            Console.WriteLine("Spor Başlığı Giriniz      :");
            string title = Console.ReadLine();
            Console.WriteLine("Giridiğiniz Spor Başlığına uygun İçerik Giriniz  :");
            string content = Console.ReadLine();
            Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
            string size = Console.ReadLine();
            Console.WriteLine("Kişi Seçiniz -> (0,1,2,3,4)                     :");
            string person = Console.ReadLine();
            if (person == "0" || person == "1" || person == "2" || person == "3" || person == "4")
            {
                switch (size)
                {
                    case "1":
                        {
                          KartlarListesi.cardsTodo.Add(new Kart(title, content, UyeListesi.uyeler[Int16.Parse(person)], Sizes.XS));
                            break;
                        }
                    case "2":
                        {
                            KartlarListesi.cardsTodo.Add(new Kart(title, content, UyeListesi.uyeler[Int16.Parse(person)], Sizes.S));
                            break;
                        }
                    case "3":
                        {
                            KartlarListesi.cardsTodo.Add(new Kart(title, content, UyeListesi.uyeler[Int16.Parse(person)], Sizes.M));
                            break;
                        }
                    case "4":
                        {
                            KartlarListesi.cardsTodo.Add(new Kart(title, content, UyeListesi.uyeler[Int16.Parse(person)], Sizes.L));
                            break;
                        }
                    case "5":
                        {
                            KartlarListesi.cardsTodo.Add(new Kart(title, content, UyeListesi.uyeler[Int16.Parse(person)], Sizes.XL));
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Lütfen Geçerli Bir Değer Giriniz.");
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("Hatalı Girişler Yaptınız!");
            }

        }
    }
   
        }
 