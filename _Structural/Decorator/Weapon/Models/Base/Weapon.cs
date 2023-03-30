namespace Weapon.Models.Base;

public abstract class Weapon {
    public virtual double Damage { get; set; }
    public virtual double Accuracy { get; set; }
    public virtual double Mobility { get; set; }

    public override string ToString()
    {
        return @$"{nameof(Damage)}: {this.Damage}
{nameof(Accuracy)}: {this.Accuracy}
{nameof(Mobility)}: {this.Mobility}";
    }
}