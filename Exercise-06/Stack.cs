using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_06
{
    internal class Stack<T>
    {
        
            private List<T> items = new List<T>();

            public void Push(T item)
            {
                items.Add(item);   
            }

            public T Pop()
            {
                T poppedItem = items[items.Count - 1];
                items.RemoveAt(items.Count - 1);
                
                return poppedItem;
            }

            public T Peek()
            {
                return items[items.Count - 1];
            }

            public bool IsEmpty()
            {
                return items.Count == 0;
            }
    }
}

