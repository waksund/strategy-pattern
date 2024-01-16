namespace AnimalSounds.Example3.Common;

public interface IAnimal
{
    static AnimalType Type { get; }
    void MakeSound();
}