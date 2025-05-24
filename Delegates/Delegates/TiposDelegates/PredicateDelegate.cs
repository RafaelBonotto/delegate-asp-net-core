namespace Delegates.TiposDelegates
{
    public class PredicateDelegate
    {
        // Sempre irá retornar um booleano
        Predicate<int> ValidarNumeroPar = numero => numero % 2 == 0;
    }
}
