namespace AnimalSounds.Example1.Common;

public class AnimalFactory
{
    private readonly IEnumerable<IAnimal> _animals;

    public AnimalFactory(
        IEnumerable<IAnimal> animals)
    {
        _animals = animals;
    }

    public IAnimal GetAnimal(AnimalType animalType)
    {
        var animal = _animals.First(x =>
            x.Type == animalType);

        return animal;
    }
}