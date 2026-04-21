namespace JodoDeDadosTiagao.ConsoleApp;

using JodoDeDadosTiagao.ConsoleApp.Entidades;
class Program
{
    static void Main(string[] args)
    {


        while (true)
        {

            int posicaoComputador = 0;
            Console.Clear();

            while (true)
            {
                //1. Rodada do Jogador
                Jogador.ExecutarRodada(); //posicaoJogador está recebendo o retorno desse método
                //execuntado o método

                if (Jogador.VenceuPartida())
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
