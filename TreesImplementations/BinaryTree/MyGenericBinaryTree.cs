using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreesImplementations
{
    public class MyGenericBinaryTree<T>
    {
        public BinaryTreeNode<T> Root { get; set; }

        public MyGenericBinaryTree()
        {
            Root = null;         
        }
    }
}
