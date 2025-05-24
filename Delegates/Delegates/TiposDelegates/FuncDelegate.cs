namespace Delegates.TiposDelegates
{
    public class FuncDelegate
    {
        Func<int, int, int> Multiplicar = (x, y) => x * y;
        Func<double, double, double> Dividir = (a, b) => a / b;
        Func<string, int> ContarCaracteres = s => s.Length;
        Func<string> Saudacao = () => "Hello World!";
    }
}
