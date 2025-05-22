using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace orientacaoObjeto
{
    public class Tigre : Animal
    {
        public Tigre(string nome, int idade)
        :base(nome,idade) {}

        public override void EmitirSom()
        {
            Console.WriteLine("grrrrr!, (som do Tigre)");
        }
        
    }
}