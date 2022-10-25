using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EhdokkaatLista
{
    internal class Puolue
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public int Aanimaara { get; set; }
        public int EhdokkaidenLkm { get; set; }

        private List<Ehdokas> ehdokkaat = new List<Ehdokas>();

        public Puolue(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return this.Name + " " + this.Aanimaara + " " + this.EhdokkaidenLkm;
        }
    }
}
