

using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        /*
         -Copio o metodo de avaliar banda
         -Pego a parte de digitar titulo do album do album 
         -valido para ver se tem algo inserido na albuns 
                -pego a  parte que pergunta a nota que banda merece e faço album
                -DEpois adciono a nota no album 

         */
        ExibirTituloDaOpcao("Avaliar Album");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))//bandasRegistradas tem a chave (nomeDaBanda)?, se sim eu: 
        {
            Banda banda = bandasRegistradas[nomeDaBanda];//crio um obj banda do tipo Banda e recebo a lista bandasRegistradas com a chave [nomeDaBanda]
            Console.WriteLine("Agora digite o título do album que deseja avaliar");
            string tituloAlbum = Console.ReadLine()!;
            if (banda.Albuns.Count > 0)
            {
                Console.Write($"Qual a nota que o album {tituloAlbum} merece: ");
                Avaliacao nota = Avaliacao.Converte(Console.ReadLine()!);
               // Album album = ???;
               // Album.AdicionarNota((nota));
                Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para o album {tituloAlbum}");
                Thread.Sleep(2000);
                Console.Clear();
            }






            
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
