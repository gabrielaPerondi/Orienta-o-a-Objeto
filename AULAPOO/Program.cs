using System;
using Models;

namespace aulaPoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Professor = new Professor { Nome = "Thiago", Disciplina = "programação" };

            var aluno1 = new Aluno { Nome = "Gabi" };
            var aluno2 = new Aluno { Nome = "Vic" };
            var aluno3 = new Aluno { Nome = "Sara" };
            var aluno4 = new Aluno { Nome = "Nathy" };

            List<Aluno> alunos = new List<Aluno>();

            alunos.Add(aluno1);
            alunos.Add(aluno2);
            alunos.Add(aluno3);
            alunos.Add(aluno4);

            var Turma = new Turma { Nome = "Tecnico em Desenvolvimento de Sistemas", Professor = Professor, Alunos = alunos };

            foreach (var aluno in alunos)
            {
                aluno.Turma = Turma;
            }
            Turma.MostrarTurma();
            aluno1.Estudar();
            Professor.Ensinar();
        }
    }
}