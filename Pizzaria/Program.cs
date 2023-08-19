class Program
{
    static void Main(string[] args)
    {
        Cliente cliente = new();
        Pedido pedido = new();
        Pizza pizza = new();

        PedidoIdentificado pedidoIdentificado = new();

        Console.WriteLine("Bem-vindo!: ");


        Console.WriteLine("CLIENTES!");

        string opcao = "S";

        while (opcao == "S")
        {
            Console.Write("Informe o CPF do cliente: ");
            cliente.Cpf = Console.ReadLine();

            Console.Write("Informe o nome do cliente: ");
            cliente.Nome = Console.ReadLine();

            //Adicionando os clientes criados na lista
            Cliente.Criar(cliente.Cpf, cliente.Nome);

            Console.WriteLine("Deseja adicionar outro cliente? (S/N)");
            //se a opção foi S ele continuara adiconando clientes
            opcao = Console.ReadLine().ToUpper(); //ToUpper ler minusculas e maiusculas
        }

        /* //USANDO FOREACH - Lista temporaria, como usar foreach sem ser a lista temporaria?

              Console.WriteLine("Os clientes inseridos foram:");

               foreach (Cliente clienteTemporarioLista in Cliente.clientes)
               {
                   Console.Write("CPF: " + clienteTemporarioLista.Cpf + " | ");
                   Console.WriteLine("Nome: " + clienteTemporarioLista.Nome);
               } */

        Console.WriteLine("Os clientes inseridos foram:");
        for (int i = 0; i < Cliente.clientes.Count; i++)
        {
            Console.WriteLine("CPF: " + Cliente.clientes[i].Cpf);
            Console.WriteLine("Nome: " + Cliente.clientes[i].Nome);
            Console.WriteLine("----------");
        }

        //PEDIDOS

        Console.WriteLine("PEDIDOS!");

        string opcaoPedido = "S";

        while (opcaoPedido == "S")
        {
            Console.WriteLine("Informe o sabor da pizza que deseja adiconar:");
            pizza.SaborPizza = Console.ReadLine();

            Console.WriteLine("Informe o acompanhamento que deseja:");
            pizza.Acompanhamento = Console.ReadLine();

            Pizza.Criar(pizza.SaborPizza, pizza.Acompanhamento); //salvando as pizzas na lista

            Console.WriteLine("Deseja adicionar outro pedido? (S/N)");
            //se a opção foi S ele continuara adiconando clientes
            opcaoPedido = Console.ReadLine().ToUpper();
        }

        Console.WriteLine("As pizzas inseridos foram:");
        for (int i = 0; i < Pizza.pizzas.Count; i++)
        {
            Console.WriteLine("Sabor da Pizza: " + Pizza.pizzas[i].SaborPizza);
            Console.WriteLine("Acompanhamento: " + Pizza.pizzas[i].Acompanhamento);
            Console.WriteLine("----------");
        }

        //BEBIDAS


        //PEDIDOS IDENTIFICADOS
        Console.WriteLine("PEDIDOS IDENTIFICADOS!");

        string opcaoIdentificado = "S";

        while (opcaoIdentificado == "S")
        {
            Console.WriteLine("Informe o Id/número do pedido:");
            pedidoIdentificado.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o CPF do cliente: ");
            string cpf = Console.ReadLine();
            pedidoIdentificado.Cliente = new(cpf);

            Console.WriteLine("Deseja adicionar um novo pedido? (S/N)");
            opcaoIdentificado = Console.ReadLine().ToUpper();
        }




//OBS: Dar um jeito de colocar o id do pedido (com o sabor da pizza, acompanhamento etc) e os dados do cliente na lista de pedidos pra printar certo
//Essa lista ta sem informação, mas tem que ser a "junção" da lista de Pedido e de Cliente em um lista só pedidoIdentificado
        Console.WriteLine("Os pedidos inseridos foram: ");
        for (int i = 0; i < PedidoIdentificado.pedidos.Count; i++)
        {
            Console.WriteLine("Número do pedido: " + pedidoIdentificado.Id);
            Console.WriteLine("Nome do cliente: " + pedidoIdentificado.Cliente.Nome);
            Console.WriteLine("CPF do cliente: " + pedidoIdentificado.Cliente.Cpf);
            Console.WriteLine("----------");
        }


        Console.WriteLine("Fim");

    }
}