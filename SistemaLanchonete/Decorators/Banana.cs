public class Banana : IngredienteDecorator
{
    public Banana(IHamburguer hamburguer) : base(hamburguer) {}

    public override string GetDescricao()
    {
        return hamburguer.GetDescricao() + ", banana";
    }

    public override decimal GetPreco() // Alteração para decimal
    {
        return hamburguer.GetPreco() + 1.50m; // Supondo que a banana custe 1.50 reais
    }
}
