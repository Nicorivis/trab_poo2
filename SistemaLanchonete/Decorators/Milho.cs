public class Milho : IngredienteDecorator
{
    public Milho(IHamburguer hamburguer) : base(hamburguer) { }

    public override string GetDescricao()
    {
        return base.GetDescricao() + ", milho";
    }

    public override decimal GetPreco()
    {
        return hamburguer.GetPreco() + 1.00m;
    }
}
