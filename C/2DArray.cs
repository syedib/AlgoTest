using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int[][] arr = new int[6][];
        List<int> list = new List<int>();
		int m =0;
		for(int arr_i = 0; arr_i < 6; arr_i++){
           string[] arr_temp = Console.ReadLine().Split(' ');
           arr[arr_i] = Array.ConvertAll(arr_temp,Int32.Parse);
        }
		
		for(int i = 0;i<=arr.Length-1;i++)
		{
			int s =0;
		
			for(int j = 0;j<=arr.Length-1;j++)
			{
				if(i+1 < arr.Length-1 && j+1 < arr.Length-1)
				{
					s = arr[i][j] + arr[i][j+1] + arr[i][j+2] + arr[i+1][j+1] + arr[i+2][j] + arr[i+2][j+1] + arr[i+2][j+2];
					list.Add(s);
				}
			}
		}
		Console.WriteLine(list.Max());
		//Console.ReadKey();
    }
}