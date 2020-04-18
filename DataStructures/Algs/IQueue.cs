
using System.Collections.Generic;

namespace DataStructures.Algs
{
    public interface IQueue<T> : IEnumerable<T>
    {
        int Size();
        void Enqueue(T item);
        T Dequeue();
        bool Contains(T item);
        T Access(int position);
    }
}
