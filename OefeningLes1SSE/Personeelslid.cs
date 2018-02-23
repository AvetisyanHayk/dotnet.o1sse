using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening11
{
    class Personeelslid
    {
        public int Personeelsnummer { get; set; }
        public string Voornaam { get; set; }
        public string Familienaam { get; set; }

        public decimal BerekenBedrag()
        {
            return new Random().Next(1, 5) * Familienaam.Length * 200;
        }

        public override string ToString()
        {
            return Voornaam + " " + Familienaam;
        }
    }
}
