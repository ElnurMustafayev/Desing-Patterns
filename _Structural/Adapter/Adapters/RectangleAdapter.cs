namespace Adapter.Adapters;

using Adapter.Adapters.Base;
using Adapter.Shapes;

public class RectangleAdapter : IShapeAdapter {
    private Rectangle rectangle;

    public RectangleAdapter(Rectangle rectangle) => this.rectangle = rectangle;

    public void Draw(double x1, double y1, double x2, double y2) {
        rectangle.Draw(
            x: x1, y: y2, 
            width: x2 - x1, 
            height: y2 - y1);
    }
}