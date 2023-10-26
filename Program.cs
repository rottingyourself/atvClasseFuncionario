using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atvClasseFuncionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Marcio Tecnologias";
            string email = "marcio@ti.com";
            int idade = 23;
            string setor = "TI";
            double salario = 5000;

            Funcionario funcionario = new Funcionario(nome, email, idade, setor, salario);

            Console.WriteLine(funcionario.RetornarTodasInformacoes());
            Console.WriteLine($"Salário Líquido: R$ {funcionario.CalcDescontoSalario():F2}");

           Console.ReadKey();
        }
    }
}