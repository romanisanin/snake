using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Snake: Figure
    {
        Direction direction;
        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList[0];
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        internal bool isHitTail()
        {
            var head = pList[pList.Count-1];
            for (int i = 0; i < pList.Count - 2; i++)
            {
                if(head.isHit(pList[i]))
                    return true;
            }
            return false;
        }

        public Point GetNextPoint()
        {
            Point head = pList[pList.Count - 1];
            Point newPoint = new Point(head);
            newPoint.Move(1, direction);
            return newPoint;
        }

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.isHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
                return false;
        }
    }
}
