using System;
using System.Collections.Generic;
using System.IO;
class ReverseArray
{
	public static void Main(string[] args)
	{
		int T = Convert.ToInt32( Console.ReadLine());
		string inputStr = "";
		int Size = inputStr.Length;
		char[] inputAry = new char[Size];
		for(int i=0;i<T;i++)
		{
			string resultStr = "";
			inputStr = Console.ReadLine();
			
			inputAry = inputStr.ToCharArray();
			
			for(int j=inputAry.Length-1; j>=0; j--)
			{
				resultStr += inputAry[j].ToString();
			}
			
			Console.WriteLine(resultStr);
		}
		
		Console.ReadKey();
	}
}