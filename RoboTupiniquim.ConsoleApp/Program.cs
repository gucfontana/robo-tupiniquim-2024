namespace RoboTupiniquim.ConsoleApp
{
    internal class Program
    {
        // variável global
        static int posicaoX = 0;
        static int posicaoY = 0;
        static char direcao = 'N';

        static void Main(string[] args)
        {
            int robosEnviados = 2;

            string[] coordenadas = new string[robosEnviados];
            string[] ordensIniciais = new string[robosEnviados];

            // preenchimento de ordens do robô
            for (int robo = 0; robo < robosEnviados; robo++)
            {
                coordenadas[robo] = Console.ReadLine();
                ordensIniciais[robo] = Console.ReadLine();
            }

            Console.Clear();

            // processar
            for (int robo = 0; robo < robosEnviados; robo++)
            {
                string[] coordenadasAtuais = coordenadas[robo].Split(' ');
                char[] ordens = ordensIniciais[robo].ToCharArray();

                posicaoX = Convert.ToInt32(coordenadasAtuais[0]);
                posicaoY = Convert.ToInt32(coordenadasAtuais[1]);
                direcao = Convert.ToChar(coordenadasAtuais[2]);

                for (int ordem = 0; ordem < ordens.Length; ordem++)
                {
                    char ordemAtual = ordens[ordem];

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
}
