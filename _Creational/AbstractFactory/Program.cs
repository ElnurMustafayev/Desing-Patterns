using AbstractFactory.Factories;
using AbstractFactory.Factories.Base;
using AbstractFactory.Services;
using AbstractFactory.Services.Base;

IFactory animalFactory = new AnimalFactory();
IAnimalService animalService = new AnimalService(animalFactory);

animalService.GetCat("Rijik").Say();
animalService.GetDog("Barsik").Say();



IFactory zombieFactory = new ZombieAnimalFactory();
IAnimalService zombieService = new AnimalService(zombieFactory);

zombieService.GetCat("Rijik").Say();
zombieService.GetDog("Barsik").Say();