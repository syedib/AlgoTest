using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
		char[] alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
		string input = Console.ReadLine();
		bool isPan = false;
		for (int i=0 ; i<alpha.Length; i++)
		{
			if(input.ToLower().IndexOf(alpha[i]) >= 0)
			{
				isPan = true;
			}
			else
			{
				isPan = false;
				break;
			}
		}
		if (isPan)
		{
			Console.WriteLine("pangram");
		}
		else
		{
			Console.WriteLine("not pangram");
		}
		
		
		Console.ReadKey();
    }
}