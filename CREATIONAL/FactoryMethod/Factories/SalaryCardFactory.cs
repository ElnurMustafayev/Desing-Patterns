using FactoryMethod.Entities.Base;
using FactoryMethod.Entities.Cards;
using FactoryMethod.Factories.Base;

namespace FactoryMethod.Factories;

public class SalaryCardFactory : ICardFactory {
    public Card Create() {
        return new DebetCard("Kapitalbank Visa Classic", PaymentCardType.mastercard) {
            Amount = 0,
            Cashback = 0,
            CardNumber = DebetCard.GeneratePanNumber(),
        };
    }
}