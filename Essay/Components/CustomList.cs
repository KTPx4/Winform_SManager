using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essay.Components
{
    public class ListEnum<T> : IEnumerator
    {
        public T[] _items;

        int position = -1;

        public ListEnum(T[] list)
        {
            _items = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _items.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public T Current
        {
            get
            {
                try
                {
                    return _items[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
    public class CustomList<T> : IEnumerable
    {
        private T[] items;
        private int maxLength;
        private int nextIndex;

        public int getMaxLength() => maxLength;

        public CustomList()
        {
            maxLength = 1;
            items = new T[maxLength];
            nextIndex = 0;
        }

        public CustomList(int length)
        {
            maxLength = length;
            items = new T[maxLength];
            nextIndex = 0;
        }

        private void ResizeArray()
        {
            int newCapacity = 1;
            if (maxLength > 0)
            {
                newCapacity = maxLength * 2;
            }
            T[] newItems = new T[newCapacity]; ;
            Array.Copy(items, newItems, nextIndex);
            maxLength = newCapacity;
            items = newItems;
        }

        public void Add(T item)
        {
            if (nextIndex >= maxLength)
            {
                ResizeArray();
            }
            items[nextIndex++] = item;
        }

        public bool Remove(T item)
        {
            int id = Array.IndexOf(items, item);
            if (id >= 0)
            {
                for (int i = id; i < nextIndex - 1; i++)
                {
                    items[i] = items[i + 1];

                }
                nextIndex--;
                items[nextIndex] = default(T);
                return true;
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator) GetEnumerator();
        }
        public ListEnum<T> GetEnumerator()
        {
            return new ListEnum<T>(items);
        }

        public T this[int index] //https://learn.microsoft.com/en-Us/dotnet/csharp/programming-guide/indexers/
        {
            get
            {
                if (index < 0 || index >= nextIndex)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }

                return items[index];
            }
            set
            {
                if (index < 0 || index >= nextIndex)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }

                items[index] = value;
            }
        }

    }
}
