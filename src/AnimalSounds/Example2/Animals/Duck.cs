using AnimalSounds.Example2.Common;
using Microsoft.Extensions.Logging;

namespace AnimalSounds.Example2.Animals;

public class Duck : IAnimal
{
    private readonly ILogger<Duck> _logger;

    public Duck(
        ILogger<Duck> logger)
    {
        _logger = logger;
        _logger.LogInformation("Duck was created");
    }
    
    public void MakeSound()
    {
        _logger.LogInformation("Quack");
    }
}