public class Eggburger : Hamburguer
{
    public override string GetDescricao()
    {
        return base.GetDescricao() + " Eggburger (pão brioche, carne, alface, tomate, ovo)";
    }

    public override decimal GetPreco()
    {
        return base.GetPreco() + 4.00m; // Preço adicional
    }
}
