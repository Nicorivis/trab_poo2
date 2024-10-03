public class MonitorProducao : IObservador
{
    public void Atualizar(Pedido pedido)
    {
        Console.WriteLine($"Produção: O status do pedido é '{pedido.Status}'");
    }
}
