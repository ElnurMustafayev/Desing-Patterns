using FactoryMethod.Entities.Base;
using FactoryMethod.Entities.Cards;
using FactoryMethod.Factories.Base;

namespace FactoryMethod.Factories;

public class BircardBlackFactory : ICardFactory {
    public Card Create() {
        var random = new Random();

        var card = new DebetCard("Kapitalbank Bircard Black", PaymentCardType.mastercard) {
            Amount = 0,
            Cashback = 1,
            CardNumber = DebetCard.GeneratePanNumber(),
        };

        return card;
    }
}
