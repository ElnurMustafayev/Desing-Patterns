// - - - - - L - S - P - - - - - -
// Liskov Substitution Principle
// Принцип подстановки Лисков
// Сущность обекта класса выражается через интерфейсы
namespace LSP {
    public interface IPower { }

    public interface IFly : IPower {
        void ToFly();
    }
    public interface IInvisibility : IPower {
        void ToInvis();
    }

    // LSP
    public class Hero : IFly, IInvisibility {
        private int positionY = 0;
        private bool isVisible = true;

        public void ToFly() => positionY = positionY == 30 ? 0 : 30;
        public void ToInvis() => isVisible = !isVisible;
    }
}