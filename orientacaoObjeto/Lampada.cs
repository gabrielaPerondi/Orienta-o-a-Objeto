using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace orientacaoObjeto
{
    public class Lampada
    {
        public string Cor { get; set; }//atributo
        public int Potencia { get; set; }
        public string Marca { get; set; }
        public bool EstaLigada { get; set; }


        //CONSTRUTOR 
        public Lampada(string cor,int potencia,string marca){
            Cor=cor;
            Potencia=potencia;
            Marca=marca;
            EstaLigada=false;
        }

        public void Apresentar()
        {
            Console.WriteLine($"status:{EstaLigada}, Cor: {Cor}, Potencia: {Potencia}, Marca: {Marca}");
        }

        public void Ligar()
        {
            EstaLigada=true;
            Console.WriteLine("A lâmpada está ligada");
        }

        public void Desligar()
        {
            EstaLigada=false;
            Console.WriteLine("A lâmpada está desigada ");
        }
    }
}