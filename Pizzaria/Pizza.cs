public class Pizza
{
    private string _saborPizza;
    private string _acompanhamento;
    public static List<Pizza> pizzas = new();      


    public string SaborPizza
    {
        get => _saborPizza;
        set => _saborPizza = value;
    }

    public string Acompanhamento
    {
        get => _acompanhamento;
        set => _acompanhamento = value;
    }

    public Pizza()
    {
        _saborPizza = string.Empty;
        _acompanhamento = string.Empty;

    }

    public Pizza(string saborPizza, string acompanhamento)
    {
        _saborPizza = saborPizza;
        _acompanhamento = acompanhamento;
    }

    public static void Criar(string saborPizza, string acompanhamento)
    {
        Pizza novaPizza = new Pizza(saborPizza, acompanhamento);
        pizzas.Add(novaPizza);
    }

}