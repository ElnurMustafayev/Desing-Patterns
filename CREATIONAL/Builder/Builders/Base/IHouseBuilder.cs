namespace Builder.Builders.Base;

using Builder.Models;

public interface IHouseBuilder : IBuilder<House> {
    void BuildWindows();
    void BuildDoors();
    void BuildRooms();
    void BuildDecorations();
    void SetHasGarage();
    void SetHasSwimmingPool();
}