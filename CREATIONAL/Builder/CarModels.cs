namespace Builder {
    // CAR
    public interface ICarModel { }

    // BODY
    public class CarBody : ICarModel {
        public CarBodyVariety bodyVariety;

        public CarBody(CarBodyVariety bodyVariety) {
            this.bodyVariety = bodyVariety;
        }
    }

    // ENGINE
    public class Engine : ICarModel {
        public ushort power;

        public Engine(ushort power) {
            this.power = power;
        }
    }

    // WHEELS
    public class Wheels : ICarModel {
        public sbyte radius;
        public sbyte wheelsCount;


        public Wheels(sbyte radius, sbyte wheelsCount = 4) {
            this.radius = radius;
            this.wheelsCount = wheelsCount;
        }
    }

    // TRANSMISSION (К.П.П.)
    public class Transmission : ICarModel {
        public enum Variety { AUTO, MANUAL };

        public sbyte speeds;
        public Variety variety;

        public Transmission(sbyte speeds, Variety variety) {
            this.speeds = speeds;
            this.variety = variety;
        }
    }
}