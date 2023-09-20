using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.Titular;

namespace bytebank.Contas
{
    public class ContaCorrente
    {

        public static int TotalDeContasCriadas { get; private set; }

        private int numero_agencia;
        private string conta;
        private double saldo;

        public Cliente Titular { get; set; }
        public int Numero_agencia
        {
            get { return this.numero_agencia; }
            private set           
            {
                if (value > 0)
                {
                    this.numero_agencia = value;
                }
                else
                {
                    return;
                }
            }
        }
        public string Conta
        {
            get { return this.conta; }
            set
            {
                if (value != "")
                {
                    this.conta = value;
                }
                else
                {
                    return;
                }
            }
        }
        public double Saldo
        {
            get { return this.saldo; }
            set
            {
                if (value > 0)
                {
                    this.saldo = value;
                }
                else
                {
                    return;
                }
            }
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }

        public void ExibirDadosConta()
        {
            Console.WriteLine("Titular da conta: " + Titular.Nome);
            Console.WriteLine("CPF: " + Titular.Cpf);
            Console.WriteLine("Profissão: " + Titular.Profissao);
            Console.WriteLine("Número da conta: " + conta);
            Console.WriteLine("Agência: " + numero_agencia);
            Console.WriteLine("Saldo R$" + saldo);
        }

        public ContaCorrente(int numero_agencia, string conta)
        {
            this.Numero_agencia = numero_agencia;
            this.Conta = conta;
            TotalDeContasCriadas++;
        }


    }
}
