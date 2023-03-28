using FactoryMethod.Entities.Base;
using FactoryMethod.Entities.Cards;
using FactoryMethod.Factories.Base;

namespace FactoryMethod.Factories;

public class BircardSpecialFactory : ICardFactory {
    public Card Create() {
        var random = new Random();

        var card = new DebetCard("Kapitalbank Bircard Special", PaymentCardType.visa) {
            Amount = 0,
            Cashback = 5,
            CardNumber = DebetCard.GeneratePanNumber(),
        };

        return card;
    }
}