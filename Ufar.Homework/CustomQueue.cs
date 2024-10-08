using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ufar.Homework
{
    public class CustomQueue<T>
    {
        private T[] _elements;
        private int _head;
        private int _tail;
        private int _size;
        private const int DefaultCapacity = 4;

        public CustomQueue()
        {
            _elements = new T[DefaultCapacity];
            _head = 0;
            _tail = 0;
            _size = 0;
        }

        
        public void Enqueue(T item)
        {
            if (_size == _elements.Length)
            {
                Resize(_elements.Length * 2);
            }

            _elements[_tail] = item;
            _tail = (_tail + 1) % _elements.Length;
            _size++;
        }

        
        public T Dequeue()
        {
            if (_size == 0)
                throw new InvalidOperationException("Queue is empty.");

            T item = _elements[_head];
            _elements[_head] = default(T); 
            _head = (_head + 1) % _elements.Length;
            _size--;

            if (_size > 0 && _size == _elements.Length / 4)
            {
                Resize(_elements.Length / 2);
            }

            return item;
        }

        
        public T Peek()
        {
            if (_size == 0)
                throw new InvalidOperationException("Queue is empty.");

            return _elements[_head];
        }

       
        public int Count => _size;

        
        public bool IsEmpty => _size == 0;

        
        private void Resize(int newCapacity)
        {
            T[] newArray = new T[newCapacity];
            for (int i = 0; i < _size; i++)
            {
                newArray[i] = _elements[(_head + i) % _elements.Length];
            }
            _elements = newArray;
            _head = 0;
            _tail = _size;
        }
    }
}
