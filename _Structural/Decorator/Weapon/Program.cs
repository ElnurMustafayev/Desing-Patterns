namespace Weapon;

using Weapon.Decorators;
using Weapon.Models;
using Weapon.Models.Base;

class Program {
    private static void Main() {
        Weapon pistol = new Pistol();
        Console.WriteLine($"Simple Pistol: \n{pistol}\n");

        pistol = new AimDecorator(pistol);
        Console.WriteLine($"Pistol with Aim: \n{pistol}\n");

        pistol = new ButtDecorator(pistol);
        Console.WriteLine($"Pistol with Butt: \n{pistol}\n");

        pistol = new SilencerDecorator(pistol);
        Console.WriteLine($"Pistol with Silencer: \n{pistol}\n");
    }
}