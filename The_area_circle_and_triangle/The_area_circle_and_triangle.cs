using System;

namespace The_area_circle_and_triangle
{
    public class The_area_circle_and_triangle_c
    {
        // Вычисление площади круга по радиусу
        public static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
        // Вычисление площади треугольника по трем сторонам
        public static double CalculateTriangleArea(double side1, double side2, double side3)
        {
            // Полупериметр
            double s = (side1 + side2 + side3) / 2;
            // Формула Герона для вычисления площади треугольника по его сторонам
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }
        // Проверка, является ли треугольник прямоугольным
        public static bool IsRightTriangle(double side1, double side2, double side3)
        {
            double[] sides = { side1, side2, side3 };
            Array.Sort(sides);
            return sides[2] * sides[2] == sides[0] * sides[0] + sides[1] * sides[1];
        }
    }
}
