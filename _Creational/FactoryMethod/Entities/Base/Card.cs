namespace FactoryMethod.Entities.Base;

public abstract class Card {
    public decimal? Amount { get; set; }
    public string Name { get; set; }
    public string CardNumber { get; set; }

	public Card(string name) {
		this.Name = name;
	}
}