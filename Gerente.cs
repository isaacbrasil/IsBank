class Gerente
{
    public String nome;
    public double salario;

    public Gerente(string nome, double salario)
    {
        this.nome = nome;
        this.salario = salario;
    }

    public void AumentaSalario()
    {
        this.AumentaSalario(0.1);
    }
    public void AumentaSalario(double taxa)
    {
        this.salario += this.salario * taxa;
    }
}