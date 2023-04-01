namespace Builder.Builders.Base;

using Builder.Models;

public interface IHouseBuilder : IBuilder<House> {
    HouseBuilder BuildWalls(int count);
    HouseBuilder BuildWindows(int count);
    HouseBuilder BuildDoors(int count);
    HouseBuilder BuildRoof();
    HouseBuilder BuildGarage();
    HouseBuilder BuildSwimmingPool();
    HouseBuilder PlantDecoration(Decoration decoration);
}