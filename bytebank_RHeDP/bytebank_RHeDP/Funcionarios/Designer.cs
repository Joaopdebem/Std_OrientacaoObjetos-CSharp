using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_RHeDP.Funcionarios
{
    public class Designer:Funcionario
    {
        public override double GetBonificacao()
        {
            return this.Salario * 1.17;
        }

        public Designer(string cpf, string nome) : base(cpf, 3000, nome)
        {

        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.11;
        }

    }
}
