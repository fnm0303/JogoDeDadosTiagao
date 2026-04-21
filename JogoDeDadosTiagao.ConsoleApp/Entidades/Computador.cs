namespace JodoDeDadosTiagao.ConsoleApp.Entidades;

using System.Security.Cryptography;
public static class Computador
{
    public static int posicao = 0;
    const int limiteLinhaChegada = 30; //constantes já são estáticos por padrão.
    const int bonusAvancoExtra = 3;
    const int penalidadeRecuo = 2;
    public static void ExecutarRodada()
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
        posicao += resultadoComputador;

        Thread.Sleep(2000);

        Console.WriteLine("------------------------");
        Console.WriteLine("O número sorteado do computador foi: " + resultadoComputador);
        Console.WriteLine("------------------------");

        Console.WriteLine($"Computador está na posição {posicao} de {limiteLinhaChegada}.");
        Console.WriteLine("------------------------");
        Console.WriteLine("Pressione ENTER para continuar...");
        Console.ReadLine();

        if (posicao == 5 || posicao == 10 || posicao == 15 || posicao == 20)
        {
            Console.WriteLine($"\nEvento: avanço de {bonusAvancoExtra} casas.");
            posicao += bonusAvancoExtra;
            Console.WriteLine($"\nComputador está na posição {posicao} de {limiteLinhaChegada}.");
        }
        else if (posicao == 7 || posicao == 13 || posicao == 26)
        {
            Console.WriteLine($"\nEvento: recuo de {penalidadeRecuo} casas.");
            posicao -= penalidadeRecuo;
            Console.WriteLine($"\nComputador está na posição {posicao} de {limiteLinhaChegada}.");
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
