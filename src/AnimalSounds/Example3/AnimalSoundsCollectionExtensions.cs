using AnimalSounds.Example3.Common;
using Microsoft.Extensions.DependencyInjection;

namespace AnimalSounds.Example3;

public static class AnimalSoundsCollectionExtensions
{
    public static IServiceCollection AddAnimals(this IServiceCollection services)
    {
        services.AddTransient<AnimalFactory>();
        
        var animals = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(assembly => assembly.GetTypes())
            .Where(type => typeof(IAnimal).IsAssignableFrom(type) && !type.IsInterface && !type.IsAbstract);

        foreach (var animal in animals)
        {
            AnimalType type = (AnimalType) animal!.GetProperty("Type")!.GetValue(null, null)!;
            services.AddKeyedTransient(typeof(IAnimal), type,animal);
        }
        
        return services;
    }
    
}