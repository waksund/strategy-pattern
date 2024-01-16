using AnimalSounds.Example2.Common;
using Microsoft.Extensions.Logging;

namespace AnimalSounds.Example2.Animals;

public class Dog : IAnimal
{
    private readonly ILogger<Dog> _logger;

    public Dog(
        ILogger<Dog> logger)
    {
        _logger = logger;
        _logger.LogInformation("Dog was created");
    }
    
    public void MakeSound()
    {
        _logger.LogInformation("Barking");
    }
}