namespace JodoDeDadosTiagao.ConsoleApp.Entidades;

using System.Security.Cryptography;
public class Computador
{
    public static int ExecutarRodada(
             int posicaoComputador,
             int limiteLinhaChegada,
             int bonusAvancoExtra,
             int penalidadeRecuo
            )
    {
        //Console.Clear();
        Console.WriteLine("------------------------");
        Console.WriteLine("Jogo dos Dados!");
        Console.WriteLine("------------------------");
        Console.WriteLine("Rodada do computador");
        Console.WriteLine("------------------------");

        Console.WriteLine("Pressione ENTER para jogar o dado...");
        Console.ReadLine();

        int resultadoComputador = RandomNumberGenerator.GetInt32(1, 7);
        posicaoComputador += resultadoComputador;

        Thread.Sleep(2000);

        Console.WriteLine("------------------------");
        Console.WriteLine("O número sorteado do computador foi: " + resultadoComputador);
        Console.WriteLine("------------------------");

        Console.WriteLine($"Computador está na posição {posicaoComputador} de {limiteLinhaChegada}.");
        Console.WriteLine("------------------------");
        Console.WriteLine("Pressione ENTER para continuar...");
        Console.ReadLine();

        if (posicaoComputador == 5 || posicaoComputador == 10 || posicaoComputador == 15 || posicaoComputador == 20)
        {
            Console.WriteLine($"\nEvento: avanço de {bonusAvancoExtra} casas.");
            posicaoComputador += bonusAvancoExtra;
            Console.WriteLine($"\nComputador está na posição {posicaoComputador} de {limiteLinhaChegada}.");
        }
        else if (posicaoComputador == 7 || posicaoComputador == 13 || posicaoComputador == 26)
        {
            Console.WriteLine($"\nEvento: recuo de {penalidadeRecuo} casas.");
            posicaoComputador -= penalidadeRecuo;
            Console.WriteLine($"\nComputador está na posição {posicaoComputador} de {limiteLinhaChegada}.");
        }
        ApresentarMensagem(posicaoComputador, limiteLinhaChegada);
        return posicaoComputador;
    }

    private static void ApresentarMensagem(
        int posicaoComputador,
        int limiteLinhaChegada
        )
    {
        if (posicaoComputador >= limiteLinhaChegada)
        {
            Console.WriteLine($"Pena, você perdeu! O computador alcançou a linha de chegada.");
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
