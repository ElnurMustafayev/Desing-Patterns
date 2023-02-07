using AbstractFactory.Entities.Animlas;
using AbstractFactory.Entities.Base;
using AbstractFactory.Factories.Base;

namespace AbstractFactory.Factories;

internal class AnimalFactory : IFactory {
    public Animal CreateCat(string name) {
        return new Cat(name);
    }

    public Animal CreateDog(string name) {
        return new Dog(name);
    }
}