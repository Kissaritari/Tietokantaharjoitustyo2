using System;

namespace Aaniharava
{
    class VaaliLiitto
    {
        public string Tunnus { get; set; }
        public List<Ehdokas> Ehdokaslista = new List<Ehdokas>();

        public VaaliLiitto(string tunnus)
        {
            Tunnus = tunnus;
        }

        public void LisaaEhdokas(Ehdokas e)
        {
            Ehdokaslista.Add(e);
        }
        public void tulostaehdokkaat()
        {
            foreach (Ehdokas item in Ehdokaslista)
            {
                Console.WriteLine(item);
            }
        }
                public void Vertailuluvut()
        {
            double summa = 0;
            foreach (Ehdokas e in Ehdokaslista)
            {
                summa += Convert.ToDouble(e.Aanimaara);
            }
            Ehdokaslista.Sort(new AanimaaranMukaan());
            Console.WriteLine("‰‰nim‰‰rien summa on: " + summa);

            for (int i = 0; i < Ehdokaslista.Count; i++)
            {
                Ehdokaslista[i].Vertailuluku = Convert.ToInt32(summa / (i + 1));
                
            }
        }

        }
            
    }
