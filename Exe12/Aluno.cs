using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe1
{
    internal class Aluno
    {
        private Prova prova1;
        private Prova prova2;

        public Aluno(Prova p1, Prova p2)
        {
            SetProva1(p1);
            SetProva2(p2);
        }

        public double CalcularMedia()
        {
            return (this.prova1.CalcularNotaTotal() + this.prova2.CalcularNotaTotal()) / 2;
        }

        public void SetProva1(Prova prova1)
        {
            this.prova1 = prova1;
        }

        public Prova GetProva1()
        {
            return this.prova1;
        }

        public void SetProva2(Prova prova2)
        {
            this.prova2 = prova2;
        }

        public Prova GetProva2()
        {
            return this.prova2;
        }
    }
}
