using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace BST
{
class Node : ICloneable
{
	
	private IComparable data;
	private Node left,right;
	
	public Node():this(null){}
	public Node(IComparable data):this(data,null,null){}
	public Node(IComparable data,Node left,Node right)
	{
		this.data = data;
		this.left = left ;
		this.right = right;
	}
	public object Clone()
	{
		Node clone = new Node();
		
		if(data is ICloneable)
		{
			clone.Value = (IComparable)((ICloneable)data).Clone(); 
		}
		else
		{
			clone.data = data;
		}
		
		if(left != null)
			clone.Left = (Node)left.Clone();
		
		if(right != null)
			clone.Right = (Node)right.Clone();
		
		return clone;
	}
	public IComparable Value
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
		tree.Root = new Node(1,new Node(5),new Node(9));
		Console.WriteLine( String.Format("Root : {0}, Left: {1}, Right: {2}", tree.Root.Value,tree.Root.Left.Value,tree.Root.Right.Value) );
		Console.ReadKey();
	}
}
}
