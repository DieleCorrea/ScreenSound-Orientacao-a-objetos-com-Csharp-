

using ScreenSound.Modelos;

namespace ScreenSound.Menus
{//CLASSE ANCESTRAL 
    internal class Menu
    {
         public void ExibirTituloDaOpcao(string titulo)
        {
            int quantidadeDeLetras = titulo.Length;//esse lengh está contando a quantidade de caracteres que houver na variavel 
            string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
            Console.WriteLine(asteriscos);
            Console.WriteLine(titulo);
            Console.WriteLine(asteriscos + "\n");

            /*
             O método string.Empty é usado para criar uma string vazia, e então o método PadLeft é 
             chamado nessa string vazia. O método PadLeft é usado para preencher a string com caracteres 
             à esquerda até que ela atinja o comprimento especificado, neste caso, quantidadeDeLetras, 
             e os caracteres de preenchimento são asteriscos ('*').

             Portanto, o resultado dessa linha de código será uma string contendo uma quantidade de asteriscos 
             igual a quantidadeDeLetras, que foram adicionados à esquerda de uma string vazia. Isso é frequentemente 
             usado para criar uma string de asteriscos com um comprimento específico. Por exemplo, se quantidadeDeLetras 
             for 5, asteriscos será "*****".
            */
        }
        public virtual void Executar (Dictionary<string, Banda> bandasRegistradas)
        {
            Console.Clear();
        }


    }
}
