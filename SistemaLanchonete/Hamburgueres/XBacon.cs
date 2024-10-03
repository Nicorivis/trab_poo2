public class XBacon : Hamburguer
{
    public override string GetDescricao()
    {
        return base.GetDescricao() + " XBacon (pão brioche, carne, alface, tomate, queijo, bacon)";
    }

    public override decimal GetPreco()
    {
        return base.GetPreco() + 5.00m; // Preço adicional
    }
}
