namespace Weapon.Decorators.Base;

using Weapon.Models.Base;

public abstract class WeaponDecorator : Weapon {
    protected Weapon wrappe;

    protected double accuracy;
    protected double mobility;
    protected double damage;

    public override double Accuracy => this.wrappe.Accuracy + this.accuracy;
    public override double Damage => this.wrappe.Damage + this.damage;
    public override double Mobility => this.wrappe.Mobility + this.mobility;

    public WeaponDecorator(Weapon wrappe) => this.wrappe = wrappe;
}