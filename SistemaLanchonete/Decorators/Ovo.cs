public class Ovo : IngredienteDecorator
{
    public Ovo(IHamburguer hamburguer) : base(hamburguer) {}

    public override string GetDescricao()
    {
        return hamburguer.GetDescricao() + ", ovo";
    }

    public override decimal GetPreco() // Alteração para decimal
    {
        return hamburguer.GetPreco() + 2.00m; // Supondo que o ovo custe 2 reais
    }
}
