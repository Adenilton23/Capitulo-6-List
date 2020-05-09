using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Capitulo6_Listas1
{
    class Funcionarios
    {
        // Encapsulamento
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        // Construtor
        public Funcionarios(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        // Metodo Aumento Salario
        public void AumentoSal(double porcentagem)
        {
            Salario = Salario + (Salario *( porcentagem / 100.0));
        }      


        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario.ToString("F2",CultureInfo.InvariantCulture);
        }


    }
}
