using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace orientacaoObjeto
{
    public class Aviao
    {
        public string Modelo { get; set; }
        public int Velocidade { get; set; }
        public int Altitude { get; set; }
        public string Marca { get; set; }

        public Aviao(string modelo,int velocidade,int altitude,string marca)
        {
            Modelo=modelo;
            Velocidade=velocidade;
            Altitude=altitude;
            Marca=marca;
        }

        public  virtual void Reduzir()
        {
            Console.WriteLine($"O aviao de modelo {modelo} esta redindo a uma velocidade de {velocidade} ");
        }

        public virtual void Acelerar()
        {
            Console.WriteLine($"O aviao de modelo {modelo} esta acelerando a uma velocidade de {velocidade} ");
        }
        public virtual void Subir()
        {
            Console.WriteLine($"O aviao de modelo {modelo} esta decolando ");
        }
        public virtual void Descer()
        {
            Console.WriteLine($"O aviao de modelo {modelo} esta aterissando a uma altitude de {atitude} ");
        }

    }
}