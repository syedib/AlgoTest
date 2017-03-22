using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {

        public Node() { }
        public Node(int data)
        {
            this.Data = data;
        }
        public Node(int data, Node left, Node right)
        {
            this.Data = data;
            this.Left = left;
            this.Right = right;
        }
        public int Data
        {
            get;
            set;
        }
        public Node Left
        {
            get;
            set;
        }

        public Node Right
        {
            get;
            set;
        }

    }
    class BinarySearchTree
    {
        public int Count
        {
            get;
            set;
        }
        public BinarySearchTree()
        {
            Root = null;
        }

        public Node Root
        {
            get;
            set;
        }
        public void Add(int data)
        {
            Node newNode = new Node(data);

            Node CurrentNode = Root;
            Node ParentNode = null;
            
            while (CurrentNode != null)
            {
                if (data == CurrentNode.Data)
                    return;
                //Data Should be inserted into right node 
                if (data > CurrentNode.Data)
                {
                    ParentNode = CurrentNode;
                    CurrentNode = CurrentNode.Right;
                }
                else if (data < CurrentNode.Data)
                {
                    //Data Should be inserted into left node 
                    ParentNode = CurrentNode;
                    CurrentNode = CurrentNode.Left;
                }

            }

            if (ParentNode == null)
            {
                Root = newNode;
            }
            else
            {
                if (data > ParentNode.Data)
                {
                    ParentNode.Right = newNode;
                }
                else if (data < ParentNode.Data)
                {
                    ParentNode.Left = newNode;
                }
            }

        }
        public void PreOrder(Node n)
        {
            if (n == null)
            {
                return;
            }

            PreOrder(n.Right);
            PreOrder(n.Left);
            Console.WriteLine(n.Data);
            
        }
        public void PostOrder(Node n)
        {
            if (n == null)
            {
                return;
            }

            Console.WriteLine(n.Data);
            PostOrder(n.Left);
            PostOrder(n.Right);
        }
        public void InOrder(Node n)
        {
            if (n == null)
            {
                return;
            }

            InOrder(n.Left);
            Console.WriteLine(n.Data);
            InOrder(n.Right);
        }
		public Node Delete(int data)
		{
			Node deleteNode = new Node();
			
			return deleteNode;
		}
        public Node Search(int data)
        {
            if (Root.Data == data)
                return Root;
            else
            {
                Node currentNode = Root;
                while (currentNode != null)
                {
                    if (data > currentNode.Data)
                    {
                        currentNode = currentNode.Right;
                    }
                    else
                    {
                        currentNode = currentNode.Left;
                    }

                    if (currentNode != null && currentNode.Data == data)
                    {
                        return currentNode;
                    }
                }
            }

            return null;
        }
        

    }
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree obj = new BinarySearchTree();
            obj.Add(27);
            obj.Add(14);
            obj.Add(10);
            obj.Add(19);
            obj.Add(35);
            obj.Add(31);
            obj.Add(42);
            //Console.WriteLine("In Order");
            //obj.InOrder(obj.Root);
            //Console.WriteLine("Pre Order");
            //obj.PreOrder(obj.Root);
            //Console.WriteLine("Post Order");
            //obj.PostOrder(obj.Root);

            if (obj.Search(14) != null)
            {
                Console.WriteLine("Element Found");
            }
            else
            {
                Console.WriteLine("Not Found");
            }

            Console.ReadKey();
        }
    }
}
