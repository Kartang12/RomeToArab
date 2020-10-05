using System;
using System.Collections.Generic;
using System.Text;

namespace Rome
{
    class Node
    {
        public char value;
        public Node? left = null;
        public Node? right = null;
        public Node? parrent = null;

        public Node(char value)
        {
            this.value = value;
        }

        public void AddLeft(char l)
        {
            left = new Node(l);
        }

        public void AddRight(char r)
        {
            right = new Node(r);
        }

        public bool HasParent()
        {
            return parrent!=null;
        }

        public Node GetParent()
        {
            return parrent;
        }

        public bool HasLeft()
        {
            return left!=null;
        }
        public bool HasRight()
        {
            return right!=null;
        }
    }
}
