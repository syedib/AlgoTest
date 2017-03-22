using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] t_temp = Console.ReadLine().Split(' ');
        int[] t = Array.ConvertAll(t_temp,Int32.Parse);
		int sec = 0;
		//Console.WriteLine(sec);
		int x = 0;
		for(int i =0;i<=n-1;i++)
		{
			//if(i == 0)
			//{
				//sec = t[0];
			//}
			//if(i >= n-1)
			//{
			  // break;
			//}
			//x = t[i+1] - t[i];
			
			if(i==1 | i == t[i])
				sec += 1;
			else
			    sec = sec + t[i];
			
			//if(x <= 1)
			//{
				//sec += 1;
			//}
			//else
			//{
				//sec += x;
			//}
			
		}
		Console.WriteLine(sec);
		Console.ReadKey();
    }
}