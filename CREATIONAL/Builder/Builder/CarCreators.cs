using System.Linq;

namespace Builder {
    // CAR
    public abstract class CarCreatorBase {
        public string GetName() => GetCarName(this.GetType().Name);

        public abstract CarBody GetCarBody();
        public abstract Transmission GetTransmission();
        public abstract Engine GetEngine();
        public abstract Wheels GetWheels();

        private string GetCarName(string ClassName) {
            if(ClassName.Contains("CarCreator")) {
                // CarNameCarCreator => CarName
                string name = ClassName.Remove(ClassName.IndexOf("CarCreator"));
                // Fint index to split
                int whereToSplit = name.LastIndexOf(name.Last(symbol => char.IsUpper(symbol)));
                // CarName => Car Name
                return $"{name.Substring(0, whereToSplit)} {name.Substring(whereToSplit)}";
            }
            return ClassName;
        }
    }

    // DAEWOO LANOS
    public class DaewooLanosCarCreator : CarCreatorBase {
        public override CarBody GetCarBody() => new CarBody(new Sedan());
        public override Engine GetEngine() => new Engine(98);
        public override Wheels GetWheels() => new Wheels(13);
        public override Transmission GetTransmission() => new Transmission(5, Transmission.Variety.MANUAL);
    }

    // FORD PROBE
    public class FordProbeCarCreator : CarCreatorBase {
        public override CarBody GetCarBody() => new CarBody(new Cupe());
        public override Engine GetEngine() => new Engine(160);
        public override Wheels GetWheels() => new Wheels(14);
        public override Transmission GetTransmission() => new Transmission(4, Transmission.Variety.AUTO);
    }

    // UAZ PATRIOT
    public class UAZPatriotCarCreator : CarCreatorBase {
        public override CarBody GetCarBody() => new CarBody(new Universal());
        public override Engine GetEngine() => new Engine(120);
        public override Wheels GetWheels() => new Wheels(16);
        public override Transmission GetTransmission() => new Transmission(4, Transmission.Variety.MANUAL);
    }

    // HYUNDAI GETZ
    public class HyundaiGetzCarCreator : CarCreatorBase {
        public override CarBody GetCarBody() => new CarBody(new Hatchback());
        public override Engine GetEngine() => new Engine(66);
        public override Wheels GetWheels() => new Wheels(13);
        public override Transmission GetTransmission() => new Transmission(4, Transmission.Variety.AUTO);
    }
}