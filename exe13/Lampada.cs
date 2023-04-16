using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe1
{
    internal class Lampada
    {
        private bool ligada;

        public Lampada(bool ligada)
        {
            this.ligada = ligada;
        }

        public void Imprimir()
        {
            if (ligada)
            {
                Console.WriteLine("Lâmpada ligada");
            }
            else
            {
                Console.WriteLine("Lâmpada desligada");
            }
        }

        public void Ligar()
        {
            SetLigada(true);
        }

        public void Desligar()
        {
            SetLigada(false);
        }

        public void SetLigada(bool ligada)
        {
            this.ligada = ligada;
        }

        public bool GetLigada()
        {
            return this.ligada;
        }
    }
}
