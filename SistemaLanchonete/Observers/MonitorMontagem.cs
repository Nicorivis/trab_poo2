public class MonitorMontagem : IObservador
{
    public void Atualizar(Pedido pedido)
    {
        Console.WriteLine($"Montagem: O status do pedido é '{pedido.Status}'");
    }
}
