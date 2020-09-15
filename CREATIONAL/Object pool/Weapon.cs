using System;
using System.Collections.Generic;

namespace Object_pool {

    public class Weapon {
        private Queue<Bullet> magazine = new Queue<Bullet>();
        private int magazineMaxSize = 30;

        public Weapon(int? magazineCapacity) {
            this.magazine = new Queue<Bullet>(magazineCapacity ?? 10);
            this.FillMagazine(magazineCapacity ?? 10);
        }

        // fill magazine with bullets
        private Queue<Bullet> FillMagazine(int size) {
            size %= magazineMaxSize;
            int magazineSize = magazine.Count;

            return size < magazineSize
                ? this.RemoveBullets(magazineSize - size)
                : this.AddBullets(size - magazineSize);
        }

        // add bullets in magazine
        private Queue<Bullet> AddBullets(int count) {
            count = Math.Abs(count) % this.magazineMaxSize;

            for(int i = 0; i < count; i++)
                this.magazine.Enqueue(new Bullet());

            return this.magazine;
        }

        // remove bullets from magazine
        private Queue<Bullet> RemoveBullets(int count) {
            count = Math.Abs(count) % this.magazine.Count;

            for(int i = 0; i < count; i++)
                this.magazine.Dequeue();

            return this.magazine;
        }

        // weapon shot
        public Weapon Shoot() {
            // bullet comes out of the store
            var bullet = this.magazine.Dequeue();

            // set random position
            bullet.SetRandomPosition();

            // print shooted bullet
            Console.Write(bullet);

            // Object pool pattern
            // there is no matter to create new bullet
            this.magazine.Enqueue(bullet);

            return this;
        }
    }

}
