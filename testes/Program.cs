using EnumerableTest;

internal class Program
{
    private static void Main(string[] args)
    {
        //ListScenarios.ExecuteCountScenario();
        IEnumerableScenarios.ExecuteCountScenario();

        //ListScenarios.ExecuteFirstOrDefaultScenario();
        //IEnumerableScenarios.ExecuteFirstOrDefaultScenario();
    }

    /* 
     CONCLUSION:
        Listas são tipos melhores para quando a lista vai ser manipulada, pois ela é instânciada
    uma vez na memória, e partir dali já teremos todas as informações.
    Comandos que iteram sobre toda a lista como Where, Count devem ser utilizados nesse cenário

        Enumerables são instânciados inteiramente toda vez que serão manipulados, mas possuem a vantagem
    de funcionar melhor em termos de comandos que não iteram pela lista toda / iteram somente uma vez.
    Comandos que não iteram sobre toda a lista como FirstOrDefault, First devem ser utilizados nesse cenário.
     */
}