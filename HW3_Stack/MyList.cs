using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_Stack
{
    internal class MyList<T>
    {
        private T[] array;
        private int index;
        public MyList() {
            array = new T[4];
            index = 0;
        }
        public void Add(T item)
        {
            if(index<array.Length) array[index++] = item;
            else
            {
                T[] newArray = new T[array.Length*2];
                Array.Copy(array, newArray, array.Length);
                newArray[index++] = item;
            }
            
        }
        public void Clear()
        {
            array = new T[4];
            index = 0;
        }
        public bool Contains(T item) { 
        
        return array.Contains(item);
        }

        public T Remove(int indexToRemove)
        {
            if (indexToRemove < 0 || indexToRemove >= index)
            {
                throw new ArgumentOutOfRangeException(nameof(indexToRemove), "Index is out of range.");
            }

            T removedItem = array[indexToRemove];

            for (int i = indexToRemove; i < index - 1; i++)
            {
                array[i] = array[i + 1];
            }

            array[--index] = default(T);

            return removedItem;
        }
        public void InsertAt(int indexToInsert, T item)
        {
            if (indexToInsert < 0 || indexToInsert > index)
            {
                throw new ArgumentOutOfRangeException(nameof(indexToInsert), "Index is out of range.");
            }

            if (index >= array.Length)
            {
                T[] newArray = new T[array.Length * 2];
                Array.Copy(array, newArray, array.Length);
                array = newArray;
            }

            for (int i = index; i > indexToInsert; i--)
            {
                array[i] = array[i - 1];
            }

            array[indexToInsert] = item;
            index++;
        }

        public void DeleteAt(int indexToDelete)
        {
            if (indexToDelete < 0 || indexToDelete >= index)
            {
                throw new ArgumentOutOfRangeException(nameof(indexToDelete), "Index is out of range.");
            }

            for (int i = indexToDelete; i < index - 1; i++)
            {
                array[i] = array[i + 1];
            }

            array[--index] = default(T);
        }

        public T Find(int indexToFind)
        {
            if (indexToFind < 0 || indexToFind >= index)
            {
                throw new ArgumentOutOfRangeException(nameof(indexToFind), "Index is out of range.");
            }
            return array[indexToFind];
        }

    }
}
