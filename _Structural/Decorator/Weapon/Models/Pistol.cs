namespace Weapon.Models;

using Weapon.Models.Base;

public class Pistol : Weapon {
    public Pistol() {
        this.Damage = 20;
        this.Accuracy = 15;
        this.Mobility = 65;
    }
}