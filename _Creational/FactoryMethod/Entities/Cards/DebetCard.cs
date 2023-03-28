using FactoryMethod.Entities.Base;
using Microsoft.VisualBasic;
using System;

namespace FactoryMethod.Entities.Cards;

public enum PaymentCardType
{
    visa,
    mastercard
}

public class DebetCard : Card
{
    public decimal? Cashback { get; set; }
    public readonly PaymentCardType CardType;

    public DebetCard(string name, PaymentCardType cardType) : base(name)
    {
        CardType = cardType;
    }

    public static string GeneratePanNumber()
    {
        var random = new Random();
        return $"{random.Next(1000, 10000)} {random.Next(1000, 10000)} {random.Next(1000, 10000)} {random.Next(1000, 10000)}";
    }
}