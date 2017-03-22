using System;
using System.Collections.Generic;
using System.IO;
class Node
{
	public Node Left;
	public Node Right;
	public int data;
	public Node()
	{
	
	}
	public Node(int data)
	{
		this.data = data;
	}
}
public class BST
{
	Node n;
	public BST()
	{
		n = new Node();
	}
	
	public void Insert(int d)
	{
		if(n == null)
		{
			n = new Node(d);
		}
		else if(d > n.data)
		{
			if(n.Right!=null)
			{
				Insert(d);
			}
			else
			{
				n.Right = new Node(d);
			}
		}
		else if(d < n.data)
		{
			if(n.Left != null)
			{
				Insert(d);
			}
			else
			{
				n.Left = new Node(d);
			}	
		}
		
	}
}
class TestBST
{
	public static void Main(string[] args)
	{
		BST b = new BST();
		b.Insert(2);
		
		Console.ReadKey();
	}
}