namespace Delegates.TiposDelegates
{
    public class ActionDelegate
    {
        Action<string> ImprimirMensagem = mensagem => Console.WriteLine(mensagem);
        Action<int, string> AlterarNomeAction = (id, nome) => AlterarNome(id, nome);

        public static void AlterarNome(int id, string nome) => Console.WriteLine($"Nome alterado - Id: {id}, Nome: {nome}");
    }
}
