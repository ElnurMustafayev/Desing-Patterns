using State;

Card first = new Card();
first += 100;

Card second = new Card();

first.SendMoney(second, 70);

System.Console.WriteLine(first);
System.Console.WriteLine(second);

System.Console.WriteLine("- - - - - - - - - - - - - - -");

// change status to 'CardBlockedState'
first.Block();

try {
    first.SendMoney(second, 10);
}
catch(Exception ex) {
    System.Console.WriteLine($"Error: '{ex.Message}'");
}

System.Console.WriteLine(first);
System.Console.WriteLine(second);