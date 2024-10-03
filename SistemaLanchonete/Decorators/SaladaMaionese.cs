public class SaladaMaionese : IngredienteDecorator
{
    public SaladaMaionese(IHamburguer hamburguer) : base(hamburguer) { }

    public override string GetDescricao()
    {
        return base.GetDescricao() + ", salada de maionese";
    }

    public override decimal GetPreco()
    {
        return hamburguer.GetPreco() + 3.00m;
    }
}
