using System.Collections.Generic;

namespace Abstract_Factory {

    public abstract class Continent {
        public List<AnimalBase> Animals = new List<AnimalBase>();
        private IFactory factory;

        protected Continent(IFactory factory) => this.factory = factory;

        public void AddAnimal<T>(uint count) where T : AnimalBase {
            do {
                if(typeof(T) == typeof(Herbivore))
                    Animals.Add(factory.GetHerbivore());
                else if(typeof(T) == typeof(Carnivore))
                    Animals.Add(factory.GetCarnivore());
            } while(count-- > 0);
        }
    }

    public class AfricaContinent : Continent {
        public AfricaContinent(AfricaFactory factory) : base(factory) { }
    }

    public class NorthAmericaContinent : Continent {
        public NorthAmericaContinent(NorthAmericaFactory factory) : base(factory) { }
    }

}