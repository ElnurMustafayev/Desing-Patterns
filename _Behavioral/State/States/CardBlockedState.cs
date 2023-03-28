using State.States.Base;

namespace State.States;

public class CardBlockedState : CardState {
    public CardBlockedState(Card card) : base(card) {}

    public override void SendMoney(Card receiver, decimal amount) => throw new Exception($"Card '{base.card.Pan}' is blocked!");
}