using System;

namespace Abstract_Factory {
    public class AnimalBase {
        public AnimalBase() => Console.WriteLine($"{this.GetType().Name} was born!");
    }

    // Травоядное животное
    public abstract class Herbivore : AnimalBase {
        public double Weight { get; private set; }
        public double Life { get; private set; }

        protected Herbivore(double weight, double life) {
            this.Weight = weight;
            this.Life = life;
        }

        public virtual void EatGrass() => this.Weight += 10;
    }

    // Плотоядное животное
    public abstract class Carnivore : AnimalBase {
        public double Power { get; private set; }

        protected Carnivore(double power) : base() => this.Power = power;

        public virtual void Eat(Herbivore animal) {
            if(animal != null && this.Power > animal.Weight) {
                this.Power += 10;
                Console.WriteLine($"{animal.GetType().Name} dead!");
            }
            else {
                this.Power -= 10;
                Console.WriteLine($"{this.GetType().Name} become weak!");
            }
        }
    }
}
