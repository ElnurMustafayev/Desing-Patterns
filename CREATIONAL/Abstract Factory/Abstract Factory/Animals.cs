using System;

namespace Abstract_Factory {
    // Травоядные животные:
    // Антилопа Гну
    public class Wildebeest : Herbivore {
        public Wildebeest() : base(weight: new Random().Next(50, 100), life: new Random().Next(50, 100)) {
            Console.WriteLine($"{this.GetType().Name} was born!");
        }
    }

    // Бизон 
    public class Bison : Herbivore {
        public Bison() : base(weight: new Random().Next(50, 100), life: new Random().Next(50, 100)) { }
    }

    // Плотоядные животные
    // Лев
    public class Lion : Carnivore {
        public Lion() : base(power: new Random().Next(80, 100)) { }
    }

    // Волк
    public class Wolf : Carnivore {
        public Wolf() : base(power: new Random().Next(80, 100)) { }
    }
}
