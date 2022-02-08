using DesignPatternsExample.Builder.Models;

namespace DesignPatternsExample.Builder.Builders;
public class ScooterBuilder : VeiculoBuilder
{
    const string Motor = "50 cc";
    const string Portas = "0";
    const string Rodas = "2";
    public ScooterBuilder()
    {
        _veiculo = new Veiculo("Scooter");
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