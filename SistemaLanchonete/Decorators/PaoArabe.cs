public class PaoArabe : IngredienteDecorator
{
    public PaoArabe(IHamburguer hamburguer) : base(hamburguer) { }

    public override string GetDescricao()
    {
        return base.GetDescricao().Replace("pão brioche", "pão árabe");
    }

    public override decimal GetPreco()
    {
        return hamburguer.GetPreco(); // Não altera o preço
    }
}
