namespace DesignPatternsExample.FactoryMethod.Models;
public class Carro : Veiculo
{
    public Carro(int limiteVelocidade)
    {
        Limite = limiteVelocidade;
    }
}