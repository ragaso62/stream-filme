public class Filme
{
    public string titulo;
    public string genero;
    public int anoLancamento;
    public int classificarIndicativa;

    public void exibirInformacoes()
    {
        Console.WriteLine("\n=== Filme Cadastrado ===");
        Console.WriteLine("Título:" + titulo);
        Console.WriteLine("Genero:" + genero);
        Console.WriteLine("Ano de Lançamento:" + anoLancamento);
        Console.WriteLine("Classificação Indicativa:" + classificarIndicativa);
    }
}