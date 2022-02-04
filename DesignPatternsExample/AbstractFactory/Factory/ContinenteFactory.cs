using DesignPatternsExample.AbstractFactory.Models;

namespace DesignPatternsExample.AbstractFactory.Factory;
public abstract class ContinenteFactory
{
    public abstract Herbivoro ObterHerbivoro();
    public abstract Carnivoro ObterCarnivoro();
}