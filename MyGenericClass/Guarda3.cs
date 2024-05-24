using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGenericClass
{
    public class Guarda3<T>
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
    }
}