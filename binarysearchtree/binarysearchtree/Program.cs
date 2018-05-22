using System;
using System.Collections.Generic;
using System.Text;
namespace TreeSort
{
    class Node
    {
        public int item;
        public Node leftc;
        public Node rightc;
    }
    class Tree
    {
        public Node root;
        public Tree()
        {
            root = null;
        }
        public Node ReturnRoot()
        {
            return root;
        }
        public void Insert(int id)
        {
            //This block stores elements of tree.
            Node newNode = new Node();
            newNode.item = id;
            if (root == null)
                root = newNode;
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (id < current.item)
                    {
                        current = current.leftc;
                        if (current == null)
                        {
                            parent.leftc = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.rightc;
                        if (current == null)
                        {
                            parent.rightc = newNode;
                            return;
                        }
                    }
                }
            }
        }
        public void Ascending(Node Root)
        {
            //This block displays elements of tree in ascending order.
            if (Root != null)
            {
                Ascending(Root.leftc);
                Console.Write(Root.item + " ");
                Ascending(Root.rightc);
            }
        }
        public void Descending(Node Root)
        {
            //This block displays elements of tree in descending order.
            if (Root != null)
            {
                Descending(Root.rightc);
                Console.Write(Root.item + " ");
                Descending(Root.leftc);
            }
        }
        public Node Search(Node Root,int n)
        {
            //This block will search for the given element and return node if it is available else it returns null.
            if (Root == null)
            {
                return null;
            }
            while (Root != null)
            {
                if (Root.item == n)
                {
                    return Root;
                }
                else if (Root.item < n)
                {
                    Root = Root.rightc;
                }
                else
                {
                    Root = Root.leftc;
                }
            }
            return null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Tree theTree = new Tree();
            int n = 0, se;
            Console.WriteLine("enter no of elements are there in tree");
            n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
                //This block is executed when input is more than 0.
            {
                Console.WriteLine("ENTER THE ELEMENTS LEVEL WISE STARTING FROM ROOT TO LEAF NODES");
                for (int i = 0; i < n; i++)
                {
                    theTree.Insert(Convert.ToInt32(Console.ReadLine()));
                }
                Console.WriteLine("Enter the element to be searched");
                se = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ASCENDING : ");
                theTree.Ascending(theTree.ReturnRoot());
                Console.WriteLine(" ");
                Console.WriteLine();
                Console.WriteLine("DESCENDING :  ");
                theTree.Descending(theTree.ReturnRoot());
                Console.WriteLine(" ");
                Console.WriteLine();
                Node s = theTree.Search(theTree.ReturnRoot(), se);
                if (s != null)
                {
                    Console.WriteLine("ELEMENT FOUND");
                }
                else
                {
                    Console.WriteLine("ELEMENT NOT FOUND");
                }
            }
            else
                Console.WriteLine("NO ELEMENT AVAILABLE TO PERFORM ACTIONS");
        }
    }
}
