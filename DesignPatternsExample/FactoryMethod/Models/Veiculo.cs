namespace DesignPatternsExample.FactoryMethod.Models;
public abstract class Veiculo
{
    public const int LimiteVelocidadeLeve = 90;
    public const int LimiteVelocidadeMedio = 100;
    public const int LimiteVelocidadePesado = 80;
    protected int Limite { get; set; }
    public int ObterLimite()
    {
        return Limite;
    }
}