using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
		string[] strArray = new string[n];
		
		for(int i = 1;i<=n;i++)
		{
			strArray[i-1] = GetHashString(i,n);
		}
		
		foreach(string str in strArray)
		{
			Console.WriteLine(str);
		}
		Console.ReadKey();
    }
	
	public static string GetHashString(int n, int size)
	{
		string returnStr = "";
		int noOfSpace = size - n;
		
		for(int j=1;j<=noOfSpace;j++)
		{
			returnStr += " "; 
		}
		
		for(int i=1;i<=n;i++)
		{
			returnStr += "#";
		}
		return returnStr;
	}
}