

using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.Algs
{
    public class BasicStack<T> : IEnumerable<T>
    {
        private T[] data;
        private int size;

        public BasicStack(int size)
        {
            data = new T[size];
        }

        public BasicStack() : this(1000)
        {
        }

        public void Push(T item)
        {
            if (size == data.Length)
            {
                throw new InvalidOperationException("no more space in the stack");
            }

            data[size++] = item;
        }

        public T Pop()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("no item in the stack");
            }

            return data[--size];
        }

        public T Peak()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("no item left in the stack");
            }

            return data[size - 1];
        }

        public int Size()
        {
            return size;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = size - 1; i >= 0; i--)
            {
                yield return data[i];
            }
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
