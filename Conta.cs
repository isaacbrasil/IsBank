class Conta
{
    public int numero;
    public double saldo;
    public double limite;
    public Agencia agencia;

    public Conta(Agencia agencia)
    {
        this.agencia = agencia;

    }
    public void Deposita(double valor)
    {
        this.saldo += valor;
    }

    public void Saca(double valor)
    {
        this.saldo -= valor;
    }

    public void ImprimeExtrato()
    {
        System.Console.WriteLine(" SALDO : " + this.saldo);
    }

    public double ConsultaSaldoDisponivel()
    {
        return this.saldo + this.limite;
    }

    public void Transfere(Conta destino, double valor)
    {
        this.saldo -= valor;
        destino.saldo += valor;
    }

    public void MensagemSaldoInsuficiente()
    {
        Console.WriteLine("Você não tem saldo suficiente!");

    }
    public void MensagemSucesso()
    {
        Console.WriteLine("Operação Realizada com sucesso!");

    }
}
