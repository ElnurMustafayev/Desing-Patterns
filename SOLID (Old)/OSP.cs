// - - - - - O - S - P - - - - - -
// Open/Closed Principle
// Принцип открытости/закрытости
// Классы должны быть открыты для расширения, но закрыты для модификации
namespace OSP {
    public abstract class Weapon {
        public readonly double Attack;
        public readonly double Accuracy;

        protected Weapon(double attack, double accuracy) {
            this.Attack = attack;
            this.Accuracy = accuracy;
        }
    }

    // Weapons
    public class Kalashnikov : Weapon { public Kalashnikov() : base(30.5, 12.2) { } }
    public class Rpg : Weapon { public Rpg() : base(85.5, 3.2) { } }

    public class Soldier {
        public Weapon Weapon { get; set; }
        public Soldier(Weapon weapon) => Weapon = weapon;
    }

    public class Barracks {
        // OSP
        public Soldier GetSoldier(Weapon weapon) => new Soldier(weapon);
    }
}