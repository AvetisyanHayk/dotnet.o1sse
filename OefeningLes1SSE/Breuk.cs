using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening7
{
    class Breuk
        : ICloneable
    {
        public Breuk(int teller, int noemer)
        {
            this.Teller = teller;
            this.Noemer = noemer;
        }
        public int Teller { get; set; }
        public int Noemer { get; set; }

        public static Breuk operator + (Breuk breuk1, Breuk breuk2)
        {
            Breuk breuk = new Breuk(breuk1.Teller * breuk2.Noemer + breuk2.Teller * breuk1.Noemer, breuk1.Noemer * breuk2.Noemer);
            breuk.optimize();
            return breuk;
        }

        public static Breuk operator - (Breuk breuk1, Breuk breuk2)
        {
            Breuk breuk = new Breuk(breuk1.Teller * breuk2.Noemer - breuk2.Teller * breuk1.Noemer, breuk1.Noemer * breuk2.Noemer);
            breuk.optimize();
            return breuk;
        }

        public static Breuk operator / (Breuk breuk1, Breuk breuk2)
        {
            Breuk breuk2bis = (Breuk) breuk2.Clone();
            breuk2bis.swap();
            return breuk1 * breuk2bis;
        }

        public static Breuk operator * (Breuk breuk1, Breuk breuk2)
        {
            Breuk breuk = new Breuk(breuk1.Teller * breuk2.Teller, breuk1.Noemer * breuk2.Noemer);
            breuk.optimize();
            return breuk;
        }

        public static bool operator > (Breuk breuk1, Breuk breuk2)
        {
            return breuk1.GetValue() > breuk2.GetValue();
        }
        public static bool operator >= (Breuk breuk1, Breuk breuk2)
        {
            return breuk1.GetValue() >= breuk2.GetValue();
        }

        public static bool operator < (Breuk breuk1, Breuk breuk2)
        {
            return breuk1.GetValue() < breuk2.GetValue();
        }

        public static bool operator <=(Breuk breuk1, Breuk breuk2)
        {
            return breuk1.GetValue() <= breuk2.GetValue();
        }

        public static bool operator == (Breuk breuk1, Breuk breuk2)
        {
            return breuk1.GetValue() == breuk2.GetValue();
        }

        public static bool operator != (Breuk breuk1, Breuk breuk2)
        {
            return breuk1.GetValue() != breuk2.GetValue();
        }

        public double GetValue()
        {
            return (double)this.Teller / this.Noemer;
        }

        public void swap()
        {
            this.Noemer += this.Teller;
            this.Teller = this.Noemer - this.Teller;
            this.Noemer = this.Noemer - this.Teller;
        }

        private void optimize()
        {
            int ggd = GetGgd(this);
            this.Teller /= ggd;
            this.Noemer /= ggd;
        }


        private static int GetGgd(Breuk breuk)
        {
            return GetGgd(breuk.Teller, breuk.Noemer);
        }

        private static int GetGgd(int noemer1, int noemer2)
        {
            if (noemer2 == 0)
            {
                return noemer1;
            }
            return GetGgd(noemer2, (noemer1 % noemer2));
        }

        public override string ToString()
        {
            return $"{Teller}/{Noemer}";
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
