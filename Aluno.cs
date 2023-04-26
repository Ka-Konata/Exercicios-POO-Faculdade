using Exe1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exe1
{
    class Aluno : IComparable<Aluno>
    {
        private string nome;
        private string matricula;
        private Curso curso;
        private List<Nota> notas = new List<Nota>();
        public Aluno()
        {

        }

        public List<Nota> GetNotas()
        {
            return this.notas;
        }

        public void InserirNota(Nota nota)
        {
            this.notas.Add(nota);
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return this.nome;
        }
        
        public void SetMatricula(string matricula)
        {
            this.matricula = matricula;
        }

        public string GetMatricula()
        {
            return this.matricula;
        }

        public void SetCurso(Curso curso)
        {
            this.curso = curso;
        }

        public Curso GetCurso()
        {
            return this.curso;
        }

        public int CompareTo(Aluno a)
        {
            return matricula.CompareTo(a.matricula);
        }
    }
}