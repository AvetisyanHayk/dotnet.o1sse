using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening11
{
    class Betalingsmotor
    {
        public void VoerBetalingUit(Personeelslid persoon)
        {
            VoerBetalingUit(persoon.BerekenBedrag(), "loon", persoon.ToString());
        }

        public void VoerBetalingUit(Factuur factuur)
        {
            VoerBetalingUit(factuur.BerekenBedrag(), "kost", factuur.ToString());
        }

        private void VoerBetalingUit(decimal bedrag, string aard, string subject)
        {
            Console.WriteLine($"{bedrag} EUR werd betaald als {aard} voor {subject}");
        }
    }
}
