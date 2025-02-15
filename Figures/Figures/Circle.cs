﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Laba2
{
    [Serializable]
    public class Circle : Ellipse
    {
        private Circle() { }
        public Circle(string name, double radius, 
                      int x, int y, Color color)
        {
            Title = "Круг";
            Name = name;
            Width = 2 * radius;
            Height = 2 * radius;
            SemiaxisBig = radius;
            X = x;
            Y = y;
            Color = color;
        }

        // Переопределение нахождения периметра
        public override double Perimeter()
        {
            return 2 * 3.14 * SemiaxisBig;
        }

        // Переопрелеление нахождения площади
        public override double Area()
        {
            return 3.14 * SemiaxisBig * SemiaxisBig;
        }
    }
}
