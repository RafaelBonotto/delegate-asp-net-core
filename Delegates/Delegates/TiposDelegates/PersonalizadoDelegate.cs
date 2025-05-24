namespace Delegates.TiposDelegates
{
    public class PersonalizadoDelegate
    {
        public delegate int Operacao(int x, int y);

        public static void TestarDelegatePersonalizado()
        {
            Operacao Somar = (a, b) => a + b;
            Operacao Multiplicar = (a, b) => a * b;

            Console.WriteLine($"Delegate Personalizado Somar 3 + 5: {Somar(3, 5)}");       // Saída: 8
            Console.WriteLine($"Delegate Personalizado Multiplicar 3 x 5: {Multiplicar(3, 5)}");       // Saída: 15
        }
    }
}
