using System;
using orientacaoObjeto;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lampada lampada=new Lampada("Amarelo", 22, "Intral");//Instanciar uma classe:CRIAR UM OBJETO. Para fazer isso,usa new seguido do nome da classe e argumentos para o construtor.
            // lampada.Ligar();
            // lampada.Apresentar();

            Animal[] animais=new Animal[]
            {
                new Lobo("Lobo Cinzento", 5),
                new Tigre("Tigre de Bengala", 4),
                new Papagaio("Louro José", 2),
            };

            foreach (var animal in animais)
            {
                Console.WriteLine(animal);
                animal.EmitirSom();
                Console.WriteLine();
                
            }
        }
    }
}    

//ORIENTACAO EM OBJETO É UM PARADIGMA DE PROGRAMAÇÃO