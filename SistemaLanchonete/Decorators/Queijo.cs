public class Queijo : IngredienteDecorator
{
    public Queijo(IHamburguer hamburguer) : base(hamburguer) { }

    public override string GetDescricao()
    {
        return base.GetDescricao() + ", queijo";
    }

    public override decimal GetPreco()
    {
        return hamburguer.GetPreco() + 1.00m;
    }
}
