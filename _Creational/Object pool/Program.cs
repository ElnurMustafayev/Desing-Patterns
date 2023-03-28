using System;

namespace Object_pool {

    class Program {

        static void Main() {
            Console.SetWindowSize(100, 40);
            Console.WriteLine("Press enter to shot...");
            Console.CursorVisible = false;

            Weapon weapon = new Weapon(null);

            ConsoleKeyInfo button;
            do {
                weapon.Shoot();
                button = Console.ReadKey();
            } while(button.Key == ConsoleKey.Enter);
        }

    }

}
