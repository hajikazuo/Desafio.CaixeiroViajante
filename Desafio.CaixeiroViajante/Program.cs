namespace Desafio.CaixeiroViajante
{
    internal class Program
    {
        static void Main()
        {
            int[,] distancias = {
                { 0, 10, 15 },
                { 10, 0, 20 },
                { 15, 20, 0 }
            };

            int cidades = distancias.GetLength(0);
            bool[] visitado = new bool[cidades];

            int cidadeAtual = 0;
            visitado[cidadeAtual] = true;

            int custoTotal = 0;
            string rota = "0 -> ";

            for (int i = 0; i < cidades - 1; i++)
            {
                int proximaCidade = -1;
                int menorDistancia = int.MaxValue;

                for (int j = 0; j < cidades; j++)
                {
                    if (!visitado[j] && distancias[cidadeAtual, j] < menorDistancia)
                    {
                        menorDistancia = distancias[cidadeAtual, j];
                        proximaCidade = j;
                    }
                }

                custoTotal += menorDistancia;
                cidadeAtual = proximaCidade;
                visitado[cidadeAtual] = true;
                rota += $"{cidadeAtual} -> ";
            }

            custoTotal += distancias[cidadeAtual, 0];
            rota += "0";

            Console.WriteLine($"Menor distancia: {rota}  Custo: {custoTotal}");
        }
    }
}
