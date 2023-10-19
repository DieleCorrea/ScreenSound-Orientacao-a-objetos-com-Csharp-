
using ScreenSound.Modelos;

namespace ScreenSound.Menus
{
    internal class MenuAvaliarBanda : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {

            base.Executar(bandasRegistradas);// pega como base o metodo executar que esta na ascendente Menu. base é uma palavra reservada 
            ExibirTituloDaOpcao("Avaliar banda");
            Console.Write("Digite o nome da banda que deseja avaliar: ");
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Banda banda = bandasRegistradas[nomeDaBanda];
                Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
                Avaliacao nota = Avaliacao.Converte(Console.ReadLine()!);
                banda.AdicionarNota((nota));
                Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para a banda {nomeDaBanda}");
                Thread.Sleep(2000);
                Console.Clear();
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
}
