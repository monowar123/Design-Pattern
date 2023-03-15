using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Structural_Design_Pattern.Decorator_02
{
    public interface IWidget
    {
        void Draw();
    }

    public class TextField : IWidget
    {
        int width, height;
        public TextField(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public void Draw()
        {
            Console.WriteLine($"TextField is drawn with width:{width}, height: {height}");
        }
    }
}
