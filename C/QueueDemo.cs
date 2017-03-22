using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
class Node
{
	public int Data;
	public Node Next;
	public Node(int data)
	{
		Data = data;
	}
}
class Queue : IEnumerable<Queue>
{
	protected Node front;
	protected Node rare;
	public int count;
	public Queue()
	{
	
	}
	
	public void enQueue(int data)
	{
		Node n = new Node(data);
		if(front == null)
		{
			front = rare = n;
		}
		else
		{
			rare.Next = n;
			rare = rare.Next;
		}
	}
	
	IEnumerator<Queue> GetEnumerator()
	{
			foreach(Queue q in this.Queue
	}
	
}
class Solution
{
	public static void Main(String[] args)
	{
		//List<Queue> list = new List<Queue>();
	
		Queue q = new Queue();
		q.enQueue(1);
		q.enQueue(3);
		
		foreach(Node n in Queue)
		{
			Console.WriteLine(n.Data);
		}
	}
}