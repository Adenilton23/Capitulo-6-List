using System;
using System.Collections.Generic;
using System.Globalization;

namespace Capitulo6_Listas1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionarios> list = new List<Funcionarios>();


            Console.Write("QUANTOS FUNCIONARIOS SERÃO REGISTRADOS: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Funcionario #" + i + ":");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionarios(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Id do Funcionario Aumento: ");
            int pesq_id = int.Parse(Console.ReadLine());
            
            Funcionarios func = list.Find(x => x.Id == pesq_id);
            if (func != null)
            {
                Console.Write("Qual a porcetagem de aumento: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.AumentoSal(porcentagem);
            }
            else
            {
                Console.WriteLine("Essa id não existe");
            }

            Console.WriteLine();
            Console.WriteLine("LISTA ATUALIZADA");

            foreach (Funcionarios obj in list)
            {
                Console.WriteLine(obj);
            }



        }
    }
}
