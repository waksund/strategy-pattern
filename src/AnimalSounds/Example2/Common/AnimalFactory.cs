using AnimalSounds.Example2.Animals;
using Microsoft.Extensions.DependencyInjection;

namespace AnimalSounds.Example2.Common;

public class AnimalFactory(IServiceProvider serviceProvider)
{
    public IAnimal GetAnimal(AnimalType animalType)
    {
        IAnimal? animal = animalType switch
        {
            AnimalType.Cat => GetAnimal<Cat>(),
            AnimalType.Dog => GetAnimal<Dog>(),
            AnimalType.Duck => GetAnimal<Duck>(),
            _ => throw new ArgumentOutOfRangeException(nameof(animalType), animalType, null)
        };

        if (animal == null)
            throw new Exception($"unknown type '${animalType}'");

        return animal;
    }
    
    private T? GetAnimal<T>() where T : class, IAnimal
    {
        return serviceProvider.GetRequiredService(typeof(T)) as T;
    }
}