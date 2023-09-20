using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_RHeDP.Funcionarios
{
    public class Diretor:Funcionario
    {
        public override double GetBonificacao()
        {
            return this.Salario * 1.5;
        }

        public Diretor(string cpf, string nome):base(cpf, 5000, nome)
        {
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

    }
}
