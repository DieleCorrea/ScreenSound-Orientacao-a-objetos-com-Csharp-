namespace ScreenSound.Modelos;
internal class Banda : IAvaliavel
{
    private List<Album> albuns = new List<Album>();
    public IEnumerable<Album> Albuns => albuns;
    //Isso é uma propriedade do tipo IEnumerable,
    //usando essa interface eu to protegendo que mudem
    //minha coleção fora desta classe, fora daqui fica somente para leitura e previne problemas futuros,
    //se no futuro eu quiser usar outra estrutura de dados sem ser uma list,
    //muda aqui e não afeta o codigo externo. 



    private List<Avaliacao> notas = new List<Avaliacao>();

    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;//se a contagem das notas receber 0 retorno a media 0
            else return notas.Average(a => a.Nota);// senão, eiu faço o calculo da média
        }
    }
    

    public void AdicionarAlbum(Album album) 
    { 
        albuns.Add(album);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}