﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Laba2
{
    [Serializable]
    public class Triangle : Figure
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        protected Triangle() { }
        public Triangle(string name, double side1, double side2, double side3)
        {
            Title = "Треугольник";
            Name = name;
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }
        public Triangle(string name, double width, double height, 
                        int x, int y, Color color)
        {
            Title = "Треугольник";
            Name = name;
            Width = width;
            Height = height;
            X = x;
            Y = y;
            Color = color;
            Side1 = width;
            Side2 = Math.Sqrt((height * height) + (width * width / 4));
            Side3 = Side2;
        }

        // Переопределение нахождения периметра
        public override double Perimeter()
        {
            return Side1 + Side2 + Side3;
        }

        // Переопрелеление нахождения площади
        public override double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }
    }
}
