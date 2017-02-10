using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreesImplementations
{
    public class NodeList<T> : Collection<Node<T>>
    {
        public NodeList(int initialSize)
        {
            //Add the specified number of node in the node list
            for (var i = 0; i < initialSize; i++)
            {
                base.Items.Add(default(Node<T>));
            }
        }

        public Node<T> FindByValue(T value)
        {
            foreach (var node in base.Items)
            {
                if (node.Equals(value))
                    return node;
            }
            return null;
        }
    }
}
