using DesignPatternsExample.Builder.Models;

namespace DesignPatternsExample.Builder.Builders;
public abstract class VeiculoBuilder
{
    protected Veiculo _veiculo;

    public Veiculo ObterVeiculo
    {
        get { return _veiculo; }
    }

    public abstract VeiculoBuilder BuildMotor();
    public abstract VeiculoBuilder BuildRodas();
    public abstract VeiculoBuilder BuildPortas();
}