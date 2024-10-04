using System;
using System.Collections.Generic;
namespace Generics.Services
{
    internal class PrintService
    {
        public List<int> _values = new List<int>();
        public void AddValue(int value)
        {
            _values.Add(value);
        }
        public int First()
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