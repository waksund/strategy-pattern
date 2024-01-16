using AnimalSounds.Example3;
using AnimalSounds.Example3.Common;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

IServiceCollection services = new ServiceCollection();
services.AddLogging(c =>
{
    c.AddConsole();
});

services.AddAnimals();

ServiceProvider provider = services.BuildServiceProvider();
AnimalFactory factory = provider.GetRequiredService<AnimalFactory>();
IAnimal cat = factory.GetAnimal(AnimalType.Cat);
cat.MakeSound();