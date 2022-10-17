using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EhdokkaatLista
{
    // tee järjestäminen IComparer-luokalla niin, että ehdokkaat järjestyvät ensin puolueen mukaan
    // ja sitten nimen mukaan. Ota mallia Kortti-luokasta
    internal class PuolueenMukaan : IComparer<Ehdokas>
    {
        public int Compare(Ehdokas x, Ehdokas y)
        {
            int result = x.Puolue.CompareTo(y.Puolue);  
            if (result == 0)
                result = x.Sukunimi.CompareTo(y.Sukunimi);
                if (result == 0)
                    result = x.Etunimi.CompareTo(y.Etunimi);
            return result;
        }
    }


    internal class Ehdokas : IComparable<Ehdokas>
    {
        public string Etunimi { get; private set; }
        public string Sukunimi { get; private set; }
        public string Puolue { get; private set; }
        public int Aanimaara { get; private set; }
        public double VertailuLuku { get; set; }

        public Ehdokas(string etunimi, string sukunimi,
            string puolue, int aanimaara)
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            Puolue = puolue;
            Aanimaara = aanimaara;
        }

        public override string ToString()
        {
            return Etunimi + " " + Sukunimi + " " + Puolue + " " + Aanimaara;
        }

        public int CompareTo(Ehdokas other)
        {
            if (this.Sukunimi == other.Sukunimi)
            {
                return this.Etunimi.CompareTo(other.Etunimi);
            }
            return this.Sukunimi.CompareTo(other.Sukunimi);
        }
    }
}
