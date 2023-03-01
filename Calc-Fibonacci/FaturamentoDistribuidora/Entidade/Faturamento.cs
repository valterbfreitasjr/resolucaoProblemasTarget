using FaturamentoDistribuidora.Model;

namespace FaturamentoDistribuidora.Entidade
{
    public class Faturamento
    {
        public string UF { get; set; }
        public double Valor { get; set; }

        public List<FaturamentoDto> ObterValorTotal(List<Faturamento> faturamentos)
        {
            var total = faturamentos.Sum(s => s.Valor);
            var faturamentoDto = faturamentos.ConvertAll(x => new FaturamentoDto
            {
                UF = x.UF,
                Percentual = (double)Math.Round(x.Valor * 100 / total, 2)
            });

            return faturamentoDto;
        }
    }
}
