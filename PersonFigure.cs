using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintCompGraph
{
    enum Figure
    {
        LINE,
        CURVE,
        OVAL,
        RECT,
        PEN
    }
    class PersonFigure
    {
        public Point pointStart;
        public Point pointEnd;
        public Figure figure;
        public Color color;
        public int width;
        public int height;
        public PersonFigure(Point pointStart, Point  pointEnd, Figure figure, Color color)
        {
            this.pointStart = pointStart;
            this.pointEnd = pointEnd;
            this.figure = figure;
            this.color = color;
            if (figure == Figure.RECT || figure == Figure.OVAL)
            {
                width = GetWight(pointStart, pointEnd);
                height = GetHeight(pointStart, pointEnd);
            }
        }

        public static double GetLen(Point pointA, Point pointB)
        {
            double len = Math.Sqrt(
                Math.Pow(pointB.X - pointA.X, 2) + Math.Pow(pointB.Y - pointA.Y, 2)
                );
            return len;
        }
        public static double GetAngle(Point pointA, Point pointB)
        {

            int y = Math.Abs(pointB.Y - pointA.Y);
            int x = Math.Abs(pointB.X - pointA.X);
            double alfa = 0;
            if (x != 0)
                alfa = y / x;
            double radians = Math.Atan(alfa);
            return radians * (180 / Math.PI);
        }

        public static int GetWight(Point pointA, Point pointB)
        {
            double angle = GetAngle(pointA, pointB);
            double c = GetLen(pointA, pointB);
            return (int)(c * Math.Sin(angle));
        }

        public static int GetHeight(Point pointA, Point pointB)
        {
            double angle = GetAngle(pointA, pointB);
            double c = GetLen(pointA, pointB);
            return (int)(c * Math.Cos(angle));
        }
    }
}
