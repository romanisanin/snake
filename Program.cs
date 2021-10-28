using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach (var i in numList)
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt(0);


            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            List<Char> charList = new List<Char>();
            charList.Add('*');
            charList.Add('.');

            List<int> intList = new List<int>();
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            intList.Add(4);

            foreach (var i in intList)
            {
                Console.WriteLine(i + 5);
            }

            Console.ReadLine();
         }
    }
}
