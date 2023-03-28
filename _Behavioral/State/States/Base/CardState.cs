namespace State.States.Base;

public abstract class CardState {
    protected Card card;

    public CardState(Card card) => this.card = card;

    public abstract void SendMoney(Card receiver, decimal amount);

    public override string ToString() => this.GetType().Name;

    public static bool operator == (CardState left, CardState right) => left.GetType().Name == right.GetType().Name;
    public static bool operator != (CardState left, CardState right) => left.GetType().Name != right.GetType().Name;
}