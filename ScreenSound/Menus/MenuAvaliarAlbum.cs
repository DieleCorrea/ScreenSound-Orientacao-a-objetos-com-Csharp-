

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
            Banda banda = bandasRegistradas[nomeDaBanda];//pego a chave digitada [nomeDaBanda] que esta na lista bandasRegistradas e defico que é DO TIPO Banda quando passo para a variavel banda. 
            Console.WriteLine("Agora digite o título do album que deseja avaliar");
            string tituloAlbum = Console.ReadLine()!;
            //se a banda *** com albuns *** ter alguma propriedade como o Nome igual ao tituloAlbum eu: 
            if (banda.Albuns.Any(a => a.Nome.Equals(tituloAlbum)))
            {
                //pego o primeiro Nome que for igual o recebido pelo ~tituloAlbum~ e envio para nomeAlbum do tipo Album
                Album nomeAlbum = banda.Albuns.First(a => a.Nome.Equals(tituloAlbum));

                Console.Write($"Qual a nota que o album {tituloAlbum} merece: ");
                Avaliacao nota = Avaliacao.Converte(Console.ReadLine()!);
                nomeAlbum.AdicionarNota(nota);
                Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para o album {tituloAlbum}");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nO album {tituloAlbum} não foi encontrada!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }else{
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
