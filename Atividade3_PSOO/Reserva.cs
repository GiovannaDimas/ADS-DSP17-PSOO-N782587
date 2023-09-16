using System;
using System.Collections.Generic;

class Passageiro
{
    public string Nome { get; set; }
    public string NumeroPassaporte { get; set; }

    public void ReservarVoo(string destino)
    {
        Console.WriteLine($"Reservando voo para {destino} para o passageiro {Nome}");
    }

    public void CancelarReserva()
    {
        Console.WriteLine($"Cancelando reserva para o passageiro {Nome}");
    }
}

class Voo
{
    public string NumeroVoo { get; set; }
    public string Destino { get; set; }
    private bool Reservado { get; set; }

    public Voo(string numeroVoo, string destino)
    {
        NumeroVoo = numeroVoo;
        Destino = destino;
        Reservado = false;
    }

    public bool Disponibilidade()
    {
        return !Reservado;
    }

    public void Reservar()
    {
        if (Disponibilidade())
        {
            Reservado = true;
            Console.WriteLine($"Voo {NumeroVoo} para {Destino} foi reservado.");
        }
        else
        {
            Console.WriteLine($"Desculpe, o voo {NumeroVoo} para {Destino} não está disponível.");
        }
    }

    public void CancelarReserva()
    {
        Reservado = false;
        Console.WriteLine($"Reserva do voo {NumeroVoo} para {Destino} foi cancelada.");
    }
}

class CompanhiaAerea
{
    private List<Voo> listaDeVoos = new List<Voo>();

    public Voo AdicionarVoo(string numeroVoo, string destino)
    {
        Voo novoVoo = new Voo(numeroVoo, destino);
        listaDeVoos.Add(novoVoo);
        return novoVoo;
    }

    public void RemoverVoo(Voo voo)
    {
        listaDeVoos.Remove(voo);
    }

    public List<Voo> ListarVoos()
    {
        return listaDeVoos;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Passageiro passageiro1 = new Passageiro { Nome = "João", NumeroPassaporte = "AB123456" };
        Passageiro passageiro2 = new Passageiro { Nome = "Maria", NumeroPassaporte = "CD789012" };

        CompanhiaAérea companhiaAérea = new CompanhiaAérea();

        Voo voo1 = companhiaAérea.AdicionarVoo("V123", "Nova York");
        Voo voo2 = companhiaAérea.AdicionarVoo("V456", "Londres");

        passageiro1.ReservarVoo("Nova York");
        voo1.Reservar();

        passageiro2.ReservarVoo("Londres");
        voo2.Reservar();

        passageiro1.CancelarReserva();
        voo1.CancelarReserva();

        passageiro2.CancelarReserva();
        voo2.CancelarReserva();
    }
}
