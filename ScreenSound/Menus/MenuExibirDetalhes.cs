﻿using ScreenSound.Modelos;

namespace ScreenSound.Menus
{
    internal class MenuExibirDetalhes : Menu
    {

        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);// pega como base o metodo executar que esta na ascendente Menu. base é uma palavra 
            ExibirTituloDaOpcao("Exibir detalhes da banda");
            Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Banda banda = bandasRegistradas[nomeDaBanda];
                Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}.");
                Console.WriteLine("Dscografia: ");
                foreach (Album item in banda.Albuns)
                {
                    Console.WriteLine($"\n A nota do album {item.Nome} tem a média {item.Media}" );
                }
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
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
