using AbstractFactory.Entities.Base;
using AbstractFactory.Entities.Zombies;
using AbstractFactory.Factories.Base;

namespace AbstractFactory.Factories;

internal class ZombieAnimalFactory : IFactory {
    public Animal CreateCat(string name) {
        return new ZombieCat(name);
    }

    public Animal CreateDog(string name) {
        return new ZombieDog(name);
    }
}