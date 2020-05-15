using System;

namespace Builder {
    class Program {
        static void Main(string[] args) {
            // Create Builder
            CarBuilder carBuilder = new CarBuilder();

            // Creator as variable
            CarCreatorBase carCreator = new DaewooLanosCarCreator();
            Car Daewoo = carBuilder.BuildCar(carCreator);
            carCreator = new FordProbeCarCreator();
            Car Ford = carBuilder.BuildCar(carCreator);

            // Creator as parameter
            Car Hyundai = carBuilder.BuildCar(new HyundaiGetzCarCreator());
            Car UAZ = carBuilder.BuildCar(new UAZPatriotCarCreator());

            Console.WriteLine(Ford);
            Console.WriteLine(UAZ);
        }
    }
}