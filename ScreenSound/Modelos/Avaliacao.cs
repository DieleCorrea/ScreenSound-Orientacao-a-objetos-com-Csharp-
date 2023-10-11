namespace ScreenSound.Modelos;

//internal: visibilidade de classes. Apenas o PROJETO vai conseguir ver ela. Só passo para 
//public se eu quiser que outros projetos vejam ela. O que não é o caso. 

internal class Avaliacao
{
    //criar construtor
    public Avaliacao(int nota) 
    { 
        Nota = nota;    
    }
    //propriedade acesso de leitura apenas
    public int Nota { get; }
}
