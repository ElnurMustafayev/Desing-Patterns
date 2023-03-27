using State.States.Base;

namespace State.States;

public class CardOkState : CardState {
    public CardOkState(Card card) : base(card) {}

    public override void SendMoney(Card receiver, decimal amount) {
        base.card -= amount;
        receiver += amount;
        System.Console.WriteLine($"Transfer: [{base.card.Pan} => {receiver.Pan}]. Amount: {amount}");
    }
}