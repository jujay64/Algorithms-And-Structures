using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreesImplementations
{
    public class BinaryTreeNode<T> : Node<T>
    {
        public BinaryTreeNode()
        {
            
        }

        public BinaryTreeNode(T data):base(data,null)
        {
            
        }

        public BinaryTreeNode(T value, Node<T> childLeft, Node<T> childRight)
        {
            base.Data = value;
            base.Children = new NodeList<T>(2)
            {
                childLeft,
                childRight
            };
        }

        //ACCESSORS
        public BinaryTreeNode<T> LeftChild
        {
            get
            {
                if (base.Children != null)
                {
                    return (BinaryTreeNode<T>)base.Children[0];
                }
                else
                {
                    return null;
                }
            }

            set
            {
                if (base.Children == null)
                {
                    base.Children = new NodeList<T>(2);
                }
                base.Children[0] = value;
            }
        }

        public BinaryTreeNode<T> RightChild
        {
            get
            {
                if (base.Children != null)
                {
                    return (BinaryTreeNode<T>)base.Children[1];
                }
                else
                {
                    return null;
                }
            }

            set
            {
                if (base.Children == null)
                {
                    base.Children = new NodeList<T>(2);
                }
                base.Children[1] = value;
            }
        }
    }
}
