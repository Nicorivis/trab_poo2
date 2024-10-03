public class EggXBacon : Hamburguer
{
    public override string GetDescricao()
    {
        return base.GetDescricao() + " EggXBacon (pão brioche, carne, alface, tomate, queijo, bacon, ovo)";
    }

    public override decimal GetPreco()
    {
        return base.GetPreco() + 7.00m; // Preço adicional
    }
}
