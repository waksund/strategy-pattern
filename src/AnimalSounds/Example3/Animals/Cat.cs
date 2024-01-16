using AnimalSounds.Example3.Common;
using Microsoft.Extensions.Logging;

namespace AnimalSounds.Example3.Animals;

public class Cat : IAnimal
{
    private readonly ILogger<Cat> _logger;

    public Cat(
        ILogger<Cat> logger)
    {
        _logger = logger;
        _logger.LogInformation("Cat was created");
    }
    
    public static AnimalType Type => AnimalType.Cat;

    public void MakeSound()
    {
        _logger.LogInformation("Meow");
    }
}