using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ReverseArray
{
    public static void Main(String[] args)
    {
        int T = Convert.ToInt32(Console.ReadLine());


            string strResult = "";
            string[] ele = Console.ReadLine().Split(' ');

            int[] ar = new int[ele.Length];

            for (int x = 0; x <= T - 1; x++)
            {
                ar[x] = Convert.ToInt32(ele[x]);
            }

            for (int j = ar.Length - 1; j >= 0; j--)
            {
                strResult += ar[j].ToString() + " ";
            }

            Console.WriteLine(strResult);
			Console.ReadKey();
        }
    }
