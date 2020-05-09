namespace Abstract_Factory {
    class Program {
        static void Main(string[] args) {
            // Continents Init
            Continent africa = new AfricaContinent(new AfricaFactory());
            africa.AddAnimal<Herbivore>(40);
            africa.AddAnimal<Carnivore>(10);

            Continent northAmerica = new NorthAmericaContinent(new NorthAmericaFactory());
            northAmerica.AddAnimal<Herbivore>(30);
            northAmerica.AddAnimal<Carnivore>(8);

            // World Init
            AnimalWorld animalWorld = new AnimalWorld();
            animalWorld.Continents.AddRange(new Continent[] { africa, northAmerica });

            // Animals Life
            animalWorld.AllEat();
            animalWorld.AllBorn();
        }
    }
}
