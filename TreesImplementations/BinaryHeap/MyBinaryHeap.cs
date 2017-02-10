using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreesImplementations
{
    public class MyBinaryHeap<T> where T : IComparable<T>
    {
        private List<T> heapList { get; set; }
        private int currentSize { get; set; }

        public MyBinaryHeap()
        {
            this.heapList = new List<T>();
            this.currentSize = 0;
        }

        public bool IsEmpty()
        {
            return this.currentSize == 0;
        }

        public int Size()
        {
            return this.currentSize;
        }

        public List<T> BuildHeapList(List<T> listToHeapify)
        {
            int i = listToHeapify.Count / 2;
            this.heapList.Add(default(T));
            this.heapList.AddRange(listToHeapify);
            this.currentSize = listToHeapify.Count;
            while (i > 0)
            {
                percDown(i);
                i--;
            }
            return this.heapList;
        }

        public List<T> Insert(T k)
        {
            this.heapList.Add(k);
            this.currentSize++;
            percUp(currentSize);

            return this.heapList;
        }

        public T DelMin()
        {
            if (!this.IsEmpty())
            {
                var minElement = this.heapList[1];
                this.heapList[1] = this.heapList[currentSize];
                this.heapList.RemoveAt(this.currentSize);
                this.currentSize--;
                percDown(1);

                return minElement;
            }
            else
                return default(T);
        }

        private void percDown(int i)
        {
            while ((i * 2) <= this.currentSize)
            {
                int mc = minChildIndex(i);
                if (this.heapList[i].CompareTo(this.heapList[mc]) > 0)
                {
                    var tmp = this.heapList[i];
                    this.heapList[i] = this.heapList[mc];
                    this.heapList[mc] = tmp;
                }
                i = mc;
            }
        }

        private void percUp(int i)
        {
            while (i / 2 > 0)
            {
                if (this.heapList[i].CompareTo(this.heapList[i / 2]) < 0)
                {
                    var tmp = this.heapList[i];
                    this.heapList[i] = this.heapList[i / 2];
                    this.heapList[i / 2] = tmp;
                }
                i /= 2;
            }
        }

        private int minChildIndex(int i)
        {
            if ((i * 2) + 1 > this.currentSize)//End of the heap, no right child
                return (i * 2);//We return the index of the unique left child

            if (this.heapList[i * 2].CompareTo(this.heapList[i * 2 + 1]) < 0)
                return i * 2;
            return i * 2 + 1;
        }

    }
}
