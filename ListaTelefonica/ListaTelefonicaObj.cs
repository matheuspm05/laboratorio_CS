public class ListaTelefonicaObj
{
    Dictionary<string, Contato> Lista = new Dictionary<string, Contato>();

    public void Inserir(string apelido, string nome, string numero)
    {

        if (Lista.ContainsKey(apelido))
        {
            Console.WriteLine($"\nO contato com apelido: {apelido}, ja existe");
        }
        else
        {
            Lista.Add(apelido, new Contato(nome, numero));
            Console.WriteLine($"contato {apelido} add com sucesso");
        }
    }

    public string BuscarNumero(string apelido)
    {
        if (Lista.ContainsKey(apelido))
        {
            Console.WriteLine($"\nNumero encontrado com sucesso");
            Console.WriteLine($"\t{Lista[apelido].Nome}: {Lista[apelido].Numero}");

            return Lista[apelido].Numero;
        }
        else
        {
            Console.WriteLine($"\nNumero de {apelido}, nao encontrado!!!");
            return apelido;
        }
    }

    public void Remover(string apelido)
    {
        if (Lista.ContainsKey(apelido))
        {
            Lista.Remove(apelido);
            Console.WriteLine($"\nContato com apelido: {apelido}, removido com sucesso");
        }
        else
        {
            Console.WriteLine($"\nContato com apelido: {apelido}, nao encontrado");
        }
    }

    public void Tamanho()
    {
        Console.WriteLine($"\ntotal de contatos: {Lista.Count}");
    }
    public void ListarContatos()
    {
        Console.WriteLine("\n\ttodos os contatos");

        foreach (KeyValuePair<string, Contato> par in Lista)
        {
            Console.WriteLine($"APELIDO: {par.Key}");
            Console.WriteLine($"NOME:    {par.Value.Nome}");
            Console.WriteLine($"NÚMERO:  {par.Value.Numero}\n");

        }
        /*foreach (var pares  in Lista)
        {
            Console.WriteLine($"apelido: {pares.Value.Nome}");
        }
        */
    }
}
