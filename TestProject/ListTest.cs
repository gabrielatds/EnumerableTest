namespace TestProject
{
    public class ListTest
    {
        [Fact]
        public void TestList()
        {
            List<string> list = GetList();
            list.Count();
        }

        private List<string> GetList()
        {
            return new List<string>()
            {
                "Teste1", "Teste2"
            };
        }
    }

}