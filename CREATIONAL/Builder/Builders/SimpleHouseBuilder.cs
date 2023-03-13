namespace Builder.Builders;

using Builder.Builders.Base;
using Builder.Models;

public class SimpleHouseBuilder : IHouseBuilder {
    private House house = new House();

    public void BuildDecorations() {
        house.Decorations?.Add(new Decoration("Tree"));
        house.Decorations?.Add(new Decoration("Bush"));
    }

    public void BuildDoors() => this.house.DoorsCount = 1;
    public void BuildRooms() => this.house.RoomsCount = 2;
    public void BuildWindows() => this.house.WindowsCount = 2;
    public void SetHasGarage() => this.house.HasGarage = false;
    public void SetHasSwimmingPool() => this.house.HasSwimmingPool = false;
    
    public House GetResult() => this.house;
    public void Reset() => this.house = new House();
}