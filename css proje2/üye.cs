using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_Uygulamasi
{
    class Uye
    {
        private string ad;
        private string teamad;
        public Uye (string ad, string teamad)
        {
            this.Ad = ad;
            this.Teamad = teamad;
        }

        public string Ad
        {
            get
            {
                return ad;
            }

            set
            {
                ad = value;
            }
        }

        public string Teamad
        {
            get
            {
                return teamad;
            }

            set
            {
                teamad = value;
            }
        }
    }
}