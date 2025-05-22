using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POOpokemon
{
    public class Pokemon
    {
        public string Nome { get; set; }
        public int Peso { get; set; }
        public int Altura { get; set; }
        public Tipo Tipo { get; set; }
        public Ataque Ataque { get; set; }


        public virtual void AprenderAtaque()
        { }

        public virtual void RemoverAtaque()
        { }



    }
}