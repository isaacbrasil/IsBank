class TestaMetodosConta
{
    static void Main()
    {
        Agencia a = new Agencia(1234);

        Conta origem = new Conta(a);
        origem.saldo = 1000;

        Conta destino = new Conta(a);
        destino.saldo = 1000;

        origem.Transfere(destino, 600);

        System.Console.WriteLine(origem.saldo);
        System.Console.WriteLine(destino.saldo);
    }
}