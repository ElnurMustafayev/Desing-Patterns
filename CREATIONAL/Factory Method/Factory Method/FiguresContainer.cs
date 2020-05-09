using System;
using System.Collections.Generic;

namespace Factory_Method {
    public class FiguresContainer {
        public List<IFigureCreator> Creators { get; set; }

        public FiguresContainer() {
            this.Creators = new List<IFigureCreator>();
            this.Creators.AddRange(new IFigureCreator[] {
                new TFigureFactory(), new ZFigureFactory(),
                new GFigureFactory(), new IFigureFactory(),
                new ZReverseFigureFactory(), new GReverseFigureFactory()
            });
        }

        public Figure GetRandomFigure() => this.Creators[new Random().Next(this.Creators.Count)].GetFigure();
    }
}