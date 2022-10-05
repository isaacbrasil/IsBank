class TestaGerente {

    static void Main(string[] args)
    {
        Gerente g = new Gerente("Lucas", 1232);
        Console.WriteLine("Salário: " + g.salario);

        Console.WriteLine("Aumentando o salário em 10% ");
        g.AumentaSalario();
        Console.WriteLine("Salário: " + g.salario);

        Console.WriteLine("Aumentando o salário em 30% ");
        g.AumentaSalario(0.3);
        Console.WriteLine("Salário: " + g.salario);

    }

}