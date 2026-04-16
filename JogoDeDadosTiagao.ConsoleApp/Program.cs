using System.Security.Cryptography;

class Jogador
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

class Computador
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
class Program
{
    static void Main(string[] args)
    {
        const int limiteLinhaChegada = 30;
        const int bonusAvancoExtra = 3;
        const int penalidadeRecuo = 2;

        while (true)
        {
            int posicaoJogador = 0;
            int posicaoComputador = 0;
            Console.Clear();

            while (true)
            {
                //1. Rodada do Jogador
                posicaoJogador = Jogador.ExecutarRodada( //posicaoJogador está recebendo o retorno desse método
                    posicaoJogador,
                    limiteLinhaChegada,
                    bonusAvancoExtra,
                    penalidadeRecuo); //execuntado o método

                if (posicaoJogador >= limiteLinhaChegada)
                    break;

                //3. Rodada do Computador
                posicaoComputador = Computador.ExecutarRodada(
                    posicaoComputador,
                    limiteLinhaChegada,
                    bonusAvancoExtra,
                    penalidadeRecuo);

                if (posicaoComputador >= limiteLinhaChegada)
                    break;
            }

            Console.Write("Deseja continuar? s/N");
            string? opcaoContinuar = Console.ReadLine()?.ToUpper(); //avisando ao compilador que a variável pode ser nula

            if (opcaoContinuar != "S")
                break;
        }
    }

}
