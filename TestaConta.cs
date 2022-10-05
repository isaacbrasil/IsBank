class TestaConta
{

    static void Main(string[] args)
    {
        Agencia a = new Agencia(1234);
        Agencia b = new Agencia(5678);
        Conta c = new Conta(a);
        Conta cDestino = new Conta(b);


        Console.WriteLine("Insira o nº da sua conta");
        int numero = Convert.ToInt32(Console.ReadLine());
        c.numero = numero;

        Console.WriteLine("Insira o saldo da conta");
        double saldo = Convert.ToDouble(Console.ReadLine());
        c.saldo = saldo;


        Console.WriteLine("Defina o limite da conta");
        double limite = Convert.ToDouble(Console.ReadLine());
        c.limite = limite;

        int opc = 1;
        while (opc != 0)
        {
            System.Console.WriteLine("------------------------------------------------------------");
            System.Console.WriteLine("Bem Vindo ao IsBank! Digite a operação que deseja realizar: ");
            System.Console.WriteLine("1 - Efetuar Depósito ");
            System.Console.WriteLine("2 - Saque ");
            System.Console.WriteLine("3 - Imprimir Extrato ");
            System.Console.WriteLine("4 - Transferência Bancária ");
            System.Console.WriteLine("5 - Consultar informações bancárias ");
            System.Console.WriteLine("0 - Sair:");
            System.Console.WriteLine("------------------------------------------------------------");






            TextReader textReader = Console.In;
            string valorTela = textReader.ReadLine();
            opc = Convert.ToInt32(valorTela);

            if (opc == 1)
            {
                Console.WriteLine("Quanto você quer depositar ?");
                double valorDeposito = Convert.ToDouble(Console.ReadLine());
                c.Deposita(valorDeposito);
                Console.WriteLine("Seu saldo agora é de: " + c.saldo);


            }
            else if (opc == 2)
            {
                Console.WriteLine("Quanto você quer sacar ?");
                double valorSaque = Convert.ToDouble(Console.ReadLine());
                if (valorSaque > c.saldo)
                {
                    c.MensagemSaldoInsuficiente();

                }
                else
                {
                    c.Saca(valorSaque);
                    c.MensagemSucesso();
                }
                c.ImprimeExtrato();
            }
            else if (opc == 3)
            {
                c.ImprimeExtrato();
            }
            else if (opc == 4)
            {
                c.ImprimeExtrato();
                Console.WriteLine("Insira o nº da conta destino: ");
                int nroContaDestino = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Qual valor você quer transferir?");
                double valorTransferencia = Convert.ToDouble(Console.ReadLine());
                if (valorTransferencia > c.saldo)
                {
                    c.MensagemSaldoInsuficiente();
                }
                else
                {
                    c.Transfere(cDestino, valorTransferencia);
                    c.MensagemSucesso();
                }
                c.ImprimeExtrato();

            }
            else if (opc == 5)
            {
                Console.WriteLine("Nº da sua conta: ");
                Console.WriteLine(c.numero);
                Console.WriteLine("Nº da sua agencia: ");
                Console.WriteLine(c.agencia.numero);

            }
        }
    }
}