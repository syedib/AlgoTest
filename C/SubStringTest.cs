using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class SubStringTest
{
	public static void Main(String[] args)
	{
		
		int T = Convert.ToInt32(Console.ReadLine());
		for(int i = 1; i <= T ; i++)
		{
			bool isSubStringFound = false;
			string str1 = Console.ReadLine();
			string str2 = Console.ReadLine();
			char[] alpah = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
		
			foreach(char c in alpah)
			{
				if(str1.IndexOf(c) > -1 && str2.IndexOf(c) > -1)
				{
					isSubStringFound = true;
					break;
				}
			}
		
			if(isSubStringFound)
			{
				Console.WriteLine("YES");
			}
			else
			{
				Console.WriteLine("NO");
			}
		}
	}
}