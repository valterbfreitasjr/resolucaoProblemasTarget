using FaturamentoMensalDistribuidora.Model;

namespace FaturamentoDistribuidora.Entidade
{
    public class Faturamento
    {
        public string UF { get; set; }
        public double Valor { get; set; }

        public List<FaturamentoDto> ObterValorTotal(List<Faturamento> faturamentos)
        {
            var total = faturamentos.Sum(s => s.Valor);
            //Realiza a conversão do 'List<Faturamento>' para 'List<FaturamentoDto>'.
            var faturamentoDto = faturamentos.ConvertAll(x => new FaturamentoDto
            {
                UF = x.UF,
                Percentual = (x.Valor * 100) / total
            });

            return faturamentoDto;
        }
    }
}
