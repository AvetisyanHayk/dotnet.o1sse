using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening11
{
    class Factuur
    {
        public int Factuurnummer { get; set; }
        public string Omschrijving { get; set; }

        public decimal BerekenBedrag()
        {
            return new Random().Next(1, 5) * Omschrijving.Length * 200;
        }

        public override string ToString()
        {
            return $"{Omschrijving} (factuur {Factuurnummer})";
        }
    }
}
