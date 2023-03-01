using FaturamentoMensal;
using Newtonsoft.Json;

class MainClass
{
    public static void Main(string[] args)
    {
        var calc = new Faturamento();

        using (StreamReader r = new StreamReader("./dados.json"))
        {
            // Lê o arquivo json.
            var json = r.ReadToEnd();
            // Desserializa o 'json' em uma 'List<Faturamento>'.
            var items = JsonConvert.DeserializeObject<List<Faturamento>>(json);
            if (items != null)
            {
                var menorValor = calc.ObterMenorValor(items);
                var maiorValor = calc.ObterMaiorValor(items);
                var diasMaiorMedia = calc.CalcularMediaFaturamento(items);

                Console.WriteLine($"Menor valor: R$ {menorValor}.");
                Console.WriteLine($"Maior valor: R$ {maiorValor}.");
                Console.WriteLine($"Quantidade de dia(s) em que o faturamento foi maior do que a média mensal: {diasMaiorMedia} dia(s).");
            }
        }
    }
}