using AnimalSounds.Example3.Animals;
using Microsoft.Extensions.DependencyInjection;

namespace AnimalSounds.Example3.Common;

public class AnimalFactory(IServiceProvider serviceProvider)
{
    public IAnimal GetAnimal(AnimalType animalType)
    {
        return serviceProvider.GetRequiredKeyedService<IAnimal>(animalType);
    }
}