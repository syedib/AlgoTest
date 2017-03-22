using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());
			
			for(int i=0;i<T;i++)
			{
				string input = Console.ReadLine();
				if(input.Length%2 == 0)
				{
					Console.WriteLine("YES");
				}
				else
				{
					Console.WriteLine("NO");
				}
			}
			Console.ReadKey();
        }
    }
