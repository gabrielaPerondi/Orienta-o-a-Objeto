using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace orientacaoObjeto
{
    public class Papagaio : Animal //class papaaio herda da class Animal
    {
        public Papagaio(string nome,int idade)
        :base(nome,idade){}

        public override void EmitirSom()
        {
            Console.WriteLine("Curupaco, (som do Papagaio)");
        }
        
    }
}