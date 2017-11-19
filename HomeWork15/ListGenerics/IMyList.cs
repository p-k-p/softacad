using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListGenerics
{
    public interface IMyList<T>
    {
        int Count { get; }

        void Add(T element);

        bool Remove(T element);

        void RemoveAt(int index);

        T GetElement(int index);

        void SetElement(int index, T element);
    }
}
