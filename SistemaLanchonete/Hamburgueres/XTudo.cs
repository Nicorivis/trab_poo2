public class XTudo : Hamburguer
{
    public override string GetDescricao()
    {
        return base.GetDescricao() + " X-Tudo (pão brioche, carne, alface, tomate, presunto, queijo, bacon, ovo, banana)";
    }

    public override decimal GetPreco()
    {
        return base.GetPreco() + 10.00m; // Preço adicional
    }
}
