using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Structural_Design_Pattern.Composite_02
{
    public class CompoundGraphic : IGraphic
    {
        List<IGraphic> graphicList = new List<IGraphic>();

        public void Add(IGraphic graphic)
        {
            graphicList.Add(graphic);
        }

        public void Remove(IGraphic graphic)
        {
            graphicList.Remove(graphic);
        }
        public void Draw()
        {
            foreach(IGraphic graphic in graphicList)
            {
                graphic.Draw();
            }
        }

        public void Move(int x, int y)
        {
            foreach (IGraphic graphic in graphicList)
            {
                graphic.Move(x, y);
            }
        }
    }
}
