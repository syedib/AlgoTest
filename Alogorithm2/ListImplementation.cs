using System;
using System.Collections.Generic;
using System.IO;

public class Node
{
	public int data=0;
	public Node next = null;
	public Node()
	{
		
	}
}

class myList
{
	private Node Head ;
	public void Add(int d)
	{
		Node temp = new Node();
		temp.data = d;
		temp.next = Head;
		Head = temp;
	}
	
	public void PrintAll()
	{
		Node Cur = Head;
		
		while(Cur != null)
		{
			Console.WriteLine(Cur.data);
			Cur = Cur.next;
		}
	}
}

class test
{
	public static void Main(String[] arg)
	{
		myList L = new myList();
		L.Add(2);
		L.Add(4);
		L.Add(5);
		
		L.PrintAll();
		
		Console.ReadKey();
		}
	}
	