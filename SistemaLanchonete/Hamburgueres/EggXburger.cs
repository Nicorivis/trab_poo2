public class EggXburger : Hamburguer
{
    public override string GetDescricao()
    {
        return base.GetDescricao() + " EggXburger (pão brioche, carne, alface, tomate, queijo, ovo)";
    }

    public override decimal GetPreco()
    {
        return base.GetPreco() + 5.00m; // Preço adicional
    }
}
