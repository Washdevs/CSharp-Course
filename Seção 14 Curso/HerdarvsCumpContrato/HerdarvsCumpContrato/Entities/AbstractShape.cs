using HerdarvsCumpContrato.Entities.Interfaces;
using HerdarvsCumpContrato.Enums;
namespace HerdarvsCumpContrato.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }
        public abstract double Area();
    }
}