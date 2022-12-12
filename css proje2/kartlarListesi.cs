using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_Uygulamasi
{
    class KartlarListesi
    {
        public static List<Kart> cardsTodo = new List<Kart>();
        public static List<Kart> cardsInTodo = new List<Kart>();
        public static List<Kart> cardsDone = new List<Kart>();
        public KartlarListesi()
        {
            Kart kart1 = new Kart("Basketbol", "Basket 5 kişiyle oynanır.", UyeListesi.uyeler[0], Sizes.M);
            Kart kart2 = new Kart("Tenis", "Tenis 2 kişiyle oynanır.", UyeListesi.uyeler[1], Sizes.XS);
            Kart kart3 = new Kart("Voleybol", "Voleybol 5 kişiyle oynanır.", UyeListesi.uyeler[2], Sizes.S);
            Kart kart4 = new Kart("Futbol", "Futbol 11 kişiyle oynanır.", UyeListesi.uyeler[3], Sizes.XL);
            Kart kart5 = new Kart("Hentbol", "Hentbol 7 kişiyle oynanır.", UyeListesi.uyeler[4], Sizes.L);
            cardsTodo.Add(kart1);
            cardsTodo.Add(kart2);
            cardsInTodo.Add(kart3);
            cardsInTodo.Add(kart4);
            cardsDone.Add(kart5);
        }
    }
}