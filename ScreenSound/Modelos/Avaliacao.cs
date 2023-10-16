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
/********************/

internal class Colaborador
{
    public Colaborador(string nome, double salario, int anosEmpresa, double descontos = 0)
    {
        Nome = nome;
        Salario = salario;
        AnosEmpresa = anosEmpresa;
        Descontos = descontos;
    }

    public string Nome { get; }
    public double Salario { get; }
    public int AnosEmpresa { get; }
    public double Descontos { get; }
    public double Anuenio => 1 + (AnosEmpresa * 0.01);
}

internal class DepartamentoPessoal
{
    public static void ExibeFolha(List<Colaborador> colaboradores)
    {
        foreach (Colaborador c in colaboradores)
        {
            var salarioDoMes = (c.Salario * c.Anuenio) - c.Descontos;
            Console.WriteLine($"- {c.Nome}: R$ {salarioDoMes}");
        }
    }
}
