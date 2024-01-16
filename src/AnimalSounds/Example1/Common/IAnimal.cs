namespace AnimalSounds.Example1.Common;

public interface IAnimal
{
    AnimalType Type { get; }
    void MakeSound();
}