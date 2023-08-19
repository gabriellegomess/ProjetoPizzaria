public class Bebida
{
    private string _gelo;
    private string _bebida;
    private string _limao;
    public static List<Bebida> bebidas = new();

    public string Gelo
    {
        get => _gelo;
        set => _gelo = value;
    }

    public string Limao
    {
        get => _limao;
        set => _limao = value;
    }

    public string NomeBebida
    {
        get => _bebida;
        set => _bebida = value;
    }

    public Bebida()
    {
        _bebida = string.Empty;
        _gelo = string.Empty;
        _limao = string.Empty;
    }

    public Bebida (string bebida, string gelo, string limao)
    {
        _bebida = bebida;
        _gelo = gelo;
        _limao = limao;
    }

    public static void Criar(string bebida, string gelo, string limao)
    {
        Bebida novaBebida = new Bebida(bebida, gelo, limao);
        bebidas.Add(novaBebida);
    }

}