namespace JodoDeDadosTiagao.ConsoleApp.Entidades;

using System.Security.Cryptography;
public class Jogador
{
    public static int ExecutarRodada( //método void não retorna nada
        int posicaoJogador,
        int limiteLinhaChegada,
        int bonusAvancoExtra,
        int penalidadeRecuo)
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
        posicaoJogador += resultadoJogador;

        Console.WriteLine("------------------------");
        Console.WriteLine("O número sorteado do jogador foi: " + resultadoJogador);
        Console.WriteLine("------------------------");

        Console.WriteLine($"Você está na posição {posicaoJogador} de {limiteLinhaChegada}.");
        Console.WriteLine("Pressione ENTER para continuar...");
        Console.ReadLine();

        if (posicaoJogador == 5 || posicaoJogador == 10 || posicaoJogador == 15 || posicaoJogador == 20)
        {
            Console.WriteLine($"\nEvento: avanço de {bonusAvancoExtra} casas.");
            posicaoJogador += bonusAvancoExtra;
            Console.WriteLine($"\nVocê está na posição {posicaoJogador} de {limiteLinhaChegada}.");
        }
        else if (posicaoJogador == 7 || posicaoJogador == 13 || posicaoJogador == 26)
        {
            Console.WriteLine($"\nEvento: recuo de {penalidadeRecuo} casas.");
            posicaoJogador -= penalidadeRecuo;
            Console.WriteLine($"\nVocê está na posição {posicaoJogador} de {limiteLinhaChegada}.");
        }
        ApresentarMensagem(posicaoJogador, limiteLinhaChegada);

        return posicaoJogador;
    }
    //método de ponto de entrada

    private static void ApresentarMensagem(
        int posicaoJogador,
        int limiteLinhaChegada
        )
    {
        if (posicaoJogador >= limiteLinhaChegada)
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
