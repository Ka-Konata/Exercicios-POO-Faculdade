using Exe1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe1
{
    class Secretaria : ISecretaria
    {
        private List<Aluno> alunos = new List<Aluno>();

        public Secretaria() { }

        public void Add()
        {
            Aluno  aluno = new Aluno();
            Nota notaNP1 = new Nota();
            Nota notaNP2 = new Nota();
            Nota notaPIM = new Nota();
            Curso  curso = new Curso();

            Console.Write("\nInsira o nome do aluno: ");
            aluno.SetNome(Console.ReadLine());
            Console.Write("Insira a matricula do aluno: ");
            aluno.SetMatricula(Console.ReadLine());
            Console.Write("Insira o nome do curso do aluno: ");
            curso.SetNome(Console.ReadLine());
            Console.Write("Insira o código do curso do aluno: ");
            curso.SetCodigo(Console.ReadLine());

            Console.Write("Insira a nota da NP1: ");
            notaNP1.SetValor(Convert.ToDouble(Console.ReadLine()));
            notaNP1.SetNome("NP1");
            Console.Write("Insira a nota da NP2: ");
            notaNP2.SetNome("NP2");
            notaNP2.SetValor(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Insira a nota do PIM: ");
            notaPIM.SetNome("PIM");
            notaPIM.SetValor(Convert.ToDouble(Console.ReadLine()));

            aluno.SetCurso(curso);
            aluno.InserirNota(notaNP1);
            aluno.InserirNota(notaNP2);
            aluno.InserirNota(notaPIM);
            this.alunos.Add(aluno);
        }

        public void Edit()
        {
            Aluno aluno;
            Nota novaNotaNP1;
            Nota novaNotaNP2;
            Nota novaNotaPIM;

            Console.Write("\nInsira a matrícula do aluno: ");
            string matricula = Console.ReadLine();
            aluno = alunos.Find(a => a.GetMatricula().Equals(matricula));

            if (aluno == null)
            {
                Console.WriteLine("Aluno não encontrado");
            }

            else
            {

                Console.Write("\nAltere o nome do aluno: ");
                aluno.SetNome(Console.ReadLine());
                Console.Write("Altere a matricula do aluno: ");
                aluno.SetMatricula(Console.ReadLine());
                Console.Write("Altere o nome do curso do aluno: ");
                aluno.GetCurso().SetNome(Console.ReadLine());
                Console.Write("Altere o código do curso do aluno: ");
                aluno.GetCurso().SetCodigo(Console.ReadLine());

                novaNotaNP1 = aluno.GetNotas()[0];
                novaNotaNP2 = aluno.GetNotas()[1];
                novaNotaPIM = aluno.GetNotas()[2];

                Console.Write("Altere a nota da NP1: ");
                novaNotaNP1.SetValor(Convert.ToDouble(Console.ReadLine()));
                novaNotaNP1.SetNome("NP1");
                Console.Write("Altere a nota da NP2: ");
                novaNotaNP2.SetNome("NP2");
                novaNotaNP2.SetValor(Convert.ToDouble(Console.ReadLine()));
                Console.Write("Altere a nota do PIM: ");
                novaNotaPIM.SetNome("PIM");
                novaNotaPIM.SetValor(Convert.ToDouble(Console.ReadLine()));
            }
        }

        public void List()
        {
            List<Nota> notas;
            double media;
            string situacao;
            foreach (Aluno aluno in this.alunos)
            {
                Console.WriteLine("\nNOME: \t\t" + aluno.GetNome());
                Console.WriteLine("MATRÍCULA: \t" + aluno.GetMatricula());
                Console.WriteLine("CURSO: \t\t" + aluno.GetCurso().GetCodigo());
                Console.WriteLine("CÓDIGO: \t" + aluno.GetCurso().GetNome());

                foreach (Nota nota in aluno.GetNotas())
                {
                    Console.WriteLine(nota.GetNome() + ": \t\t" + nota.GetValor());
                }

                notas = aluno.GetNotas();
                media = (((notas[0].GetValor() * 4) + (notas[1].GetValor() * 4) + (notas[2].GetValor() * 2)) / 10);
                situacao = media >= 5 ? " (aprovado)" : " (reprovado)";
                Console.WriteLine("MÉDIA FINAL: \t" + media + situacao);
            }
        }

        public void Remove()
        {
            Console.Write("Insira a matrícula do aluno: ");
            string matricula = Console.ReadLine();
            Aluno aluno = alunos.Find(a => a.GetMatricula().Equals(matricula));

            if(aluno == null)
            {
                Console.WriteLine("Aluno não encontrado");
            }

            else
            {
                alunos.Remove(aluno);
                Console.WriteLine("Aluno excluído com sucesso");
            }
        }
    }
}