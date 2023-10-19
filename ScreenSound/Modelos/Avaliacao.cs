namespace ScreenSound.Modelos;

//internal: visibilidade de classes. Apenas o PROJETO vai conseguir ver ela. Só passo para 
//public se eu quiser que outros projetos vejam ela. O que não é o caso. 

internal class Avaliacao
{
    //criar construtor
    public Avaliacao(int nota)
    {
        if (nota <= 0) nota = 0;
        if (nota >= 10) nota = 10;

        Nota = nota;
    }
    //propriedade acesso de leitura apenas
    public int Nota { get; }

    //criei um metodo do tipo Avaliacao chamado Parse com argumento string que chama texto 
    public static Avaliacao Converte(string texto)
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);

    }
}


