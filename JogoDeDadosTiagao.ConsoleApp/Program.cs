namespace JodoDeDadosTiagao.ConsoleApp;

using JodoDeDadosTiagao.ConsoleApp.Entidades;
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
