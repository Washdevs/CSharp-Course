using System;
using System.Collections.Generic;
namespace Generics.Services
{
    internal class PrintService<T>
    {
        public List<T> _values = new List<T>();
        public void AddValue(T value)
        {
            _values.Add(value);
        }
        public T First()
        {
            if (_values.Count == 0)
            {
                throw new InvalidOperationException("A lista está vazia");
            }

            return _values[0];
        }
        public void Print()
        {
            Console.WriteLine("[" + string.Join(", ", _values) + "]");
        }
    }
}