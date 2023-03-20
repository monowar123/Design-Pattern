using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Structural_Design_Pattern.Composite_02
{
    public interface IGraphic
    {
        void Move(int x, int y);
        void Draw();
    }

    public class Dot : IGraphic
    {
        protected int x, y;

        public Dot(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual void Draw()
        {
            Console.WriteLine($"Draw a Dot with coordinate: {x}, {y}");
        }

        public void Move(int x, int y)
        {
            this.x += x;
            this.y += y;
        }
    }

    public class Circle : Dot
    {
        protected int radius;
        public Circle(int x, int y, int radius) : base(x, y)
        {
            this.radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"Draw a Circle with coordinate: {x}, {y} and radius: {radius}");
        }

    }
}
