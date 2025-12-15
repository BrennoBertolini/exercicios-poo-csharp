using System;

// Exercício 1
public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }

    public Livro(string titulo, string autor)
    {
        Titulo = titulo;
        Autor = autor;
    }
}

// Exercício 2
public class Passagem
{
    public string Passageiro { get; set; }
    public string Destino { get; set; }

    public Passagem(string passageiro, string destino)
    {
        Passageiro = passageiro;
        Destino = destino;
    }
}

// Exercício 3
public class ContaBancaria
{
    public string NumeroConta { get; set; }
    public double Saldo { get; set; }

    public ContaBancaria(string numeroConta, double saldoInicial)
    {
        NumeroConta = numeroConta;
        Saldo = saldoInicial;
    }

    public void Depositar(double valor)
    {
        Saldo += valor;
    }
}

// Exercício 4
public class Funcionario
{
    public string Nome { get; set; }
    public string Cargo { get; set; }

    public Funcionario(string nome, string cargo)
    {
        Nome = nome;
        Cargo = cargo;
    }

    public void Promover(string novoCargo)
    {
        if (novoCargo != Cargo)
        {
            Cargo = novoCargo;
            Console.WriteLine("Promoção realizada com sucesso!");
        }
        else
        {
            Console.WriteLine("Erro: O novo cargo deve ser diferente do cargo atual.");
        }
    }
}

// Exercício 5
public class Retangulo
{
    public double Altura { get; set; }
    public double Largura { get; set; }

    public double CalcularArea()
    {
        return Altura * Largura;
    }
}

// Exercício 6
public class Filme
{
    public string Titulo { get; set; }
    public int ClassificacaoEtaria { get; set; }

    public Filme(string titulo, int classificacao)
    {
        Titulo = titulo;
        ClassificacaoEtaria = classificacao;
    }

    public bool PodeAssistir(int idadeUsuario)
    {
        return idadeUsuario >= ClassificacaoEtaria;
    }

    public void ExibirResultado(int idadeUsuario)
    {
        if (PodeAssistir(idadeUsuario))
            Console.WriteLine($"Usuário com {idadeUsuario} anos pode assistir ao filme {Titulo}.");
        else
            Console.WriteLine($"Usuário com {idadeUsuario} anos não pode assistir ao filme {Titulo}.");
    }
}

// Exercício 7
public class Produto
{
    public string Nome { get; set; }
    private int quantidadeEstoque;

    public Produto(string nome, int quantidadeInicial)
    {
        Nome = nome;
        quantidadeEstoque = quantidadeInicial;
    }

    public void Retirar(int quantidade)
    {
        if (quantidade <= quantidadeEstoque)
        {
            quantidadeEstoque -= quantidade;
            Console.WriteLine($"Retirada de {quantidade} unidades realizada com sucesso.");
        }
        else
        {
            Console.WriteLine($"Erro: Estoque insuficiente para retirada de {quantidade} unidades.");
        }
    }

    public void ExibirEstoque()
    {
        Console.WriteLine($"Produto: {Nome}");
        Console.WriteLine($"Estoque: {quantidadeEstoque}");
    }
}

// Exercício 8
public class Pedido
{
    public string NumeroPedido { get; set; }
    public string NomeCliente { get; set; }
    public string Status { get; set; }

    public Pedido(string numeroPedido, string nomeCliente, string status)
    {
        NumeroPedido = numeroPedido;
        NomeCliente = nomeCliente;
        Status = status;
    }

    public void AtualizarStatus(string novoStatus)
    {
        Status = novoStatus;
    }

    public void ExibirPedido()
    {
        Console.WriteLine($"Pedido nº {NumeroPedido}");
        Console.WriteLine($"Cliente: {NomeCliente}");
        Console.WriteLine($"Status: {Status}\n");
    }
}

// Exercício 9
public class Consulta
{
    public string NomePaciente { get; set; }
    public string NomeMedico { get; set; }
    public DateTime DataConsulta { get; set; }

    private bool foiReagendada;

    public Consulta(string paciente, string medico, DateTime data)
    {
        NomePaciente = paciente;
        NomeMedico = medico;
        DataConsulta = data;
    }

    public void Reagendar(DateTime novaData)
    {
        DataConsulta = novaData;
        foiReagendada = true;
    }

    public void ExibirResumo()
    {
        Console.WriteLine($"Consulta marcada com {NomeMedico} para o paciente {NomePaciente}.");
        Console.WriteLine(foiReagendada
            ? $"Nova data: {DataConsulta:dd/MM/yyyy}"
            : $"Data: {DataConsulta:dd/MM/yyyy}");
        Console.WriteLine();
    }
}

// Exercício 10
public class InformacaoTecnica
{
    public int TamanhoMB { get; set; }
    public string SistemaOperacional { get; set; }

    public InformacaoTecnica(int tamanhoMB, string sistemaOperacional)
    {
        TamanhoMB = tamanhoMB;
        SistemaOperacional = sistemaOperacional;
    }
}

public class ProdutoDigital
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public InformacaoTecnica InfoTecnica { get; set; }

    public ProdutoDigital(string nome, double preco, InformacaoTecnica info)
    {
        Nome = nome;
        Preco = preco;
        InfoTecnica = info;
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Produto: {Nome}");
        Console.WriteLine($"Preço: R$ {Preco:F2}");
        Console.WriteLine($"Tamanho: {InfoTecnica.TamanhoMB}MB");
        Console.WriteLine($"Compatível com: {InfoTecnica.SistemaOperacional}");
    }
}
