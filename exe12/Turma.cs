using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe1
{
    internal class Turma
    {
        private Aluno aluno1;
        private Aluno aluno2;
        private Aluno aluno3;

        public Turma(Aluno a1, Aluno a2, Aluno a3)
        {
            SetAluno1(a1);
            SetAluno2(a2);
            SetAluno3(a3);
        }

        public double CalcularMedia()
        {
            return (aluno1.CalcularMedia() + aluno2.CalcularMedia() + aluno3.CalcularMedia()) / 3;
        }

        public void SetAluno1(Aluno aluno1)
        {
            this.aluno1 = aluno1;
        }

        public Aluno GetAluno1()
        {
            return this.aluno1;
        }

        public void SetAluno2(Aluno aluno2)
        {
            this.aluno2 = aluno2;
        }

        public Aluno GetAluno2()
        {
            return this.aluno2;
        }

        public void SetAluno3(Aluno aluno3)
        {
            this.aluno3 = aluno3;
        }

        public Aluno GetAluno3()
        {
            return this.aluno3;
        }
    }
}
