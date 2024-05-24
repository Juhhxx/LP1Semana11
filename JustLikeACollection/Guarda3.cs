using System;
using System.Collections;
using System.Collections.Generic;

namespace JustLikeACollection
{
    public class Guarda3<T> : IEnumerable<T>
    {
        private T var1;
        private T var2;
        private T var3;
        private T[] items = new T[3];
        public Guarda3()
        {
            var1 = default;
            var2 = default;
            var3 = default;

            items[0] = var1;
            items[1] = var2;
            items[2] = var3;
        }
        public T GetItem(int i)
        {
            if (i < 0 || i > 2)
                throw new IndexOutOfRangeException();
            else
                return items[i];
        }
        public void SetItem(int i, T item)
        {
            if (i < 0 || i > 2)
                throw new IndexOutOfRangeException();
            else
                items[i] = item;
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < 3; i++)
            {
                yield return items[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void Add(T item)
        {
            if (var1.Equals(default(T)) && var2.Equals(default(T)) && var3.Equals(default(T)))
            {
                return;
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    if (items[i].Equals(default(T)))
                    {
                        items[i] = item;
                        return;
                    }
                }
            }
        }
    }
}