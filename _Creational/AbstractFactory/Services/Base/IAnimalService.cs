using AbstractFactory.Entities.Base;

namespace AbstractFactory.Services.Base;

public interface IAnimalService {
    Animal GetCat(string name);
    Animal GetDog(string name);
}