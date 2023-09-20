using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_RHeDP.Funcionarios
{
    public class Auxiliar:Funcionario
    {
        public override double GetBonificacao()
        {
            return this.Salario * 1.20;
        }

        public Auxiliar(string cpf, string nome) : base(cpf, 2000, nome)
        {

        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.10;
        }

    }
}
