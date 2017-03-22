/*Queue Using Array*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
public class QueueDemo
{
	public static int front = 0;
	public static int rare = 0;
	public static int[] QueueArray = new int[10];
	public static void Main(String[] args)
	{	
		bool exitFlag = true;
		while(exitFlag)
		{
			Console.WriteLine("Choose the operation on Queue\n 1.Enqueue\n 2.Dequeue\n 3.Display Queue\n 4.Exit\n Enter your choice:");
			int c = Convert.ToInt32(Console.ReadLine());
			
			switch(c)
			{
				case 1:
					enQueue();
					break;
				case 2:
					Disaplay();
					break;
				case 3:
					Disaplay();
					break;
				case 4:
					exitFlag = false;
					break;
				default:
					Console.WriteLine("Invalid Choice");
					break;
			}
		}
		
		//Console.WriteLine("Enter the size of Queue:")
		//int Size = Convert.Int32(Console.ReadLine());
		Console.ReadKey();
	}
	public static void enQueue()
	{
		Console.Write("Please enter the value to enqueue:");
		int n = Convert.ToInt32(Console.ReadLine());
		if(!isOverFlow())
		{
			QueueArray[front++] = n;
		}
		else
		{
			Console.WriteLine("Queue Overflow");
		}
	}
	public static void deQueue()
	{
			QueueArray[front] = QueueArray[front + 1];
			front--;
	}
	public static void Disaplay()
	{
		if(!isEmpty())
		{
			string str = "";
			for(int i=QueueArray.Length-1; i >= 0 ; i--)
			{
				str += QueueArray[i].ToString() + " | ";
			}
			Console.WriteLine(str);
		}
		else
		{
			Console.WriteLine("Nothing to dispaly !");
		}
		
	}
	public static bool isEmpty()
	{
		bool returnValue = false;
		
		if(front == rare)
		{
			returnValue = true;
		}
		return returnValue;
	}
	public static bool isOverFlow()
	{
		if(rare == QueueArray.Length-1)
		{
			return true;
		}
		return false;
	}
}