internal class Program
{
    private static void Main(string[] args)
    {
        var id = Guid.NewGuid();
        id.ToString();

        id = new Guid("b6b03683-977a-42c7-8957-4a11cf6e37c5");

        // if(id == Guid.NewGuid())
        // id = new Guid(); cria guild com tudo zero

        Console.WriteLine(id.ToString().Substring(0, 8));
    }
}