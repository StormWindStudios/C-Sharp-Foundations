using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public interface ILinkedListGen<T>
    {
        LinkedListGen<T>.Node<T> First { get; }

        void AddLast(T value);
        bool Any();
        void Remove(T data);
    }
}
