using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyQueue
{
    public class MyQueue<T>
    {
        private T[] _queue;

        private int _head;
        private int _tail;
        private int _size;

        public int Count => _size;

        public MyQueue(int capacity = 32) 
        {  
            _queue = new T[capacity];
            _head = 0;
            _tail = 0;
            _size = 0;
        }
        public T Dequeue()
        {
            if(_size == 0)
            {
                throw new InvalidOperationException();
            }
            T retValue = _queue[_head];
            _queue[_head] = default(T);
            _head = ++_head % _queue.Length;
            _size--;
            return retValue;
        }
        public void Enqueue(T item)
        {
            if(_size == _queue.Length)
            {
                Resize(_queue.Length * 2);
            }
            _queue[_tail] = item;
            _tail = ++_tail  % _queue.Length;
            _size++;
        }
        public T Peek()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException();
            }
            return _queue[_head];
        }
        public bool Contains(T item)
        {
            int num = _head;
            int size = _size;
            while (size-- > 0)
            {
                if (_queue[num] != null && _queue[num].Equals(item))
                {
                    return true;
                }

                num = ++num % _queue.Length;
            }

            return false;
        }
        private void Resize(int capacity)
        {
            T[] queue = new T[capacity];
            if (_head < _tail)
            {
                Array.Copy(_queue, _head, queue, 0, _size);
            }
            else
            {
                Array.Copy(_queue, _head, queue, 0, _queue.Length - _head);
                Array.Copy(_queue, 0, queue, _queue.Length - _head, _tail);
            }
            _queue = queue;
            _head = 0;
            _tail = (_size != capacity) ? _size : 0;
        }
    }
}
