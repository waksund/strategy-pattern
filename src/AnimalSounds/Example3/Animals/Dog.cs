using AnimalSounds.Example3.Common;
using Microsoft.Extensions.Logging;

namespace AnimalSounds.Example3.Animals;

public class Dog : IAnimal
{
    private readonly ILogger<Dog> _logger;

    public Dog(
        ILogger<Dog> logger)
    {
        _logger = logger;
        _logger.LogInformation("Dog was created");
    }
    
    public static AnimalType Type => AnimalType.Dog;
    
    public void MakeSound()
    {
        _logger.LogInformation("Barking");
    }
}