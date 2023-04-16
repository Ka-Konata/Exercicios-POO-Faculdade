using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe1
{
    internal class Prova
    {
        private double notaParte1;
        private double notaParte2;

        public Prova(double nota1, double nota2)
        {
            SetNotaParte1(nota1);
            SetNotaParte2(nota2);
        }

        public double CalcularNotaTotal()
        {
            double notaTotal = this.notaParte1 + this.notaParte2;
            if(notaTotal <= 10)
            {
                return notaTotal;
            }
            return 10f;
        }

        public void SetNotaParte1(double nota)
        {
            this.notaParte1 = nota;
        }

        public double GetNotaParte1()
        {
            return this.notaParte1;
        }

        public void SetNotaParte2(double nota)
        {
            this.notaParte2 = nota;
        }

        public double GetNotaParte2()
        {
            return this.notaParte2;
        }

    }
}
