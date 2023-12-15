using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    internal class Lid
    {
        public Lid(int lidNummer, string voorNaam, string achterNaam, int leeftijd) 
        {
            this.lidNummer = lidNummer;
            this.voorNaam = voorNaam;
            this.achterNaam = achterNaam;
            this.leefttijd = leeftijd;
        }

        public void Jarig() { leefttijd++; }

        public int GetLidNummer() { return lidNummer; }
        public string GetFullName() { return voorNaam + " " + achterNaam; }
        public int GetLeeftijd() { return leefttijd; }

        public void SetVoornaam(string voorNaam) { this.voorNaam = voorNaam; }
        public void SetAchternaam(string achterNaam) { this.achterNaam = achterNaam; }

        private int lidNummer;
        private string voorNaam;
        private string achterNaam;
        private int leefttijd;

    }
}
