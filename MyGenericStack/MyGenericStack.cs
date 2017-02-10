using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGenericStack
{
    /// <summary>
    /// Generic implementation of a Stack
    /// </summary>
    /// <typeparam name="T">Type of the items stored in the stack</typeparam>
    public class MyGenericStack<T>
    {
        private List<T> _data { get; set; }

        public MyGenericStack()
        {
            _data = new List<T>();
        }

        /// <summary>
        /// Allows to know if there's items in the stack
        /// </summary>
        /// <returns>True if the stack contains no item</returns>
        public bool IsEmpty()
        {
            return _data.Count == 0;
        }

        /// <summary>
        /// Allows to know how many items are in the stack
        /// </summary>
        /// <returns>The number of items in the stack</returns>
        public int Size()
        {
            return _data.Count();
        }

        /// <summary>
        /// Allows to add an item on the top of the stack
        /// </summary>
        /// <param name="item">Item to add</param>
        public void Push(T item)
        {
            _data.Add(item);
        }

        /// <summary>
        /// Allows to get the item from the top of the stack and delete it from the stack
        /// </summary>
        /// <returns>The item currently on the top of the stack (last pushed item)</returns>
        public T Pop()
        {
            if (!this.IsEmpty())
            {
                var item = _data[_data.Count - 1];
                _data.Remove(item);
                return item;
            }
            else
            {
                throw new IndexOutOfRangeException("The stack is empty");
            }

        }

        /// <summary>
        /// Allows to read the item currently on the top of the stack without deleting it
        /// </summary>
        /// <returns>The item currently on the top of the stack (last pushed item)</returns>
        public T Peek()
        {
            if (!this.IsEmpty())
            {
                return _data[_data.Count - 1];
            }
            else
            {
                throw new IndexOutOfRangeException("The stack is empty");
            }
        }
            
    }
}
