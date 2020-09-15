using System;

namespace Object_pool {

    public class Bullet {
        private int y;
        private int x;

        public Bullet(int x = 0, int y = 0) {
            this.SetPosition(x, y);
        }

        // set bullet position after shoot
        public void SetPosition(int x, int y) {
            this.x = x;
            this.y = y;
        }

        // params: max bullet's random position value
        public void SetRandomPosition(int max_x = 100, int max_y = 40) {
            var randomizer = new Random();

            this.x = randomizer.Next(max_x) % 100;
            this.y = randomizer.Next(max_y) % 40;
        }

        // print shooted bullet on console
        public override string ToString() {
            Console.SetCursorPosition(this.x, this.y);
            return "x";
        }
    }
}
