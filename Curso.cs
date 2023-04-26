using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe1
{
    class Curso
    {
        private string nome;
        private string codigo;

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public void SetCodigo(string codigo)
        {
            this.codigo = codigo;
        }

        public string GetCodigo()
        {
            return this.codigo;
        }
    }
}