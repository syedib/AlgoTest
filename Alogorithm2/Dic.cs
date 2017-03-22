using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int T = Convert.ToInt32(Console.ReadLine());
        Dictionary<string, string> dic = new Dictionary<string, string>();

        for (int i = 1; i <= T; i++) 
        {
            string name = Console.ReadLine();
            string number = Console.ReadLine();
            dic.Add(name, number);
        }

        while (true) 
        {
            string resultStr = Console.ReadLine();
			
            if (dic.ContainsKey(resultStr)) 
            {

                Console.WriteLine(resultStr + "=" + dic[resultStr].ToString());

            }else
			{
				Console.WriteLine("Not found");
			}
        }
    }
}