namespace Builder.Models;

public class House {
    public int WindowsCount { get; set; }
    public int DoorsCount { get; set; }
    public int RoomsCount { get; set; }

    public bool HasGarage { get; set; }
    public bool HasSwimmingPool { get; set; }
    public ICollection<Decoration>? Decorations { get; set; }

    public House() => this.Decorations = new List<Decoration>();

    // ⛔️⛔️⛔️ BAD PRACTICE:
    public House(int windowsCount, int doorsCount, int roomsCount, bool hasGarage, bool hasSwimmingPool, ICollection<Decoration>? decorations)
    {
        this.WindowsCount = windowsCount;
        this.DoorsCount = doorsCount;
        this.RoomsCount = roomsCount;
        this.HasGarage = hasGarage;
        this.HasSwimmingPool = hasSwimmingPool;
        this.Decorations = decorations;
    }
}