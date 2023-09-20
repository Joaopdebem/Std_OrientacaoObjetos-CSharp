using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_RHeDP.Funcionarios
{
    public class GerenteDeContas:Funcionario
    {
        public GerenteDeContas(string cpf, string nome) : base(cpf, 4000, nome)
        {

        }
        public override double GetBonificacao()
        {
            return this.Salario * 1.25;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 0.5;
        }

    }
}
