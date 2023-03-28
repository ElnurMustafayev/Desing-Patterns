using System.Text;
using State.States;
using State.States.Base;

namespace State;

public class Card {
    public const int CardPanMaxLength = 16;

    public readonly string Pan;
    public decimal Amount { get; set; } = 0;
    protected CardState state;

    public Card() {
        this.Pan = Card.GeneratePanNumber()!;
        this.state = new CardOkState(this);
    }

    protected virtual void ChangeStatus(CardState stateToChange) {
        if(this.state.GetType() == stateToChange.GetType())
            return;

        System.Console.WriteLine($"[{this.Pan}] status change: '{this.state}' => '{stateToChange}'");

        this.state = stateToChange;
    }

    public void Block() {
        this.ChangeStatus(new CardBlockedState(this));
    }

    public void Unblock() {
        this.ChangeStatus(new CardOkState(this));
    }

    // Send money by STATE
    public void SendMoney(Card receiver, decimal amount) => this.state.SendMoney(receiver, amount);

    public static string? GeneratePanNumber() {
        var rand = new Random();
        StringBuilder str = new StringBuilder(capacity: Card.CardPanMaxLength);
        while(str.Length < Card.CardPanMaxLength) {
            str.Append(rand.Next(maxValue: 9));
        }

        return str.ToString();
    }

    public override string ToString() => $"Pan: [{this.Pan}]\nAmount: {this.Amount}\nStatus: {this.state.GetType().Name}";

    public static Card operator - (Card card, decimal amount) {
        if(card.Amount - amount < 0) {
            throw new Exception(message: $"Card balance of '{card.Pan}' can not be less than 0! Amount: {card.Amount - amount}");
        }

        card.Amount -= amount;

        return card;
    }

    public static Card operator + (Card card, decimal amount) {
        card.Amount += amount;

        return card;
    }
}