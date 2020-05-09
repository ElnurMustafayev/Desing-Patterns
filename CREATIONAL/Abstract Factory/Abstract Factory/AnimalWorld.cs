using System;
using System.Collections.Generic;

namespace Abstract_Factory {
    public class AnimalWorld {
        public List<Continent> Continents { get; set; } = new List<Continent>();

        public void AllEat() {
            // In Continent
            this.Continents.ForEach(continent => {
                // Animals
                continent.Animals.ForEach(animal => {
                    // Herbivore animals
                    if(animal is Herbivore herbivore)
                        herbivore.EatGrass();
                    // Carnivore animals
                    else if(animal is Carnivore carnivore)
                        carnivore.Eat(continent.Animals.Find(animal => animal is Herbivore) as Herbivore);
                });
            });
        }

        public void AllBorn() {
            this.Continents.ForEach(continent => {
                continent.AddAnimal<Herbivore>((uint)new Random().Next(continent.Animals.Count / 8));
                continent.AddAnimal<Carnivore>((uint)new Random().Next(continent.Animals.Count / 8));
            });
        }
    }
}