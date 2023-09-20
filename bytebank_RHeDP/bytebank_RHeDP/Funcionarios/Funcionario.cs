using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_RHeDP.Funcionarios
{
    public abstract class  Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public static int TotalDeFuncionarios { get; private set; }

        public abstract double GetBonificacao();

        public Funcionario(string cpf, double salario, string nome)
        {
            this.Cpf = cpf;
            this.Salario = salario;
            this.Nome = nome;
            TotalDeFuncionarios++;
        }

        public abstract void AumentarSalario();

    }
}
