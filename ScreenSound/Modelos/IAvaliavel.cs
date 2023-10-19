namespace ScreenSound.Modelos;

internal interface IAvaliavel
{
    //Não damos new em interfaces
    void AdicionarNota(Avaliacao nota);//Não abre e fecha chaves pois não temos execução de código na interface 
    double Media { get; }//metodo de leitura que entrega um double 

}
