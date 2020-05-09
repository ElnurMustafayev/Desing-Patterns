namespace Abstract_Factory {
    public interface IFactory {
        Herbivore GetHerbivore();
        Carnivore GetCarnivore();
    }

    // ABSTRACT FACTORY
    public class AfricaFactory : IFactory {
        public Carnivore GetCarnivore() => new Lion();
        public Herbivore GetHerbivore() => new Wildebeest();
    }

    public class NorthAmericaFactory : IFactory {
        public Carnivore GetCarnivore() => new Wolf();
        public Herbivore GetHerbivore() => new Bison();
    } 
}
