using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Turma
    {
        public string Nome { get; set; }

        public Professor Professor { get; set; }

        public List<Aluno> Alunos { get; set; } = new List<Aluno>();

        public void MostrarTurma()
        {
            Console.WriteLine($"Turma: {Nome}");
            Console.WriteLine($"Professor: {Professor.Nome} - {Professor.Disciplina}");
            Console.WriteLine($"Alunos:");
            foreach (var aluno in Alunos)
            {
                Console.WriteLine($"- {aluno.Nome}");
            }
            Console.WriteLine("");

        }


    }
}