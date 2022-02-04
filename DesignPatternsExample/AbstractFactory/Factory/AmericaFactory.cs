using DesignPatternsExample.AbstractFactory.Models;

namespace DesignPatternsExample.AbstractFactory.Factory;

public class AmericaFactory : ContinenteFactory
{
    public override Carnivoro ObterCarnivoro()
    {
        return new Lobo();
    }

    public override Herbivoro ObterHerbivoro()
    {
        return new Coelho();
    }
}