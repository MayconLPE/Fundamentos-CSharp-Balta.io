internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        var arr = new int[3];

        try
        {
            // for (var index = 0; index < 4; index++)
            // {
            // IndexOutOfRangerException
            //      Console.WriteLine(arr[index]);
            //   }

            Cadastrar("");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.InnerException);
            Console.WriteLine(ex.Message);
            Console.WriteLine("Não encontrou o índice na lista!");

        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine(ex.InnerException);
            Console.WriteLine(ex.Message);
            Console.WriteLine("Falha ao cadastrar texto");

        }
        catch (Exception ex) // para erros desconhecidos ou genericos.
        {
            Console.WriteLine(ex.InnerException);
            Console.WriteLine(ex.Message);
            Console.WriteLine("Algo deu errado!");
        }
        finally
        {
            Console.WriteLine("Chegou ao fim!");
        }
    }

    private static void Cadastrar(string texto)
    {
        if (string.IsNullOrEmpty(texto))
            throw new Exception("O texto não pode ser nulo ou vazio");
    }
}