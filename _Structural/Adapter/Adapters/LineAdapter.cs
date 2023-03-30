namespace Adapter.Adapters;

using Adapter.Adapters.Base;
using Adapter.Shapes;

public class LineAdapter : IShapeAdapter {
    private Line line;

    public LineAdapter(Line line) => this.line = line;

    public void Draw(double x1, double y1, double x2, double y2) {
        line.Draw(x1, y1, x2, y2);
    }
}