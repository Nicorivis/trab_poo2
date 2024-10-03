using System;
using System.Collections.Generic;

public class Pedido
{
    private string status = "Pendente"; // Inicializa com um valor padrão
    private IHamburguer hamburguer; // Campo não anulável
    private List<IObservador> observadores = new List<IObservador>(); // Lista de observadores

    // Construtor que exige um hamburguer
    public Pedido(IHamburguer hamburguer)
    {
        this.hamburguer = hamburguer ?? throw new ArgumentNullException(nameof(hamburguer));
    }

    // Método para registrar observadores
    public void RegistrarObservador(IObservador observador)
    {
        observadores.Add(observador);
    }

    // Método para adicionar hamburguer ao pedido
    public void AdicionarHamburguer(IHamburguer hamburguer)
    {
        this.hamburguer = hamburguer; // Adiciona o hamburguer ao pedido
        NotificarObservadores(); // Notifica os observadores
    }

    // Método para atualizar o status do pedido
    public void AtualizarStatus(string novoStatus)
    {
        status = novoStatus;
        NotificarObservadores(); // Notifica os observadores sobre a mudança de status
    }

    // Método para notificar todos os observadores
    private void NotificarObservadores()
    {
        foreach (var observador in observadores)
        {
            observador.Atualizar(this); // Chama o método Atualizar de cada observador
        }
    }

    // Propriedade para acessar o status (opcional)
    public string Status => status;

    // Método para obter a descrição do pedido (opcional)
    public string GetDescricao()
    {
        return hamburguer.GetDescricao(); // Presumindo que IHamburguer tem o método GetDescricao
    }

    // Método para obter o preço do pedido (opcional)
    public decimal GetPreco()
    {
        return hamburguer.GetPreco(); // Presumindo que IHamburguer tem o método GetPreco
    }
}
