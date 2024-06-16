internal class Program
{
    private static void Main(string[] args)
    {

        var texto = "teste";
        Console.WriteLine(texto.CompareTo("Teste"));
        Console.WriteLine(texto.Contains("teste"));
        Console.WriteLine(texto.Contains("Teste"));
        Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));


        var texto1 = "Este texto é um teste";
        Console.WriteLine(texto1.StartsWith("Este"));
        Console.WriteLine(texto1.StartsWith("este", StringComparison.OrdinalIgnoreCase));
        Console.WriteLine(texto1.StartsWith("texto"));

        Console.WriteLine(texto.EndsWith("teste"));
        Console.WriteLine(texto.Equals("teste", StringComparison.OrdinalIgnoreCase));

        Console.WriteLine(texto1.IndexOf("e"));
        Console.WriteLine(texto1.LastIndexOf("e"));

        Console.WriteLine(texto1.ToUpper());
        Console.WriteLine(texto1.ToLower());
        Console.WriteLine(texto1.Insert(5, " Aqui "));
        Console.WriteLine(texto1.Remove(5, 5));
        Console.WriteLine(texto1.Length);


    }
}