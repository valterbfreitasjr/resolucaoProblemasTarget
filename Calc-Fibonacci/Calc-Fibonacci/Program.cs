using Calc_Fibonacci.Entidade;

class MainClass
{
    public static void Main(string[] args)
    {
        var calc = new Fibonacci();

        // Criar uma sequência Fibonacci.
        calc.CalculaFibonacci(5);

        // Verifica se o número está ou não na sequência Fibonacci.
        calc.VerificaSequenciaFibonacci(3);
    }
}