using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace orientacaoObjeto
{
    public class Lobo : Animal
    {
        public Lobo(string nome,int idade)
        :base(nome,idade) {}

        public override void EmitirSom()
        {
            Console.WriteLine("Auuuuuuu!, (som do Lobo)");
        }
        
    }
}