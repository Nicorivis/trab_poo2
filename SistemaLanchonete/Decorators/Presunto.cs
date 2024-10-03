public class Presunto : IngredienteDecorator
{
    public Presunto(IHamburguer hamburguer) : base(hamburguer) { }

    public override string GetDescricao()
    {
        return base.GetDescricao() + ", presunto";
    }

    public override decimal GetPreco()
    {
        return hamburguer.GetPreco() + 2.00m;
    }
}