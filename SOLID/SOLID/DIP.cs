using System;
using System.Collections.Generic;

// - - - - - D - I - P - - - - - -
// Dependency Inversion Principle
// Принцип инверсии зависимостей
// Зависимость на Абстракциях. Нет зависимости на что-то конкретное
namespace DIP {
    public interface IPower { void DoPower(BaseHero hero); }

    // DIP
    public class FlyPower : IPower {
        private int fly = 0;
        public void DoPower(BaseHero hero) {
            fly = fly == 0 ? 15 : fly--;
            hero.Position = new Tuple<int, int>(hero.Position.Item1 + fly, hero.Position.Item2);
        }
    }

    // DIP
    public class InvisibilityPower : IPower {
        public void DoPower(BaseHero hero) {
            hero.IsVisible = !hero.IsVisible;
        }
    }

    public abstract class BaseHero {
        public int Attack { get; set; }
        public int Hp { get; set; }
        public bool IsVisible { get; set; }
        public Tuple<int, int> Position { get; set; }

        protected BaseHero(int attack, int hp, bool isVisible, Tuple<int, int> position) {
            this.Attack = attack;
            this.Hp = hp;
            this.IsVisible = isVisible;
            this.Position = position;
        }
    }

    public class Hero : BaseHero {
        public List<IPower> Powers { get; set; }

        public Hero(int attack, int hp, bool isVisible, Tuple<int, int> position, List<IPower> powers) 
            : base(attack, hp, isVisible, position) {
            this.Powers = powers;
        }

        public void StartPower() => Powers.ForEach(p => p.DoPower(this));
    }
}
