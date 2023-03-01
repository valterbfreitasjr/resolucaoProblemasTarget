using FaturamentoDistribuidora.Entidade;

class MainClass
{
    public static void Main(string[] args)
    {
        var faturamentos = PopulaFaturamento();

        var calculoPercentual = new Faturamento().ObterValorTotal(faturamentos);

        Console.WriteLine("Percentual de cada estado ::" + calculoPercentual);

    }

    private static List<Faturamento> PopulaFaturamento()
    {
        var faturamentos = new List<Faturamento>
        {
            new Faturamento
            {
                UF = "SP",
                Valor = 67836.43
            },
            new Faturamento
            {
                UF = "RJ",
                Valor = 36678.66
            },
            new Faturamento
            {
                UF = "MG",
                Valor = 29229.88
            },
            new Faturamento
            {
                UF = "ES",
                Valor = 27165.48
            },
            new Faturamento
            {
                UF = "Outros",
                Valor = 19849.53
            },
        };

        return faturamentos;
    }
}