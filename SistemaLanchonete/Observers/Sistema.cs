using System;
using System.Threading.Tasks;

class Sistema
{
    static async Task Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Bem-vindo à Lanchonete!");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Iniciar pedido");
            Console.WriteLine("2. Sair");
            string escolha = Console.ReadLine();

            if (escolha == "1")
            {
                await IniciarPedido();
            }
            else if (escolha == "2")
            {
                Console.WriteLine("Saindo...");
                break;
            }
            else
            {
                Console.WriteLine("Opção inválida! Tente novamente.");
            }
        }
    }

    static async Task IniciarPedido()
    {
        // Cria o hamburguer
        IHamburguer meuHamburguer = new XTudo(); // Presumindo que XTudo implementa IHamburguer

        // Cliente faz personalizações
        meuHamburguer = new Milho(meuHamburguer);
        meuHamburguer = new PaoArabe(meuHamburguer);
        meuHamburguer = new LancheAberto(meuHamburguer);

        // Verifica se o hamburguer é nulo
        if (meuHamburguer == null)
        {
            Console.WriteLine("Erro: O hamburguer não pode ser nulo.");
            return; // Retorna para evitar o erro.
        }

        // Exibe o pedido final
        Console.WriteLine(meuHamburguer.GetDescricao());
        Console.WriteLine("Total: " + meuHamburguer.GetPreco() + " reais");

        // Notificação de pedido
        Pedido pedido = new Pedido(meuHamburguer); // Passando hamburguer para o construtor
        MonitorProducao producao = new MonitorProducao();
        MonitorMontagem montagem = new MonitorMontagem();

        pedido.RegistrarObservador(producao);
        pedido.RegistrarObservador(montagem);

        pedido.AtualizarStatus("Em produção");

        // Simula o tempo de preparo do pedido
        Console.WriteLine("Seu pedido está sendo preparado...");
        await Task.Delay(10000); // Aguarda 5 segundos
        pedido.AtualizarStatus("Pronto para entrega");
        Console.WriteLine("Seu lanche está pronto! Aproveite!");

        Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }
}
