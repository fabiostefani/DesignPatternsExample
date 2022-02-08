namespace DesignPatternsExample.Builder.Models;
public class Veiculo
{
    public string Motor = "motor";
    public string Rodas = "rodas";
    public string Portas = "portas";
    private string _tipoVeiculo;
    private Dictionary<string, string> _partes = new Dictionary<string, string>();
    public Veiculo(string tipoVeiculo)
    {
        _tipoVeiculo = tipoVeiculo;
    }

    public string this[string key]
    {
        get { return _partes[key]; }
        set { _partes[key] = value; }
    }

    public void Show()
    {
        Console.WriteLine("\n------------------------------");
        Console.WriteLine("Tipo veículo: {0}", _tipoVeiculo);
        Console.WriteLine("   Motor: {0}", _partes[Motor]);
        Console.WriteLine("   Rodas: {0}", _partes[Rodas]);
        Console.WriteLine("   Portas: {0}", _partes[Portas]);
    }
}