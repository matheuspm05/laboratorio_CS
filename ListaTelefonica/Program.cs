class ProgramaMain
{
    static void Main(string[] args)
    {
        ListaTelefonicaPrimitiva l1 = new ListaTelefonicaPrimitiva();

        l1.inserir("matheus", "28-999");
        l1.inserir("marcos", "28-998");
        l1.inserir("luisc", "28-997");
        l1.inserir("rafael", "28-996");
        l1.inserir("rafael", "28-996");

        l1.tamanho();

        l1.BuscarNumero("matheus");
        l1.BuscarNumero("julio");

        l1.remover("luisc"); 
        l1.remover("luis");
        l1.tamanho();


    }
}
