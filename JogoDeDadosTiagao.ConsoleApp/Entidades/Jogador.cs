namespace JodoDeDadosTiagao.ConsoleApp.Entidades;

using System.Security.Cryptography;
public static class Jogador
{
    public static int posicao = 0; //atributo (variável global)
    const int limiteLinhaChegada = 30; //constantes já são estáticos por padrão.
    const int bonusAvancoExtra = 3;
    const int penalidadeRecuo = 2;
    public static void ExecutarRodada() //método void não retorna nada
    {
        //1. Rodada do Jogador
        Console.WriteLine("------------------------");
        Console.WriteLine("Jogo dos Dados!");
        Console.WriteLine("------------------------");
        Console.WriteLine("Rodada do jogador");
        Console.WriteLine("------------------------");

        Console.WriteLine("Pressione ENTER para jogar o dado...");
        Console.ReadLine();

        int resultadoJogador = RandomNumberGenerator.GetInt32(1, 7);
        posicao += resultadoJogador;

        Console.WriteLine("------------------------");
        Console.WriteLine("O número sorteado do jogador foi: " + resultadoJogador);
        Console.WriteLine("------------------------");

        Console.WriteLine($"Você está na posição {posicao} de {limiteLinhaChegada}.");
        Console.WriteLine("Pressione ENTER para continuar...");
        Console.ReadLine();

        if (posicao == 5 || posicao == 10 || posicao == 15 || posicao == 20)
        {
            Console.WriteLine($"\nEvento: avanço de {bonusAvancoExtra} casas.");
            posicao += bonusAvancoExtra;
            Console.WriteLine($"\nVocê está na posição {posicao} de {limiteLinhaChegada}.");
        }
        else if (posicao == 7 || posicao == 13 || posicao == 26)
        {
            Console.WriteLine($"\nEvento: recuo de {penalidadeRecuo} casas.");
            posicao -= penalidadeRecuo;
            Console.WriteLine($"\nVocê está na posição {posicao} de {limiteLinhaChegada}.");
        }
        ApresentarMensagem();
    }

    public static bool VenceuPartida()
    {
        return posicao >= limiteLinhaChegada;
    }
    private static void ApresentarMensagem()
    {
        if (posicao >= limiteLinhaChegada)
        {
            Console.WriteLine($"Parabéns! Você alcançou a linha de chegada.");
            Console.WriteLine("------------------------");
            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
        }

    }

}
