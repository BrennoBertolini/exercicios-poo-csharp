/* class Livro
{
    public string titulo;
    public string autor;
} */

/* class Passagem
{
    public string Passageiro { get; set; }
    public string Destino { get; set; }

    public Passagem(string passageiro, string destino)
    {
        Passageiro = passageiro;
        Destino = destino;
    }
} */

class ContaBancaria
{
    public string NumeroConta;
    public double Saldo;

    public ContaBancaria(string numeroConta, double saldoInicial)
    {
        NumeroConta = numeroConta;
        Saldo = saldoInicial;
    }
    public double Depositar(double valor)
            {
        Saldo += valor;
    }
    
}

