using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe1
{
    class Nota : IComparable<Nota>
    {
        private string nome;
        private double valor;

        public Nota() { }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public void SetValor(double valor)
        {
            this.valor = valor;
        }

        public double GetValor()
        {
            return this.valor;
        }

        public bool Same(Nota n)
        {
            bool res = this.nome == n.nome;
            return res;
        }

        public int CompareTo(Nota n)
        {
            return this.nome.CompareTo(n.nome);
        }
    }
}