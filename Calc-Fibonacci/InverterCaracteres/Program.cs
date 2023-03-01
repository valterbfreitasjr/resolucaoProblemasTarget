class MainClass
{
    public static void Main(string[] args)
    {
        string palavra = "Teste Target Sistemas";
        var palavraInvertida = InverterPalavra(palavra);

        Console.WriteLine(palavraInvertida);
    }

    private static string InverterPalavra(string palavra)
    {
        string palavraInvertida = "";
        char [] palavraChars = palavra.ToCharArray();

        // Laço para iterar de trás para frente na palavra, passando 'palavraChars[index]' para 'palavraInvertida', então retorno a 'palavraInvertida'.
        for (int i = palavra.Length - 1; i >= 0; i--)
            palavraInvertida += palavraChars[i];

        return palavraInvertida;
    }
}