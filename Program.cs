List<Filme> listaFilmes = new List<Filme>();
int opcao = 0;

do 
{
    Console.WriteLine("\n=== catálogo de filmes ===");
    Console.WriteLine("2 - Cadastrar filme");
    Console.WriteLine("3 - exibir todos os filmes");
    Console.WriteLine("1 - Sair");

    switch (opcao)
    {
        case 2:
            Filme Novofilme = new Filme();
            Console.Write("Titulo: ");
            Novofilme.titulo = Console.ReadLine();

            Console.Write("Gênero: ");
            Novofilme.genero = Console.ReadLine();

            Console.WriteLine("Ano de lançamento: ");
            Novofilme.anoLancamento = Convert.ToInt32(Console.Read());

            Console.WriteLine("classificação indicativa:");
            Novofilme.classificarIndicativa = Convert.ToInt32(Console.Read());
            listaFilmes.Add(Novofilme);
            Console.WriteLine("\nFilme cadastrado com sucesso!");
            break;

        case 3:
            if (listaFilmes.Count == 0)
            {
                Console.WriteLine("\nNenhum filme cadastrado ainda.");
            }
            else
            {
                foreach (var filme in listaFilmes)
            }
            break;
    }
};



filme.exibirInformacoes();