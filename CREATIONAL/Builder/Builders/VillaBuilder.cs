using Builder.Builders.Base;
using Builder.Models;

namespace Builder.Builders;

public class VillaBuilder : IHouseBuilder {
    private House house = new House();
    public void BuildDecorations() {
        house.Decorations?.Add(new Decoration("Tree"));
        house.Decorations?.Add(new Decoration("Tree"));
        house.Decorations?.Add(new Decoration("Statue"));
        house.Decorations?.Add(new Decoration("Statue"));
        house.Decorations?.Add(new Decoration("Garden"));
    }

    public void BuildDoors() => this.house.DoorsCount = 3;
    public void BuildRooms() => this.house.RoomsCount = 5;
    public void BuildWindows() => this.house.WindowsCount = 8;
    public void SetHasGarage() => this.house.HasGarage = true;
    public void SetHasSwimmingPool() => this.house.HasSwimmingPool = true;
    
    public House GetResult() {
        var result = this.house;
        this.Reset();

        return result;
    }

    public void Reset() => this.house = new House();
}