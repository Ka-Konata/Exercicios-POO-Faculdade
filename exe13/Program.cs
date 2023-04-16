using System;
using System.Linq.Expressions;

namespace Exe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lampada lampada = new Lampada(true);
            lampada.Imprimir();
            lampada.Desligar();
            lampada.Imprimir();
            lampada.Ligar();
            lampada.Imprimir();
        }
    }
}
