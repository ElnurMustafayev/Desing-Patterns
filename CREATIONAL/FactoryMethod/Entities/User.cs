using FactoryMethod.Entities.Base;

namespace FactoryMethod.Entities;

public class User {
    public string? Name { get; set; }
    public string? Surname { get; set; }

    public ICollection<Card>? Cards { get; set; }

    public User(string? name, string? surname) {
        this.Name = name;
        this.Surname = surname;
        this.Cards = new List<Card>();
    }

    public override string ToString() {
        string cardNamesMessage = "Doesn't exist";
        if(this.Cards != null && this.Cards.Any()) {
            var cardNames = this.Cards.Select(card => card.Name);
            cardNamesMessage = string.Join('\n', cardNames);
        }

        return $@"Name: {this.Name}
Surname: {this.Surname}
- - - - - - - - - - - -
Cards: 
{cardNamesMessage}";
    }
}