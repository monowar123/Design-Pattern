using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Structural_Design_Pattern.Decorator_02
{
    public interface IWidgetDecorator
    {
        void DrawWithFeature();
    }

    public class BorderDecorator : IWidgetDecorator
    {
        IWidget widget;
        public BorderDecorator(IWidget widget)
        {
            this.widget = widget;
        }
        public void DrawWithFeature()
        {
            widget.Draw();
            Console.WriteLine("Border Added with widget");
        }
    }

    public class ScrollbarDecorator : IWidgetDecorator
    {
        IWidget widget;
        public ScrollbarDecorator(IWidget widget)
        {
            this.widget = widget;
        }
        public void DrawWithFeature()
        {
            widget.Draw();
            Console.WriteLine("Scrollbar Added with widget");
        }
    }
}
