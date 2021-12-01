using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Figure
    {
        protected List<Point> pList;
        
        public virtual void Draw()
        {
            foreach (var p in pList)
            {
                p.Draw();
            }
        }

        internal bool isHit(Figure figure)
        {
            foreach(var p in pList)
            {
                if (figure.isHit(p))
                    return true;
            }
            return false;
        }

        private bool isHit(Point point)
        {
            foreach (var p in pList)
            {
                if(p.isHit(point))
                    return true;
            }
            return false;

        }

    }
}
