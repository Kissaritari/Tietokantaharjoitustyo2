using EhdokkaatLista;

namespace Aaniharava
{
    
    class AanimaaranMukaan : IComparer<Ehdokas>
    {
        public int Compare(Ehdokas x, Ehdokas y)
        {
            int result = y.Aanimaara.CompareTo(x.Aanimaara);
            if (result == 0)
                result = x.Sukunimi.CompareTo(y.Sukunimi);
            if (result == 0)
                result = x.Etunimi.CompareTo(y.Etunimi);
            return result;
        }
    }
    class VertailuluvunMukaan :IComparer<Ehdokas>
    {
        public int Compare(Ehdokas x,Ehdokas y)
        {
            int result = x.Vertailuluku.CompareTo(y.Vertailuluku);
          /*  if (result != 0)
                result = x.Vaaliliitto.CompareTo(y.Vaaliliitto);
            if (result != 0)
                result = x.Sukunimi.CompareTo(y.Sukunimi);
            if (result != 0)
                result = x.Etunimi.CompareTo(y.Etunimi);*/
            return result;
        }
    }
    
    class Ehdokas : IComparable<Ehdokas>
    {
        public string Sukunimi;
        public string Etunimi;
        public int Aanimaara;
        public int Vertailuluku;
        public string Vaaliliitto;

        public Ehdokas(string Vaaliliitto, string Etunimi, string Sukunimi, int Aanimaara)
        {
            this.Etunimi = Etunimi;
            this.Sukunimi = Sukunimi;
            this.Aanimaara = Aanimaara;
            Vertailuluku = 0;
            this.Vaaliliitto = Vaaliliitto;
        }

        public override string ToString()
        {
            string s = String.Format("Sukunimi: {0} Etunimi: {1} Äänimäärä: {2} vertailuluku: {3} ",Sukunimi, Etunimi,Aanimaara,Vertailuluku);
            return s;
        }

        public int CompareTo(Ehdokas other)
        {
            int result = Vaaliliitto.CompareTo(other.Vaaliliitto);
            if (other == null) 
                return 1;
            if (result != 0)
                result = Aanimaara.CompareTo(other.Aanimaara);
            if (result != 0)
                result = Sukunimi.CompareTo(other.Sukunimi);
            if (result !=0)
                result = Etunimi.CompareTo(other.Etunimi);
            return result;
        }
    }
}