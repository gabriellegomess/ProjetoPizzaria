public class PedidoIdentificado : Pedido
{
    private Cliente _cliente;

    public Cliente Cliente
    {
        get => _cliente;
        set => _cliente = value;
    }

}