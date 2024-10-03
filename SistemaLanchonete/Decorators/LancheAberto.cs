public class LancheAberto : IngredienteDecorator
{
    public LancheAberto(IHamburguer hamburguer) : base(hamburguer) { }

    public override string GetDescricao()
    {
        return base.GetDescricao() + " (lanche aberto)";
    }

    public override decimal GetPreco()
    {
        return hamburguer.GetPreco();
    }
}
