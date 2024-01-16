using AnimalSounds.Example3.Common;
using Microsoft.Extensions.Logging;

namespace AnimalSounds.Example3.Animals;

public class Duck : IAnimal
{
    private readonly ILogger<Duck> _logger;

    public Duck(
        ILogger<Duck> logger)
    {
        _logger = logger;
        _logger.LogInformation("Duck was created");
    }
    
    public static AnimalType Type => AnimalType.Duck;
    
    public void MakeSound()
    {
        _logger.LogInformation("Quack");
    }
}