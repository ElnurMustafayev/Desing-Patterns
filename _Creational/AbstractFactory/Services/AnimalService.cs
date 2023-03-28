using AbstractFactory.Entities.Base;
using AbstractFactory.Factories.Base;
using AbstractFactory.Services.Base;

namespace AbstractFactory.Services;

public class AnimalService : IAnimalService {
    public IFactory Factory { get; set; }

    public AnimalService(IFactory factory) {
        this.Factory = factory;
    }

    public Animal GetCat(string name) {
        return Factory.CreateCat(name);
    }

    public Animal GetDog(string name) {
        return Factory.CreateDog(name);
    }
}