using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POOpokemon
{
    public class Ataque
    {
        public string Nome { get; set; }
        public Tipo Tipo { get; set; }
        public string Poder { get; set; }
        public string Precisao { get; set; }
        public string Prioridade { get; set; }
        public string Categoria { get; set; }

        public void VerificarSeAtaqueEspecial()
        { }

        public void VerificarSeAtaqueFisico()
        { }

        public void VerificarSeAtaqueStatos()
        { }

    }
}