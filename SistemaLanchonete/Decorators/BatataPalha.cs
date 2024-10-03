public class BatataPalha : IngredienteDecorator
{
    public BatataPalha(IHamburguer hamburguer) : base(hamburguer) { }

    public override string GetDescricao()
    {
        return base.GetDescricao() + ", batata palha";
    }

    public override decimal GetPreco()
    {
        return hamburguer.GetPreco() + 1.00m;
    }
}
