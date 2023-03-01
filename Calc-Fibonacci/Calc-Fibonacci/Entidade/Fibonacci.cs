namespace Calc_Fibonacci.Entidade
{
    public class Fibonacci
    {
        int numeroAnterior = 0;
        int numeroAtual = 1;
        int fibonacci;
        List<int> fibonacciValores = new List<int>();

        public void CalculaFibonacci(int valor)
        {
            while (fibonacciValores.Count < valor)
            {
                fibonacci = numeroAnterior + numeroAtual;
                numeroAnterior = numeroAtual;
                numeroAtual = fibonacci;
                // Incrementa o '.Count' e guarda os valores de 'fibonacci'.
                fibonacciValores.Add(fibonacci);
            }
        }

        public bool VerificaSequenciaFibonacci(int valor)
        {
            // Verifica se o valor passado está ou não na sequência Fibonacci criada.
            foreach (var value in fibonacciValores)
            {
                if (value == valor)
                {
                    Console.WriteLine("O valor desejado ESTÁ na sequência de Fibonacci.");
                    return true;
                }
            }

            Console.WriteLine("O valor desejado NÃO está na sequência de Fibonacci.");
            return false;
        }
    }
}
