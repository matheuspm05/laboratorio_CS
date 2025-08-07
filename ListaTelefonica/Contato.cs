using System;

public class Contato
{
    public string Nome { get; set; }
    public string Numero { get; set; }

    public Contato(string nome, string numero)
    {
        Nome = nome;
        Numero = numero;
    }

    public override string ToString()
    {
        return $"{Nome}\n{Numero}";
    }
}
