
using EhdokkaatLista;

namespace Aaniharava
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, VaaliLiitto> Puolueet = new Dictionary<string, VaaliLiitto>();
            List<string> Puoluetunnukset = new List<string>();
            List<Ehdokas> kaikki_ehdokkaat = new List<Ehdokas>();

            if (!File.Exists("/ehdokkaat.txt")) // jos tiedostoa ei löydy, printataan tiedostoa ei löydy : )
            {
                Console.WriteLine("Tiedostoa ei löydy");
            }
            // tämä osio raakasti mallista napattu, vähä piti sovittaa kuitenki tähän uuteen malliin
            foreach (string line in File.ReadLines("/ehdokkaat.txt"))
            {
                string[] osat = line.Split();
                
                if (osat.Length == 4)
                {
                    string etuNimi = osat[0];
                    string sukuNimi = osat[1];
                    string puolue = osat[2];
                    int aanimaara = int.Parse(osat[3]);

                    // tehdään olio ehdokkaasta
                    Ehdokas e = new Ehdokas(puolue, etuNimi, sukuNimi, aanimaara);
                  
                    if (!Puolueet.ContainsKey(puolue))   // löytyykö ehdokkaan puolue sanakirjasta?
                    {   // ei löydy, lisätään uusi alkio
                        Console.WriteLine("ei löydy puoluetta " + puolue + " luodaan uusi.");
                        Puolueet.Add(puolue, new VaaliLiitto(puolue));
                        Puoluetunnukset.Add(puolue);
                    }
                    Puolueet[puolue].LisaaEhdokas(e); // kun on tarkistettu löytyykö puolue, ja tarvittaessa luotu puolue, lisätään siihen ehdokas
                }   
            }

            for (int i = 0; i < Puoluetunnukset.Count; i++)
            {
                Console.WriteLine(Puoluetunnukset[i]);
                Puolueet[Puoluetunnukset[i]].Vertailuluvut(); // Vertailuluvut() järjestää puolueen ehdokkaat äänestysmäärän mukaan, ja äänien summan perusteella vertailuluvun 
                //   Puolueet[Puoluetunnukset[i]].tulostaehdokkaat();   // kaikki ehdokkaat tietoineen voi tulostaa
                //kaikki_ehdokkaat.Add(Puolueet[Puoluetunnukset[i]]

            }

            foreach (var item in kaikki_ehdokkaat)
            {
                Console.WriteLine(item);
            }
        }
    }
}



