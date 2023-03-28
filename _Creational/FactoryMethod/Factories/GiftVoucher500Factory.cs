using FactoryMethod.Entities.Base;
using FactoryMethod.Entities.Cards;
using FactoryMethod.Factories.Base;

namespace FactoryMethod.Factories;

public class GiftVoucher500Factory : ICardFactory {
    public Card Create() {
        decimal amount = 500;

        var card = new BonusCard($"MyBrands Gif Card - {amount}$") {
            Amount = amount,
            DiscountPercentage = 0,
            CardNumber = Guid.NewGuid().ToString()
        };

        return card;
    }
}