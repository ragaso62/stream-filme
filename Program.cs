Filme filme = new Filme();
Console.Write("Titulo: ");
filme.titulo = Console.ReadLine();

Console.Write("Gênero: ");
filme.genero = Console.ReadLine();

Console.WriteLine("Ano de lançamento: ");
filme.anoLancamento = Convert.ToInt32(Console.Read());

Console.WriteLine("classificação indicativa:");
filme.classificarIndicativa = Convert.ToInt32(Console.Read());

filme.exibirInformacoes();