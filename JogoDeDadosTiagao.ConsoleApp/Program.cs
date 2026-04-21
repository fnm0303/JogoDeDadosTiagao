namespace JodoDeDadosTiagao.ConsoleApp;

using JodoDeDadosTiagao.ConsoleApp.Entidades;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Jogador.posicao = 0;
            Computador.posicao = 0;
            while (true)
            {
                //1. Rodada do Jogador
                Jogador.ExecutarRodada(); //posicaoJogador está recebendo o retorno desse método
                //execuntado o método

                if (Jogador.VenceuPartida())
                    break;

                //3. Rodada do Computador
                Computador.ExecutarRodada();

                if (Computador.VenceuPartida())
                    break;
            }

            Console.Write("Deseja continuar? s/N");
            string? opcaoContinuar = Console.ReadLine()?.ToUpper(); //avisando ao compilador que a variável pode ser nula

            if (opcaoContinuar != "S")
                break;
        }
    }

}
