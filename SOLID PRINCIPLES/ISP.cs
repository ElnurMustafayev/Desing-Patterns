using System;

// Принцип разделения интерфейсов
// Interface Segregation Principle
/*
    Не создавай супер интерфейсы,
    Лучше раздели их на логические части!
*/
namespace ISP {
    // ⛔⛔⛔
    // Создадим один какой-то супер интерфейс, описывающий в общем поведение многих птиц
    public interface IBird {
        void Fly();
        void Walk();
        void Swim();
    }

    // Создадим класс, который логически удовлетворяет потребностям интерфейса - тут всё окей
    public class Swan : IBird
    {
        public void Fly()
        {
            System.Console.WriteLine("Swan flies");
        }

        public void Swim()
        {
            System.Console.WriteLine("Swan swims");
        }

        public void Walk()
        {
            System.Console.WriteLine("Swan walks");
        }
    }

    // Курица тоже является птицей, но толком летать и плавать она не умеет!
    // В двух методах придется писать или пустую реализацию или возвращать NotImplemented. Ужас
    public class Chicken : IBird
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Swim()
        {
            throw new NotImplementedException();
        }

        public void Walk()
        {
            System.Console.WriteLine("Chicken walks");
        }
    }

    // ✅✅✅
    // Разделим интерфейс на составляющие, в которых каждый будет отвечать за что-то одно
    public interface IFly {
        void Fly();
    }
    public interface ISwim {
        void Swim();
    }
    public interface IWalk {
        void Walk();
    }

    // Теперь создавая любой класс птицы нам необходимо будет реализовать лишь только нужные интерфейсы для конкретного класса
    // фламинго не умеет летать - не будет реализовывать этот функционал для его класса
    public class Flamingo : IWalk, ISwim
    {
        public void Swim()
        {
            System.Console.WriteLine($"Flamingo swims");
        }

        public void Walk()
        {
            System.Console.WriteLine($"Flamingo walks");
        }
    }
    // Попугай не может плавать - ну и не надо!
    public class Parrot : IWalk, IFly
    {
        public void Fly()
        {
            System.Console.WriteLine($"Parrot swims");
        }

        public void Walk()
        {
            System.Console.WriteLine($"Parrot walks");
        }
    }
}