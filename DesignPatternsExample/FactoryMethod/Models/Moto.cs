namespace DesignPatternsExample.FactoryMethod.Models;
public class Moto : Veiculo
{
    public Moto(int limiteVelocidade)
    {
        Limite = limiteVelocidade;
    }
}