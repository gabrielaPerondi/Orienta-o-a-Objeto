using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POOpokemon
{
    public class Tipo
    {
        public string Nome { get; set; }

        public List<string> ObterFraqueza()
        {
            return new List<string>("Fogo", "Agua", "Terra");
            

        }
        public void ObterResistencias()
        { }
        public void ObterImunidade()
        { }

    }
}