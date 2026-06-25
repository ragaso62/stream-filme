<<<<<<< HEAD
﻿Filme filme = new Filme();
Console.Write("Titulo: ");
filme.titulo = Console.ReadLine();

Console.Write("Gênero: ");
filme.genero = Console.ReadLine();

Console.WriteLine("Ano de lançamento: ");
filme.anoLancamento = Convert.ToInt32(Console.Read());

Console.WriteLine("classificação indicativa:");
filme.classificarIndicativa = Convert.ToInt32(Console.Read());
=======
List<Filme> listaFilmes = new List<Filme>();
int opcao;

do 
{
    Console.WriteLine("\n=== catálogo de filmes ===");
    Console.WriteLine("1 - Cadastrar filme");
    Console.WriteLine("2 - exibir todos os filmes");
    Console.WriteLine("0 - Sair");
    opcao = Convert.ToInt32(Console.ReadLine());
>>>>>>> d80238023bb65bb060cb29da8f98e8d83f719cb6

    switch (opcao)
    {
        case 1:
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

        case 2:
            if (listaFilmes.Count == 0)
            {
                Console.WriteLine("\nNenhum filme cadastrado ainda.");
            }
            else
            {
                foreach (var filme in listaFilmes)
                {
                    filme.exibirInformacoes();
                }
            }
            break;
        case 0:
            Console.WriteLine("\nPrograma encerrado");
            break;
        default:
            Console.WriteLine("\nOpção inválida.");
            break;
    }
    
}while (opcao != 0);
