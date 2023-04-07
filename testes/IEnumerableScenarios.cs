namespace EnumerableTest
{
    public static class IEnumerableScenarios
    {
        /// <summary>
        /// Para cada count, ele precisa trazer o enumerable inteiro na memória novamente, não é uma informação já em memória
        /// Cenário de desvantagem em relação à Listas
        /// </summary>
        public static void ExecuteCountScenario()
        {
            var enumerable = GetEnumerableFilteredByTLetter();
            Console.WriteLine(enumerable.Count());
            Console.WriteLine(enumerable.Count());

            Console.WriteLine("---WHERE---");
            var filteredResults = enumerable.Where(x => x == "Teste1");
            foreach (var result in filteredResults)
                Console.WriteLine(result);
        }

        /// <summary>
        /// Antes de trazer o enumerable inteiro para memória, ele já busca o primeiro, trazendo somente ele
        /// Cenário de vantagem em relação à Lista
        /// </summary>
        public static void ExecuteFirstOrDefaultScenario()
        {
            var enumerable = GetEnumerableFilteredByTLetter();
            Console.WriteLine(enumerable.FirstOrDefault());
        }

        private static IEnumerable<string> GetEnumerableFilteredByTLetter()
        {
            var items = new List<string>()
            {
                "Teste1", "Teste2", "Teste3"
            };

            return items.Where(item => ExistsLetter(item, "T"));
        }

        private static bool ExistsLetter(string item, string letter)
        {
            Console.WriteLine("Verificando se letra existe");
            return item.Contains(letter);
        }
    }
}
