using System;

namespace Factory_Method {
    public class Figure {
        public int[,] FigureArray = FigureArrayClass.GetDefaultFigure();
        public ConsoleColor ForegroundColor = ConsoleColor.Black; 
        public Figure() { }
        public void ShowFigure() => FigureArrayClass.ShowFigureString(this.FigureArray, this.ForegroundColor);
    }

    public static class FigureArrayClass {

        public static int[,] GetDefaultFigure() {
            return new int[4, 4]{
                { 0, 0, 0, 0, },
                { 0, 0, 0, 0, },
                { 0, 0, 0, 0, },
                { 0, 0, 0, 0, }
            };
        }

        public static int[,] GetTFigure() {
            return new int[4, 4]{
                { 0, 0, 0, 0, },
                { 0, 0, 0, 0, },
                { 0, 1, 0, 0, },
                { 1, 1, 1, 0, }
            };
        }

        public static int[,] GetZFigure() {
            return new int[4, 4]{
                { 0, 0, 0, 0, },
                { 0, 0, 0, 0, },
                { 1, 1, 0, 0, },
                { 0, 1, 1, 0, }
            };
        }

        public static int[,] GetGFigure() {
            return new int[4, 4]{
                { 0, 0, 0, 0, },
                { 0, 0, 0, 0, },
                { 1, 0, 0, 0, },
                { 1, 1, 1, 0, }
            };
        }

        public static int[,] GetIFigure() {
            return new int[4, 4]{
                { 1, 0, 0, 0, },
                { 1, 0, 0, 0, },
                { 1, 0, 0, 0, },
                { 1, 0, 0, 0, }
            };
        }

        public static int[,] GetZReverseFigure() {
            return new int[4, 4]{
                { 0, 0, 0, 0, },
                { 0, 0, 0, 0, },
                { 0, 1, 1, 0, },
                { 1, 1, 0, 0, }
            };
        }

        public static int[,] GetGReverseFigure() {
            return new int[4, 4]{
                { 0, 0, 0, 0, },
                { 0, 0, 0, 0, },
                { 1, 1, 1, 0, },
                { 1, 0, 0, 0, }
            };
        }

        public static void ShowFigureString(int[,] FigureArray, ConsoleColor color) {
            Console.ForegroundColor = color;
            Console.BackgroundColor = ConsoleColor.Black;
            for(int i = 0; i < FigureArray.GetLength(0); i++) {
                for(int j = 0; j < FigureArray.GetLength(1); j++) {
                    Console.Write(FigureArray[i, j] == 1 ? $"XX" : "  ");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }

    }
}
