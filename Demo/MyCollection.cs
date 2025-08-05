using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class MyCollection<T>
    {
        private T[] arr;
        private int currentIndex = -1;
        public MyCollection()
        {
            arr = new T[5];
            currentIndex = -1;
        }

        public void Add(T value)
        {
            //T t = new T();
            if (currentIndex == arr.Length - 1) Extend();
            currentIndex++;
            arr[currentIndex] = value;
        }

        private void Extend()
        {
            T[] newArr = new T[arr.Length * 2];
            for (int i = 0; i < arr.Length; i++)
                newArr[i] = this.arr[i];
            this.arr = newArr;
        }

        public T GetByIndex(int index)
        {
            if (index < 0 || index > currentIndex) throw new IndexOutOfRangeException();
            return arr[index];
        }
        public void Print()
        {
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
        }
    }
}
