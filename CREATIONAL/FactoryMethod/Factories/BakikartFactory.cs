using FactoryMethod.Entities.Base;
using FactoryMethod.Entities.Cards;
using FactoryMethod.Factories.Base;

namespace FactoryMethod.Factories;

public class BakikartFactory : ICardFactory {
    public Card Create() {
        var random = new Random();

        return new TransportCard("Bakikart") {
            Amount = 2,
            FreeTrips = false,
            CardType = TransportCardType.passenger,
            CardNumber = $"{random.Next(10000, 100000)}-{random.Next(10000, 100000)}-{random.Next(0, 10)}",
        };
    }
}