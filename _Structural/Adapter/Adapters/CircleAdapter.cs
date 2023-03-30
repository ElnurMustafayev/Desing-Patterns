namespace Adapter.Adapters;

using Adapter.Adapters.Base;
using Adapter.Shapes;

public class CircleAdapter : IShapeAdapter {
    private Circle circle;

    public CircleAdapter(Circle circle) => this.circle = circle;

    public void Draw(double x1, double y1, double x2, double y2) {
        circle.Draw(x1, y1, radius: (x2 - x1) / 2);
    }
}