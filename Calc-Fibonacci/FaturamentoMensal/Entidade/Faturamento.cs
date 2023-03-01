namespace FaturamentoMensal
{
    public class Faturamento
    {
        public int Dia { get; set; }
        public decimal Valor { get; set; }

        public decimal ObterMenorValor(List<Faturamento> faturamentos)
        {
            return faturamentos.Min(faturamento => faturamento.Valor);
        }

        public decimal ObterMaiorValor(List<Faturamento> faturamentos)
        {
            return faturamentos.Max(faturamento => faturamento.Valor);
        }

        public decimal CalcularMediaFaturamento(List<Faturamento> faturamentos)
        {
            // Obtém a média dos valores, apenas com 'Valor > 0'.
            var media = faturamentos.Where(w => w.Valor > 0).Average(a => a.Valor);
            // Retorna quantidade de dias, onde 'Valor > media'.
            return faturamentos.Where(w => w.Valor > 0).Count(c => c.Valor > media);
        }

    }
}
