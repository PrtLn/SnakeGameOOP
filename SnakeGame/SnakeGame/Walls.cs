using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            // drawing frame
            HorizontalLine lineUp = new HorizontalLine(0, mapWidth - 2, 0, '+');
            HorizontalLine lineDown = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
            VerticalLine lineRight = new VerticalLine(0, mapHeight - 1, 0, '+');
            VerticalLine lineLeft = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+');

            wallList.Add(lineUp);
            wallList.Add(lineDown);
            wallList.Add(lineLeft);
            wallList.Add(lineRight);
        }

        public void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.Drow();
            }
        }
    }
}
