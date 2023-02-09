using FactoryMethod.Entities.Base;
using FactoryMethod.Entities.Cards;
using FactoryMethod.Factories.Base;

namespace FactoryMethod.Factories;

public class InvalidTransportCardFactory : ICardFactory {
    public Card Create() {
        return new TransportCard("Special Transport Card for Invalids") {
            FreeTrips = true,
            Amount = 0,
            CardType = TransportCardType.invalid,
            CardNumber = Guid.NewGuid().ToString("N"),
        };
    }
}