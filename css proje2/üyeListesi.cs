using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_Uygulamasi
{
    class UyeListesi
    {
        public static List<Uye> uyeler = new List<Uye>();
        public UyeListesi()
        {
            Uye uye1 = new Uye("Ali", "Basket");
            Uye uye2 = new Uye("Çağrı", "Tenis");
            Uye uye3 = new Uye("Veli", "Voleybol");
            Uye uye4 = new Uye("Resul", "Futbol");
            Uye uye5 = new Uye("Osman", "Hentbol");

            uyeler.Add(uye1);
            uyeler.Add(uye2);
            uyeler.Add(uye3);
            uyeler.Add(uye4);
            uyeler.Add(uye5);
        }
    }
}