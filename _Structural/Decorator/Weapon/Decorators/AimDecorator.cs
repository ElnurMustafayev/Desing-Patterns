namespace Weapon.Decorators;

using Weapon.Decorators.Base;
using Weapon.Models.Base;

public class AimDecorator : WeaponDecorator {
    public AimDecorator(Weapon wrappe) : base(wrappe) {
        this.accuracy = 20;
        this.mobility = -3;
    }
}