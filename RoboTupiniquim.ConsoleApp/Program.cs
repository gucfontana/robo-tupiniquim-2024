namespace RoboTupiniquim.ConsoleApp;

internal class Program
{
    private static int posicaoX;
    private static int posicaoY;
    private static char direcao = 'N';

    private static void Main(string[] args)
    {
        var robosEnviados = 2;

        var coordenadas = new string[robosEnviados];
        var ordensIniciais = new string[robosEnviados];

        for (var robo = 0; robo < robosEnviados; robo++)
        {
            coordenadas[robo] = Console.ReadLine();
            ordensIniciais[robo] = Console.ReadLine();
        }

        Console.Clear();

        for (var robo = 0; robo < robosEnviados; robo++)
        {
            var coordenadasAtuais = coordenadas[robo].Split(' ');
            var ordens = ordensIniciais[robo].ToCharArray();

            posicaoX = Convert.ToInt32(coordenadasAtuais[0]);
            posicaoY = Convert.ToInt32(coordenadasAtuais[1]);
            direcao = Convert.ToChar(coordenadasAtuais[2]);

            for (var ordem = 0; ordem < ordens.Length; ordem++)
            {
                var ordemAtual = ordens[ordem];

                if (ordemAtual == 'E')
                    VirarEsquerda();

                else if (ordemAtual == 'D')
                    VirarDireita();

                else if (ordemAtual == 'M')
                    MoverRobo();
            }

            Console.WriteLine($"{posicaoX} {posicaoY} {direcao}");
        }

        Console.ReadLine();
    }

    private static void MoverRobo()
    {
        if (direcao == 'N')
            posicaoY++;

        else if (direcao == 'S')
            posicaoY--;

        else if (direcao == 'O')
            posicaoX--;

        else if (direcao == 'L')
            posicaoX++;
    }

    private static void VirarDireita()
    {
        if (direcao == 'N')
            direcao = 'L';

        else if (direcao == 'L')
            direcao = 'S';

        else if (direcao == 'S')
            direcao = 'O';

        else if (direcao == 'O')
            direcao = 'N';
    }

    private static void VirarEsquerda()
    {
        if (direcao == 'N')
            direcao = 'O';

        else if (direcao == 'O')
            direcao = 'S';

        else if (direcao == 'S')
            direcao = 'L';

        else if (direcao == 'L')
            direcao = 'N';
    }
}