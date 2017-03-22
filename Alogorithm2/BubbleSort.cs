using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class BubbleSort
{
	public static void Main(string[] args)
	{
		int[] intArray = {7,3,6,4,2,9,1};
		//Console.WriteLine(intArray);
		
		BubleSort(intArray,intArray.Length);
		printArray(intArray);
		Console.ReadKey();
	}
	private static void printArray(int[] a)
	{
		for(int i=0; i < a.Length; i++)
		{
			Console.WriteLine(a[i]);
		}
	}
	public static void BubleSort(int[] A, int n)
	{
		if (n>0)
		{
			for (int k=0;k< n-1;k++)
			{
			// (n-k-1) is for ignoring comparisons of elements which have already been compared in earlier iterations
				for(int i = 0; i < n-k-1; i++) {
                  if(A[ i ] > A[ i+1] ) {
                      int temp = A[ i ];
                       A[ i ] = A[ i+1 ];
                       A[ i + 1] = temp ;
                   }
			}
		}
	}
}}