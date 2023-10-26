using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atvClasseFuncionario
{
    public class Funcionario
    {
        // Atributos:
        private string Nome { get; set; }
        private string Email { get; set; }
        private int Idade { get; set; }
        private string Setor { get; set; }
        private DateTime DataContratacao { get; set; }
        private double Salario { get; set; }

        // Construtor:
        public Funcionario(string nome, string email, int idade, string setor, double salario)
        {
            // Inicializar os valores:
            Email = email;
            Idade = idade;
            Setor = setor;
            DataContratacao = DateTime.Now;
            Salario = salario;
            Nome = nome;
        }
        // Retornar Infos funcionário:
        public string RetornarTodasInformacoes()
        {
            return $"Nome: {Nome}\n" +
            $"Email: {Email}\n" +
            $"Idade: {Idade}\n" +
            $"Setor: {Setor}\n" +
            $"Data de Contratação: {DataContratacao:dd/MM/yyyy}\n" +
            $"Salário Bruto: R$ {Salario:F2}";
        }
        // Reduz o salário em 20%
        public double CalcDescontoSalario()
        {
            return Salario * 0.8;
        }
    }
}
