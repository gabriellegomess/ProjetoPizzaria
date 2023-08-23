class Program
{
    static void Main(string[] args)
    {
        Cliente cliente = new();
        Pedido pedido = new();
        Pizza pizza = new();
        Bebida bebida = new();
        PedidoIdentificado pedidoIdentificado = new();


        Console.WriteLine("━━━━━━◇◆◇━━━━━━");
        Console.WriteLine("Bem-vindo!: ");
        Console.WriteLine("━━━━━━◇◆◇━━━━━━");

        Console.WriteLine();
        Console.WriteLine("CLIENTES!");
        Console.WriteLine();
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

        Console.WriteLine();
        Console.WriteLine("━━━━━━◇◆◇━━━━━━");

        Console.WriteLine("Os clientes inseridos foram:");
        for (int i = 0; i < Cliente.clientes.Count; i++)
        {
            Console.WriteLine("CPF: " + Cliente.clientes[i].Cpf);
            Console.WriteLine("Nome: " + Cliente.clientes[i].Nome);
            Console.WriteLine("----------");
        }

        Console.WriteLine();
        Console.WriteLine("━━━━━━◇◆◇━━━━━━");

        //PEDIDOS
        Console.WriteLine();
        Console.WriteLine("PEDIDOS!");
        Console.WriteLine();

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
        Console.WriteLine();
        Console.WriteLine("━━━━━━◇◆◇━━━━━━");
        Console.WriteLine("As pizzas inseridos foram:");
        for (int i = 0; i < Pizza.pizzas.Count; i++)
        {
            Console.WriteLine("Sabor da Pizza: " + Pizza.pizzas[i].SaborPizza);
            Console.WriteLine("Acompanhamento: " + Pizza.pizzas[i].Acompanhamento);
            Console.WriteLine("----------");
        }

        Console.WriteLine();
        Console.WriteLine("━━━━━━◇◆◇━━━━━━");

        //BEBIDAS

        Console.WriteLine();
        Console.WriteLine("BEBIDAS!");
        Console.WriteLine();

        string opcaoBebida = "S";

        while (opcaoBebida == "S")
        {
            Console.WriteLine("Informe a bebida que deseja adicionar: ");
            bebida.NomeBebida = Console.ReadLine();

            Console.WriteLine("Informe se deseja adicionar gelo em sua bebida: ");
            bebida.Gelo = Console.ReadLine();

            Console.WriteLine("Informe se deseja adicionar limão em sua bebida, se sim quantas rodelas?");
            bebida.Limao = Console.ReadLine();

            Bebida.Criar(bebida.NomeBebida, bebida.Gelo, bebida.Limao);

            Console.WriteLine("Deseja adicionar outra bebida ao pedido? (S/N)");
            opcaoBebida = Console.ReadLine().ToUpper();
        }

        Console.WriteLine();
        Console.WriteLine("━━━━━━◇◆◇━━━━━━");

        Console.WriteLine("As bebidas inseridas foram: ");
        for (int i = 0; i < Bebida.bebidas.Count; i++)
        {
            Console.WriteLine("Bebida: " + Bebida.bebidas[i].NomeBebida);
            Console.WriteLine("Gelo: " + Bebida.bebidas[i].Gelo);
            Console.WriteLine("Limão: " + Bebida.bebidas[i].Limao);
            Console.WriteLine("----------");
        }

        Console.WriteLine();
        Console.WriteLine("━━━━━━◇◆◇━━━━━━");


        //PEDIDOS IDENTIFICADOS
        Console.WriteLine();
        Console.WriteLine("PEDIDOS IDENTIFICADOS!");
        Console.WriteLine();

        string opcaoIdentificado = "S";

        while (opcaoIdentificado == "S")
        {
            Console.WriteLine("Informe o Id/número do pedido:");
            pedidoIdentificado.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o CPF do cliente: ");
            string cpf = Console.ReadLine();
            pedidoIdentificado.Cliente = new(cpf);

            PedidoIdentificado.pedidos.Add(pedidoIdentificado);

            Console.WriteLine("Deseja adicionar um novo pedido? (S/N)");
            opcaoIdentificado = Console.ReadLine().ToUpper();
        }

        Console.WriteLine();
        Console.WriteLine("━━━━━━◇◆◇━━━━━━");


        Console.WriteLine("Os pedidos inseridos foram: ");
        foreach (PedidoIdentificado pedidoIdentificadoT in PedidoIdentificado.pedidos)
        {
            Console.WriteLine("Número do pedido: " + pedidoIdentificadoT.Id);
            Console.WriteLine("Nome do cliente: " + pedidoIdentificadoT.Cliente.Nome);
            Console.WriteLine("CPF do cliente: " + pedidoIdentificadoT.Cliente.Cpf);
            Console.WriteLine("----------");
        }
        Console.WriteLine();
        Console.WriteLine("━━━━━━◇◆◇━━━━━━");
        Console.WriteLine();

        Console.WriteLine("◆━━━━━━◆❃◆━━━━━━◆");
        Console.WriteLine("Fim!");
        Console.WriteLine("◆━━━━━━◆❃◆━━━━━━◆");

        //ToString, ver pq o nome n deu
    }
}