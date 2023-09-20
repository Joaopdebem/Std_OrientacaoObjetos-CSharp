using bytebank_RHeDP.Funcionarios;
using bytebank_RHeDP.Utilitario;

class bytebank
{
    public static void Main()
    {
        Diretor isadora = new Diretor("99988877766", "Isadora");
        GerenteDeContas joao = new GerenteDeContas("22233344452", "João Pedro");
        Designer pedro = new Designer("66655544436", "Pedro");
        Auxiliar thomas = new Auxiliar("33344499952", "Thomas");

        InformacoesFuncionarios(isadora, joao, pedro, thomas);
        AplicarBonificacao(isadora, joao, pedro, thomas);
        //AumentoDeSalarioFuncionarios(joao, isadora);
        Console.ReadLine();
    }

    static void InformacoesFuncionarios(Diretor isadora, GerenteDeContas joao, Designer pedro, Auxiliar thomas)
    {
        Console.WriteLine("\nNome: " + isadora.Nome);
        Console.WriteLine("Salário: " + isadora.Salario);
        Console.WriteLine("CPF: '" + isadora.Cpf + "'\n");

        Console.WriteLine("Nome: " + joao.Nome);
        Console.WriteLine("Salário: " + joao.Salario);
        Console.WriteLine("CPF: '" + joao.Cpf + "'\n");

        Console.WriteLine("Nome: " + pedro.Nome);
        Console.WriteLine("Salário: " + pedro.Salario);
        Console.WriteLine("CPF: '" + pedro.Cpf + "'\n");

        Console.WriteLine("Nome: " + thomas.Nome);
        Console.WriteLine("Salário: " + thomas.Salario);
        Console.WriteLine("CPF: '" + thomas.Cpf + "'\n");
    }

    static void AplicarBonificacao(Diretor isadora, GerenteDeContas joao, Designer pedro, Auxiliar thomas)
    {
        GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
        
        gerenciador.Registrar(isadora);
        gerenciador.Registrar(joao);
        gerenciador.Registrar(pedro);
        gerenciador.Registrar(thomas);

        Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);
        Console.WriteLine("Total de Funcionários: " + Funcionario.TotalDeFuncionarios);
    }

    /*static void AumentoDeSalarioFuncionarios(Funcionario jose, Diretor isadora, GerenteDeContas joao, Designer pedro, Auxiliar thomas)
    {
        jose.AumentarSalario();
        isadora.AumentarSalario();

        Console.WriteLine($"Novo salário do Joao: {jose.Salario}");
        Console.WriteLine($"Novo salário da Isadora: {isadora.Salario}");
    }*/
}