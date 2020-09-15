using System;

namespace Factory_Method {
    public interface IFigureCreator { Figure GetFigure(); }

    // Factory Method

    // T Figure Factory
    public class TFigureFactory : IFigureCreator {
        public  Figure GetFigure() {
            Figure TFigure = new Figure();
            TFigure.ForegroundColor = ConsoleColor.Yellow;
            TFigure.FigureArray = FigureArrayClass.GetTFigure();
            return TFigure;
        }
    }

    // Z Figure Factory
    public class ZFigureFactory : IFigureCreator {
        public Figure GetFigure() {
            Figure ZFigure = new Figure();
            ZFigure.ForegroundColor = ConsoleColor.DarkRed;
            ZFigure.FigureArray = FigureArrayClass.GetZFigure();
            return ZFigure;
        }
    }

    // G Figure Factory
    public class GFigureFactory : IFigureCreator {
        public Figure GetFigure() {
            Figure GFigure = new Figure();
            GFigure.ForegroundColor = ConsoleColor.Blue;
            GFigure.FigureArray = FigureArrayClass.GetGFigure();
            return GFigure;
        }
    }

    // I Figure Factory
    public class IFigureFactory : IFigureCreator {
        public Figure GetFigure() {
            Figure IFigure = new Figure();
            IFigure.ForegroundColor = ConsoleColor.DarkBlue;
            IFigure.FigureArray = FigureArrayClass.GetIFigure();
            return IFigure;
        }
    }

    // Z Reverse Figure Factory
    public class ZReverseFigureFactory : IFigureCreator {
        public Figure GetFigure() {
            Figure ZReverseFigure = new Figure();
            ZReverseFigure.ForegroundColor = ConsoleColor.Green;
            ZReverseFigure.FigureArray = FigureArrayClass.GetZReverseFigure();
            return ZReverseFigure;
        }
    }

    // G Reverse Figure Factory
    public class GReverseFigureFactory : IFigureCreator {
        public Figure GetFigure() {
            Figure GReverseFigure = new Figure();
            GReverseFigure.ForegroundColor = ConsoleColor.DarkYellow;
            GReverseFigure.FigureArray = FigureArrayClass.GetGReverseFigure();
            return GReverseFigure;
        }
    }
}
