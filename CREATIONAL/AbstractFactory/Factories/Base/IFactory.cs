using AbstractFactory.Entities.Base;

namespace AbstractFactory.Factories.Base;

public interface IFactory {
    Animal CreateCat(string name);
    Animal CreateDog(string name);
}