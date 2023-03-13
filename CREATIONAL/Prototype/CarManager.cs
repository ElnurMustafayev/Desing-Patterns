using System.Drawing;
using Prototype.Models;

namespace Prototype;

public class CarManager {
    public Dictionary<CarType, Car> Cars;

    public CarManager() {
        this.Cars = new Dictionary<CarType, Car>();

        // Sedan
        this.Cars.Add(
            key: CarType.Sedan,
            value: new Car() {
                Type = CarType.Sedan,
                SitsCount = 4,
                MaxSpeed = 220,
                Color = KnownColor.Black,
                Model = "Bmw",
            });

        // Sport
        this.Cars.Add(
            key: CarType.Sport, 
            value: new Car() {
                Type = CarType.Sport,
                SitsCount = 2,
                MaxSpeed = 340,
                Color = KnownColor.Red,
                Model = "Porsche",
            });

        // Hatchback
        this.Cars.Add(
            key: CarType.Hatchback, 
            value: new Car() {
                Type = CarType.Hatchback,
                SitsCount = 4,
                MaxSpeed = 200,
                Color = KnownColor.White,
                Model = "Hyundai",
            });
    }

    public Car this[CarType type] {
        get {
            if (this.Cars.ContainsKey(type) && this.Cars[type].Clone() is Car result)
                return result;

            throw new NotImplementedException($"Object not implemented for {type}");
        }
    }
}