using System;

namespace Builder {
    public class Car {
        public string name;

        public CarBody body;
        public Engine engine;
        public Wheels wheels;
        public Transmission transmission;

        public override string ToString() {
            Console.WriteLine($"================== {name.ToUpper()} ==================");
            Console.WriteLine($"Body: {body.bodyVariety.Name}\n");
            Console.WriteLine($"Engine: {engine.power} l.\n");
            Console.WriteLine($"Wheels: \nCount:{wheels.wheelsCount}\tRadius:{wheels.radius} sm.\n");
            Console.WriteLine($"Transmission: \nVariety:{transmission.variety}\tSpeeds:{transmission.speeds}\n");
            return string.Empty;
        }
    }
}