internal class Program
{
    private static void Main(string[] args)
    {
        var list = GetList();
        Console.WriteLine(list.Count);
        Console.WriteLine(list.Count);
    }

    public static List<string> GetList()
    {
        var items = new List<string>()
            {
                "Teste1", "Teste2"
            };

        return items.Where(item => ExistsLetter(item, "T")).ToList();
    }

    public static bool ExistsLetter(string item, string letter)
    {
        Console.WriteLine("Verificando se letra existe");
        return item.Contains(letter);
    }
}