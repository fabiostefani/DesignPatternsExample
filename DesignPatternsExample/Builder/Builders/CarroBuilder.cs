using DesignPatternsExample.Builder.Models;

namespace DesignPatternsExample.Builder.Builders;
public class CarroBuilder : VeiculoBuilder
{
    const string Motor = "1500 cc";
    const string Portas = "4";
    const string Rodas = "4";
    public CarroBuilder()
    {
        _veiculo = new Veiculo("Carro");
    }
    public override VeiculoBuilder BuildMotor()
    {
        _veiculo[Veiculo.Motor] = Motor;
        return this;
    }

    public override VeiculoBuilder BuildPortas()
    {
        _veiculo[Veiculo.Portas] = Portas;
        return this;
    }

    public override VeiculoBuilder BuildRodas()
    {
        _veiculo[Veiculo.Rodas] = Rodas;
        return this;
    }
}