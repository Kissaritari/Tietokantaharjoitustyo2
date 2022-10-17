namespace Aaniharava
{
    class AanimaaranMukaan : IComparer<Ehdokas>
    {
        public int Compare(Ehdokas x, Ehdokas y)
        {
            return -x.Aanimaara + y.Aanimaara;
        }
    }

    class Ehdokas : IComparable<Ehdokas>
    {
        public string Sukunimi;
        public string Etunimi;
        public int Aanimaara;
        public int Vertailuluku;
        public string Vaaliliitto;

        public Ehdokas(string Vaaliliitto, string etunimi, string sukunimi, int aanimaara, int vertailuluku)
        {
            this.Etunimi = etunimi;
            this.Sukunimi = sukunimi;
            this.Aanimaara = aanimaara;
            this.Vertailuluku = vertailuluku;
            this.Vaaliliitto = Vaaliliitto;
        }

        public override string ToString()
        {
            string s = String.Format("Sukunimi {0} Etunimi {1} Äänimäärä {2} vertailuluku{3} ",sukunimi, etunimi,aanimaara,vertailuluku);
            return s;
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