using FactoryMethod.Entities.Base;

namespace FactoryMethod.Entities.Cards;

public class BonusCard : Card
{
    public decimal? DiscountPercentage { get; set; }

    public BonusCard(string name) : base(name) { }
}