namespace Builder {
    public class CarBuilder {
        public Car BuildCar(CarCreatorBase carCreator) {
            Car car = new Car();
            car.name = carCreator.GetName();
            car.body = carCreator.GetCarBody();
            car.engine = carCreator.GetEngine();
            car.transmission = carCreator.GetTransmission();
            car.wheels = carCreator.GetWheels();
            return car;
        }
    }
}