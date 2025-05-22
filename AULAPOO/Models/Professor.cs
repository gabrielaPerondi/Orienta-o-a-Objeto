using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Professor
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public Turma Turma { get; set; }

        public string Disciplina { get; set; }


        public void Ensinar()
        {
            Console.WriteLine($"{Nome} está lecionando\n");
        }
        
    }
}