using System;

namespace Ufar.Homework
{
    public class ArrayStack<T>
    {
        private T[] _elements;
        private int _size;
        private const int DefaultCapacity = 4;

        public ArrayStack()
        {
            _elements = new T[DefaultCapacity];
        }

        public void Push(T item)
        {
            if (_size == _elements.Length)
            {
                Resize(_elements.Length * 2);
            }
            _elements[_size++] = item;
        }

        public T Pop()
        {
            if (_size == 0)
                throw new InvalidOperationException("Stack is empty.");

            T item = _elements[--_size];
            _elements[_size] = default(T); // Clear the reference

            if (_size > 0 && _size == _elements.Length / 4)
            {
                Resize(_elements.Length / 2);
            }

            return item;
        }

        public T Peek()
        {
            if (_size == 0)
                throw new InvalidOperationException("Stack is empty.");

            return _elements[_size - 1];
        }

        public int Count => _size;

        public bool IsEmpty => _size == 0;

        private void Resize(int newCapacity)
        {
            T[] newArray = new T[newCapacity];
            Array.Copy(_elements, newArray, _size);
            _elements = newArray;
        }
    }
}