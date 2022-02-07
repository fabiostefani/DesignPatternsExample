namespace DesignPatternsExample.FactoryMethod.Models;
public class Caminhao : Veiculo
{
    public Caminhao(int limiteVelocidade)
    {
        Limite = limiteVelocidade;
    }
}