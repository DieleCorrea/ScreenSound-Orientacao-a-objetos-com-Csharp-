namespace ScreenSound.Modelos;

internal class Album : IAvaliavel
{
    private List<Musica> musicas = new List<Musica>();
    private List<Avaliacao> notas = new List<Avaliacao>();

    //coonstrutor 
    public Album(string nome)
    {
        Nome = nome;
        ContadorDeObjetos++;
    }

    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public List<Musica> Musicas => musicas;

    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);//verifico se a contagem não esta zerada, caso não esteja eu faço a média 
        }
    }

    public static int ContadorDeObjetos = 0;//campo estatico



    //metodos
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {DuracaoTotal}");
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }
}