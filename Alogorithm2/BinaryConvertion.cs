using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
		
		int T = Convert.ToInt32(Console.ReadLine());
		//List<int> list = new List<int>();
		for(int i=0; i<=T-1; i++)
		{
			int n = Convert.ToInt32(Console.ReadLine());
			string str ="";
			int temp = 0;
			while(n != 0)
			{
				temp = n%2;
				n = n/2;
				str += temp.ToString();
			}
			Console.WriteLine(StringExt.ReverseString(str));
		}
		
		//Console.ReadKey();
    }
}

static class StringExt
{
    /// <summary>
    /// Receives string and returns the string with its letters reversed.
    /// </summary>
    public static string ReverseString(string s)
    {
		char[] arr = s.ToCharArray();
		Array.Reverse(arr);
		return new string(arr);
    }
}