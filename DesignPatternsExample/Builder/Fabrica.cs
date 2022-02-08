using DesignPatternsExample.Builder.Builders;

namespace DesignPatternsExample.Builder;
public class Fabrica
{
    public void Construir(VeiculoBuilder builder)
    {
        builder.BuildMotor()
               .BuildPortas()
               .BuildRodas();
    }
}