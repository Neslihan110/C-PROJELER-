using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_Uygulamasi
{
    class Kart
    {
        private string spor;
        private string dal;
        private Uye uye;
        private Sizes size;

        public string Spor
        {
            get
            {
                return spor;
            }

            set
            {
                spor = value;
            }
        }

        public string Dal
        {
            get
            {
                return dal;
            }

            set
            {
                dal = value;
            }
        }

        internal Uye Uye
        {
            get
            {
                return uye;
            }

            set
            {
                uye = value;
            }
        }

        public Sizes Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
            }
        }

        public Kart(string spor, string dal, Uye uye, Sizes size)
        {
            this.Spor = spor;
            this.Dal = dal;
            this.Uye = uye;
            this.Size = size;

        }

    }
    public enum Sizes
    {
        XS = 1,
        S = 2,
        M = 3,
        L = 4,
        XL = 5
    }
}