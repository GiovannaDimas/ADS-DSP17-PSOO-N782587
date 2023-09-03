class Aluno
{
    protected string nome;
    private string ra;

    public Aluno(string nome, string ra)
    {
        this.nome = nome;
        this.ra = ra;
    }

    public void ValidarRA(string ra)
    {
        if (this.ra.Equals(ra))
        {
            Console.WriteLine("Nome do aluno: " + nome);
        }
        else
        {
            Console.WriteLine("Esta matrícula não corresponde ao aluno.");
        }
    }
}

class AlunoValidacao : Aluno
{
    private DateTime dataValidacao;

    public AlunoValidacao(string nome, string ra) : base(nome, ra)
    {
        dataValidacao = DateTime.Now;
    }

    public void MostrarDataValidacao()
    {
        Console.WriteLine("Data de validação: " + dataValidacao);
    }
}

class Program
{
    static void Main(string[] args)
    {
        AlunoValidacao aluno = new AlunoValidacao("Giovanna Dimas", "N782587");

        Console.Write("Digite o RA: ");
        string raDigitado = Console.ReadLine();

        
        if (raDigitado != "")
        {
            aluno.ValidarRA(raDigitado);
            aluno.MostrarDataValidacao();
        }
        else
        {
            Console.WriteLine("RA não digitado.");
        }
    }
}


