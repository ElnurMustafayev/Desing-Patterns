namespace Weapon.Decorators;

using Weapon.Decorators.Base;
using Weapon.Models.Base;

public class SilencerDecorator : WeaponDecorator {
    public SilencerDecorator(Weapon wrappe) : base(wrappe) {
        this.accuracy = 10;
        this.damage = -5;
        this.mobility = -1;
    }
}