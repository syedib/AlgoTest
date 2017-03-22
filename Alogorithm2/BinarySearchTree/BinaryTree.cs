using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace BST
{
class Node{
	
	private object data;
	private Node left,right;
	
	public Node():this(null){}
	public Node(object data):this(data,null,null){}
	public Node(object data,Node left,Node right)
	{
		this.data = data;
		this.left = left ;
		this.right = right;
	}
	
	public object Value
	{
		get
		{
			return data;
		}
		set
		{
			data = value;
		}
	}
	public Node Left
	{
		get
		{
		 return left;
		}
		set
		{
			left = value;
		}
	}
	
	public Node Right
	{
		get
		{
		 return right;
		}
		set
		{
			right = value;
		}
	}
}
	class BinaryTree
{
	private Node root;
	public BinaryTree()
	{
		root = null;
	}
	
	public virtual void Clear()
	{
		root = null;
	}
	
	public Node Root
	{
		get
		{
			return root;
		}
		set
		{
		 root = value;
		}
	}
}
class Test
{
	public static void Main(string[] args)
	{
		//Console.WriteLine("Hi");
		BinaryTree tree = new BinaryTree();
		tree.Root = new Node(1,new Node(5),new Node(8));
		Console.WriteLine( String.Format("Root : {0}, Left: {1}, Right: {2}", tree.Root.Value,tree.Root.Left.Value,tree.Root.Right.Value) );
		Console.ReadKey();
	}
}
}
