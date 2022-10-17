namespace Aaniharava
{
    class Vaaliliitto
    {
    string Nimi;
    string Tunnus;
    List<Ehdokas> Ehdokaslista = new List<Ehdokas>();

    public void LisaaEhdokas(Ehdokas e)
    {
        Ehdokaslista.Add(e);
    }
    }
}