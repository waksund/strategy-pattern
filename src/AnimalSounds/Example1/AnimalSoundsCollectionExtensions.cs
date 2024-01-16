using AnimalSounds.Example1.Animals;
using AnimalSounds.Example1.Common;
using Microsoft.Extensions.DependencyInjection;

namespace AnimalSounds.Example1;

public static class AnimalSoundsCollectionExtensions
{
    public static IServiceCollection AddAnimals(this IServiceCollection services)
    {
        services.AddTransient<AnimalFactory>();
        
        var animals = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(assembly => assembly.GetTypes())
            .Where(type => typeof(IAnimal).IsAssignableFrom(type) && !type.IsInterface && !type.IsAbstract);

        foreach (var animal in animals)
            services.AddTransient(typeof(IAnimal), animal);
        
        return services;
    }
}