public class Pedido
{
    private int _id;
    private string _saborPizza;
    private string _bebida;
    private string _acompanhamento;
    public static List<Pedido> pedidos = new();      

    public int Id
    {
        get => _id;
        set => _id = value;
    }
/*
    public string SaborPizza
    {
        get => _saborPizza;
        set => _saborPizza = value;
    }

    public string Bebida
    {
        get => _bebida;
        set => _bebida = value;
    }

    public string Acompanhamento
    {
        get => _acompanhamento;
        set => _acompanhamento = value;
    }

    public Pedido()
    {
        _saborPizza = string.Empty;
        _bebida = string.Empty;
        _acompanhamento = string.Empty;

    }

    public Pedido(string saborPizza, string bebida, string acompanhamento)
    {
        _saborPizza = saborPizza;
        _bebida = bebida;
        _acompanhamento = acompanhamento;
    }

    public static void Criar(string Id, string saborPizza, string bebida, string acompanhamento)
    {
        Pedido novoPedido = new Pedido(saborPizza, bebida, acompanhamento);
        pedidos.Add(novoPedido);
    }
*/


}