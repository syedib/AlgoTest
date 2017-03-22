using System;

class ReverseArray
{
	public static void Main(string[] args)
	{
		int n = Convert.ToInt32( Console.ReadLine());
		int[] A= new int[n];
		
		for(int i=0;i<n;i++)
		{
			A[i] = Convert.ToInt32(Console.ReadLine());
		}
		
		PrintArray(A);
		Console.ReadKey();
	}
	
	public static void PrintArray(int[] a)
	{
		for(int i=a.Length-1;i >= 0;i--)
		{
			Console.WriteLine(a[i]);
		}
	}
}