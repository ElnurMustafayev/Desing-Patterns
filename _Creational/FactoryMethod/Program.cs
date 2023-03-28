using FactoryMethod.Entities;
using FactoryMethod.Factories;
using FactoryMethod.Factories.Base;


ICardFactory cardFactory;

User invalidUser = new User("Nick", "Vujicic");


cardFactory = new InvalidTransportCardFactory();
invalidUser.Cards?.Add(cardFactory.Create());   // 'Special Transport Card for Invalids' was added

cardFactory = new SalaryCardFactory();
invalidUser.Cards?.Add(cardFactory.Create());   // 'Kapitalbank Visa Classic' was added


Console.WriteLine(invalidUser);