public class Cliente
{
    private string _cpf;
    private string _nome;
    public static List<Cliente> clientes = new();

    public string Cpf
    {
        get => _cpf;
        set => _cpf = value;
    }

    public string Nome
    {
        get => _nome;
        set => _nome = value;
    }

    public Cliente()
    {
        _cpf = string.Empty;
        _nome = string.Empty;
    }

    public Cliente(string cpf, string nome)
    {
        _cpf = cpf;
        _nome = nome;
    }

    public Cliente(string cpf)
    {
        Cpf = cpf;
    }


    /*
      public Cliente(string cpf)
      {
          // Encontra um objeto Cliente na lista "clientes" que possui um CPF correspondente
          Cliente clienteTemporarioLista = clientes.Find(x => x.Cpf == cpf);

          // Verifica se um objeto Cliente correspondente foi encontrado
          if (clienteTemporarioLista == null)
          {
              // Se nenhum objeto Cliente correspondente for encontrado, define os campos _cpf e _nome como strings vazias
              _cpf = string.Empty;
              _nome = string.Empty;
          }
          else
          {
              // Se um objeto Cliente correspondente for encontrado, atribui os valores de CPF e Nome desse objeto aos campos _cpf e _nome, respectivamente
              _cpf = clienteTemporarioLista.Cpf;
              _nome = clienteTemporarioLista.Nome;
          }
      }*/

    // Fazer CRUD Da lista

    public static void Criar(string cpf, string nome)
    {
        Cliente novoCliente = new Cliente(cpf, nome);
        clientes.Add(novoCliente);
    }

    public void Deletar()
    {
      
    }

}