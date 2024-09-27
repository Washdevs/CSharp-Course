using System;
using HerdarvsCumpContrato.Entities;
using HerdarvsCumpContrato.Enums;
namespace HerdarvsCumpContrato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractShape s1 = new Circle() { Radius = 2.0, Color = Color.Green };
            AbstractShape s2 = new Rectangle() {Height = 30.5, Width = 30.5, Color = Color.White };
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}