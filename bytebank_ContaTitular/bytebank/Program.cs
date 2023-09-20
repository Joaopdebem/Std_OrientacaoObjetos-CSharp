using System.Threading;
using bytebank.Contas;
using bytebank.Titular;

Console.WriteLine("----------------------------------01º Conta----------------------------------");
ContaCorrente contaDoJoao = new ContaCorrente(15, "1010-X")
{
    Titular = new Cliente("João Pedro", "12345678900", "Analista"),
    Saldo = 500
};
contaDoJoao.ExibirDadosConta();

Console.WriteLine("----------------------------------02º Conta----------------------------------");
ContaCorrente contaDoJoao2 = new ContaCorrente(15, "1010-X")
{
    Titular = new Cliente("João Pedro", "12345678900", "Analista"),
    Saldo = 500
};
contaDoJoao2.ExibirDadosConta();

Console.WriteLine("----------------------------------03º Conta----------------------------------");
ContaCorrente contaDaIsadora = new ContaCorrente(11, "3330-D")
{
    Titular = new Cliente("Isadora de Sá", "98765432199", "Enfermeira"),
    Saldo = 300
};
contaDaIsadora.ExibirDadosConta();

Console.WriteLine("----------------------------------04º Conta----------------------------------");
ContaCorrente contaDoPedro = new ContaCorrente(15, "1010-X")
{
    Titular = new Cliente("Pedro de Bem", "11224455667", "Auxiliar"),
    Saldo = 200
};
contaDoPedro.ExibirDadosConta();

Console.WriteLine("--------------------------------Movimentações--------------------------------");
Console.WriteLine($"##### {contaDoJoao.Titular.Nome} realiza o depósito de R$100 reais.");
Thread.Sleep(500);
contaDoJoao.Depositar(200);
Console.WriteLine($"-- Depósito efetuado. \n-- Novo Saldo de {contaDoJoao.Titular.Nome} é R${contaDoJoao.Saldo}\n");

Console.WriteLine($"##### {contaDoJoao.Titular.Nome} realiza o saque de R$50 reais.");
Thread.Sleep(500);
if (contaDoJoao.Sacar(50) == true)
{
    Console.WriteLine($"-- Saque realizado. \n-- Novo Saldo de {contaDoJoao.Titular.Nome} é R${contaDoJoao.Saldo} \n");
}
else
{
    Console.WriteLine($"-- Saldo de {contaDoJoao.Titular.Nome} insuficiente. \n");
}

Console.WriteLine($"##### {contaDoJoao.Titular.Nome} irá transferir R$100 reais para {contaDaIsadora.Titular.Nome}.");
contaDoJoao.Transferir(100, contaDaIsadora);
Thread.Sleep(500);
Console.WriteLine($"-- Transferência realizada. \n-- O novo Saldo de {contaDoJoao.Titular.Nome} é {contaDoJoao.Saldo} e o de {contaDaIsadora.Titular.Nome} é R${contaDaIsadora.Saldo}\n\n");

Console.WriteLine($"##### A conta 1 do {contaDoJoao.Titular.Nome} é igual a sua conta 2?\n");

if (contaDoJoao == contaDoJoao2)
{
    Console.WriteLine("-- Sim\n");
}
else
{
    Console.WriteLine("-- Não\n");
}

Console.WriteLine("*** A conta 1 mesmo com todos campos iguais não é igual a conta 2, porque ocupam diferentes espaços na memória");
Console.WriteLine("*** Somente se a uma das contas apontasse para outra ai a comparação seria verdadeira, exemplo: contaDoJoao = contaDoJoao\n\n\n");

Console.WriteLine(new string('=', 120));
Console.ReadLine();




