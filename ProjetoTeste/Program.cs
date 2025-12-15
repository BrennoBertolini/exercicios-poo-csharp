using System;

class Program
{
    static void Main(string[] args)
    {
        // Execute apenas UM exercício por vez
        // Descomente o método desejado

        ExecutarLivro();
        // ExecutarPassagem();
        // ExecutarContaBancaria();
        // ExecutarFuncionario();
        // ExecutarRetangulo();
        // ExecutarFilme();
        // ExecutarProduto();
        // ExecutarPedido();
        // ExecutarConsulta();
        // ExecutarProdutoDigital();
    }

    // Exercício 1 - Livro
    static void ExecutarLivro()
    {
        Livro livro = new Livro("Dom Casmurro", "Machado de Assis");
        Console.WriteLine($"Livro: {livro.Titulo}");
        Console.WriteLine($"Autor: {livro.Autor}");
    }

    // Exercício 2 - Passagem
    static void ExecutarPassagem()
    {
        Passagem passagem = new Passagem("Lucas Souza", "Paris");
        Console.WriteLine($"Passageiro: {passagem.Passageiro}");
        Console.WriteLine($"Destino: {passagem.Destino}");
    }

    // Exercício 3 - Conta Bancária
    static void ExecutarContaBancaria()
    {
        ContaBancaria conta = new ContaBancaria("78901-2", 1000.00);
        Console.WriteLine($"Conta: {conta.NumeroConta}");
        Console.WriteLine($"Saldo atual: R$ {conta.Saldo:F2}");
        conta.Depositar(500.00);
        Console.WriteLine($"Saldo após depósito: R$ {conta.Saldo:F2}");
    }

    // Exercício 4 - Funcionário
    static void ExecutarFuncionario()
    {
        Funcionario funcionario = new Funcionario("Carlos Pereira", "Assistente Administrativo");

        Console.WriteLine($"Funcionário: {funcionario.Nome}");
        Console.WriteLine($"Cargo Atual: {funcionario.Cargo}");

        funcionario.Promover("Assistente Administrativo"); // inválido
        funcionario.Promover("Analista de Projetos");       // válido

        Console.WriteLine("\n--- Após promoção ---");
        Console.WriteLine($"Funcionário: {funcionario.Nome}");
        Console.WriteLine($"Cargo Atual: {funcionario.Cargo}");
    }

    // Exercício 5 - Retângulo
    static void ExecutarRetangulo()
    {
        Retangulo retangulo = new Retangulo
        {
            Altura = 5,
            Largura = 8
        };

        Console.WriteLine($"Área do Retângulo: {retangulo.CalcularArea()}");
    }

    // Exercício 6 - Filme
    static void ExecutarFilme()
    {
        Filme filme = new Filme("Matrix", 16);
        filme.ExibirResultado(14);
        filme.ExibirResultado(20);
    }

    // Exercício 7 - Produto (Estoque)
    static void ExecutarProduto()
    {
        Produto produto = new Produto("Caneta Azul", 20);
        produto.Retirar(5);
        produto.ExibirEstoque();
        produto.Retirar(30);
    }

    // Exercício 8 - Pedido
    static void ExecutarPedido()
    {
        Pedido pedido = new Pedido("001", "Ana Silva", "Pendente");
        pedido.ExibirPedido();
        pedido.AtualizarStatus("Enviado");
        pedido.ExibirPedido();
    }

    // Exercício 9 - Consulta
    static void ExecutarConsulta()
    {
        Consulta consulta = new Consulta("João Lima", "Dra. Renata", new DateTime(2025, 5, 20));
        consulta.ExibirResumo();
        consulta.Reagendar(new DateTime(2025, 5, 25));
        consulta.ExibirResumo();
    }

    // Exercício 10 - Produto Digital
    static void ExecutarProdutoDigital()
    {
        InformacaoTecnica info = new InformacaoTecnica(1500, "Windows/Mac");
        ProdutoDigital produto = new ProdutoDigital("Photoshop", 89.99, info);
        produto.ExibirDetalhes();
    }
}
