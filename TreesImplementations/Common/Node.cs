using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreesImplementations
{
    public class Node<T>
    {
        public T Data { get; set; }
        public NodeList<T> Children { get; set; }

        public Node()
        {
            
        }

        public Node(T data, NodeList<T> children)
        {
            this.Data = data;
            this.Children = children;
        }
    }
}
