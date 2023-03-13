namespace Prototype.Models;

using System.Drawing;

public enum CarType {
    Sedan, Sport, Hatchback, Crossover
}

public class Car : ICloneable {
    public string? Model { get; set; }
    public CarType Type { get; set; }
    public int SitsCount { get; set; }
    public double MaxSpeed { get; set; }
    public KnownColor Color { get; set; }

    public object Clone() => this.MemberwiseClone();

    public override string ToString() => @$"Model: {this.Model}
Type: {this.Type}
Sits: {this.SitsCount}
Max Speed: {this.MaxSpeed}
Color: {this.Color}";
}