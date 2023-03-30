namespace Weapon.Decorators;

using Weapon.Decorators.Base;
using Weapon.Models.Base;

public class ButtDecorator : WeaponDecorator {
    public ButtDecorator(Weapon wrappe) : base(wrappe) {
        this.accuracy = 10;
        this.mobility = -5;
    }
}