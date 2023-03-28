using FactoryMethod.Entities.Base;

namespace FactoryMethod.Entities.Cards;

public enum TransportCardType
{
    passenger,
    invalid,
    student
}

public class TransportCard : Card
{
    public TransportCardType CardType { get; set; } = TransportCardType.passenger;
    public bool FreeTrips { get; set; } = false;

    public TransportCard(string name) : base(name) { }
}