using DesignPatternsExample.FactoryMethod.Models;

namespace DesignPatternsExample.FactoryMethod.Factory;
public abstract class VeiculoFactory
{
    public abstract Veiculo Criar(Categoria categoria);
}