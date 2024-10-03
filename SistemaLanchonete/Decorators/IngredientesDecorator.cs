public abstract class IngredienteDecorator : IHamburguer
{
    protected IHamburguer hamburguer;

    protected IngredienteDecorator(IHamburguer hamburguer)
    {
        this.hamburguer = hamburguer;
    }

    public virtual string GetDescricao()
    {
        return hamburguer.GetDescricao();
    }

    public virtual decimal GetPreco()
    {
        return hamburguer.GetPreco(); // Retorna o preço do hambúrguer decorado
    }
}
