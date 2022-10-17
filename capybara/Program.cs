namespace EhdokkaatLista
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            // https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-read-a-text-file-one-line-at-a-time
            // tiedoston lukeminen
            int counter = 0;

            // sanakirja puolueista
            Dictionary<string, Puolue> puolueet = new Dictionary<string, Puolue>();

            // Read the file and display it line by line.  
            foreach (string line in File.ReadLines(@"Y:\Makela_Petteri\TITE21\Tietorakenteet ja algoritmit\ehdokkaat.txt"))
            {
                // "Aaro	Harjunpää	KESK	371"
                string[] osat = line.Split();
                if (osat.Length == 4)
                {
                    string en = osat[0];
                    string sn = osat[1];
                    string puolue = osat[2];
                    int aanimaara = int.Parse(osat[3]);

                    // tehdään olio
                    Ehdokas e = new Ehdokas(en, sn, puolue, aanimaara);
                    
                    // löytyykö ehdokkaan puolue sanakirjasta?
                    if (!puolueet.ContainsKey(puolue))
                    {   // ei löydy, lisätään uusi alkio
                        Puolue p = new Puolue(puolue, puolue);
                        puolueet.Add(puolue, p);
                    }
                    Puolue pp = puolueet[puolue];
                    pp.Aanimaara += e.Aanimaara;
                    pp.EhdokkaidenLkm++;

                    counter++;
                }
            }

            // tulostetaan lopputulos näytölle (avaimet ja arvot)
            foreach (KeyValuePair<string, Puolue> pair in puolueet)
            {
                Console.WriteLine(pair.Key + ": " + pair.Value.Aanimaara
                    + " " + pair.Value.EhdokkaidenLkm);
            }

        }
    }
}