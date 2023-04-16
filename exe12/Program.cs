using System;

namespace Exe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prova Prova1Aluno1 = new Prova(4.0f, 2.5f);
            Prova Prova2Aluno1 = new Prova(1.0f, 7.1f);
            Aluno aluno1 = new Aluno(Prova1Aluno1, Prova2Aluno1);

            Prova Prova1Aluno2 = new Prova(6.5f, 3.5f);
            Prova Prova2Aluno2 = new Prova(0.0f, 3.0f);
            Aluno aluno2 = new Aluno(Prova1Aluno2, Prova2Aluno2);

            Prova Prova1Aluno3 = new Prova(5.0f, 4.0f);
            Prova Prova2Aluno3 = new Prova(6.0f, 1.5f);
            Aluno aluno3 = new Aluno(Prova1Aluno3, Prova2Aluno3);

            Turma turma = new Turma(aluno1, aluno2, aluno3);

            Console.WriteLine("Aluno 1. Média: " + aluno1.CalcularMedia());
            Console.WriteLine("Aluno 2. Média: " + aluno2.CalcularMedia());
            Console.WriteLine("Aluno 3. Média: " + aluno3.CalcularMedia());
            Console.WriteLine("Média da Turma: " + turma.CalcularMedia());
        }
    }
}
