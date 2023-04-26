using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Secretaria secretaria = new Secretaria();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Selecione uma opção: ");
                Console.WriteLine("1 - Adicionar aluno");
                Console.WriteLine("2 - Listar alunos");
                Console.WriteLine("3 - Editar aluno");
                Console.WriteLine("4 - Excluir aluno");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha: ");
                string res = Console.ReadLine();

                switch (res)
                {
                    case "1":
                        secretaria.Add();
                        break;
                    case "2":
                        secretaria.List();
                        break;
                    case "3":;
                        secretaria.Edit();
                        break;
                    case "4":
                        secretaria.Remove();
                        break;
                    case "5":
                        return;
                }

            }
        }
    }
}
