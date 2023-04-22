using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_Stack
{
    internal class MyStack<T>
    {
        private List<T> stack;
        public MyStack() {
            stack = new List<T>();
        }

        public int Count()
        {
            return stack.Count;
        }
        public T Pop()
        {
            if (stack.Count == 0)
            {
                throw new InvalidOperationException("Stack is Empty");
            }
            T item = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            return item;
        }
        public void Push(T item)
        {
            stack.Add(item);
        }
    }
}
