using System;
using System.Collections.Generic;

namespace StackAndQueue
{
    public class Stack<T>
    {
        private readonly List<T> _stack;

        public T Top { get; set; }


        public Stack()
        {
            _stack = new List<T>();
        }

        public void Push(T value)
        {
            Top = value;

            _stack.Add(value);
        }

        public T Pop()
        {
            int count = _stack.Count;

            if (IsEmpty())
                return default;

            Top = count == 1 ? default : _stack[count - 1];

            T pop = _stack[count - 1];
            _stack.Remove(pop);

            return pop;
        }

        public T Peek()
        {
            int count = _stack.Count;

            if (IsEmpty())
                return default;

            return _stack[count - 1];
        }

        public bool IsEmpty()
        {
            if (_stack.Count == 0)
                return true;

            return false;
        }
    }
}
