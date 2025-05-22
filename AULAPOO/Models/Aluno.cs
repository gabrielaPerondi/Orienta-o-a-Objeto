using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Aluno
    {
        public string Nome { get; set; }//ATRIBUTOS

        public int Idade { get; set; }//ATRIBUTOS

        public Turma Turma { get; set; }//ATRIBUTOS

        public void Estudar()//METODOS
        {
            Console.WriteLine($"{Nome} está estudando.\n");
        }
        
    }
}