using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
		
		string[] arr_temp = Console.ReadLine().Split(' ');
        int x = Convert.ToInt32(arr_temp[0]);
		int y = Convert.ToInt32(arr_temp[1]);
		Console.WriteLine(GetGSD(x,y));
		
    }
	
	public static int GetGSD(int x,int y)
	{
		if(y == 0)
		{
			return x;
		}
		return GetGSD(y,x%y);
	}
}