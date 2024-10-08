using System;
using System.Collections.Generic;

namespace Ufar.Homework
{
    public class EasyStack<T>
    {
        private List<T> _elements = new List<T>();

        // Pushes an item onto the top of this stack.
        public void Push(T item)
        {
            _elements.Add(item);
        }

        
        public T Pop()
        {
            if (_elements.Count == 0)
                throw new InvalidOperationException("Stack is empty.");

            T item = _elements[_elements.Count - 1];
            _elements.RemoveAt(_elements.Count - 1);
            return item;
        }

        public T Peek()
        {
            if (_elements.Count == 0)
                throw new InvalidOperationException("Stack is empty.");

            return _elements[_elements.Count - 1];
        }

        public int Count => _elements.Count;

        public bool IsEmpty => _elements.Count == 0;
    }
}