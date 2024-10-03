public abstract class Hamburguer : IHamburguer
{
    public virtual string GetDescricao()
    {
        return "Hambúrguer (pão brioche, carne, alface, tomate)";
    }

    public virtual decimal GetPreco()  // Mudança de double para decimal
    {
        return 13.00m;  // Use 'm' para indicar que é um decimal
    }
}
