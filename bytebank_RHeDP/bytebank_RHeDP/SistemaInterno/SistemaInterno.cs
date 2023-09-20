using bytebank_RHeDP.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_RHeDP.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(Funcionario funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Usuário autenticado com sucesso!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }


        }


    }
}
