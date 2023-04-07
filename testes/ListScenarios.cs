namespace EnumerableTest
{
    public static class ListScenarios
    {
        /// <summary>
        /// Instância a lista uma vez, e já deixa a informação de count pronta na memória, pois já conhece a lista, já tem a lista na memória.
        /// Cenário de vantagem em relação ao Enumerable
        /// </summary>
        public static void ExecuteCountScenario()
        {
            var list = GetListFilteredByTLetter();
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Count);

            Console.WriteLine("---WHERE---");
            var filteredResults = list.Where(x => x == "Teste1");
            foreach (var result in filteredResults)
                Console.WriteLine(result);
        }

        /// <summary>
        /// Ele instância a lista inteira, e só depois pega o primeiro valor
        /// Cenário de desvantagem em relação ao Enumerable
        /// </summary>
        public static void ExecuteFirstOrDefaultScenario()
        {
            var list = GetListFilteredByTLetter();

            Console.WriteLine("--FIRST OR DEFAULT--");
            Console.WriteLine(list.FirstOrDefault());
        }

        private static List<string> GetListFilteredByTLetter()
        {
            var items = new List<string>()
            {
                "Teste1", "Teste2", "Teste3"
            };

            return items.Where(item => ExistsLetter(item, "T")).ToList();
        }

        private static bool ExistsLetter(string item, string letter)
        {
            Console.WriteLine("Verificando se letra existe");
            return item.Contains(letter);
        }
    }
}
