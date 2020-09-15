using System;

namespace Factory_Method {
    class Program {
        static void Main(string[] args) {
            FiguresContainer container = new FiguresContainer();
            while(true) {
                container.GetRandomFigure().ShowFigure();
                Console.ReadKey(true);
                Console.Clear();
            }
        }
    }
}