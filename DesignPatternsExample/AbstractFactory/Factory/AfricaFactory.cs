using DesignPatternsExample.AbstractFactory.Models;

namespace DesignPatternsExample.AbstractFactory.Factory;
public class AfricaFactory : ContinenteFactory
{
    public override Carnivoro ObterCarnivoro()
    {
        return new Leao();
    }

    public override Herbivoro ObterHerbivoro()
    {
        return new Gazela();
    }
}