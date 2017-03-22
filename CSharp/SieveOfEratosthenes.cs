//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using AlgorithmSolution.Alg;
//namespace AlgorithmSolution
//{
//    class Program
//    {
//        const char L_BRACE = '(';
//        const char R_BRACE = ')';
//        const char L_BRACKET = '{';
//        const char R_BRACKET = '}';
//        const char L_SQUARE = '[';
//        const char R_SQUARE = ']';

//        static void Main(string[] args)
//        {
//            #region Stack testcode

//            //int Size = 0;
//            //Console.WriteLine("Please Enter Size of Stack:");
//            //Size = Convert.ToInt32(Console.ReadLine());
//            //Alg.Stack<int> s = new Alg.Stack<int>(Size);
//            ////System.Collections.Generic.Stack<char> s = new Stack<char>();
//            //while (true)
//            //{

//            //    Console.WriteLine("1. Push element into Stack");
//            //    Console.WriteLine("2. Pop element into Stack");
//            //    Console.WriteLine("3. Display element from Stack");
//            //    Console.WriteLine("4. Display peek element from Stack");
//            //    Console.WriteLine("5. Exit");
//            //    Console.WriteLine("Enter your choose:");
//            //    int i = Convert.ToInt32(Console.ReadLine());

//            //    switch (i)
//            //    {
//            //        case 1:
//            //            Console.WriteLine("Enter the element to insert into Stack");
//            //            int e = Convert.ToInt32(Console.ReadLine());
//            //            s.Push(e);
//            //            break;
//            //        case 2:
//            //            s.Pop();
//            //            break;
//            //        case 3:
//            //            s.display();
//            //            break;
//            //        case 4:
//            //            s.Peek();
//            //            break;
//            //        case 5:
//            //            System.Environment.Exit(1);
//            //            break;
//            //    }
//            //}
//            #endregion


//            #region Balanced Parenteses
//            //while (true)
//            //{
//            //    string expression = "";
//            //    Console.WriteLine("Please Enter your Expression");
//            //    expression = Console.ReadLine();

//            //    if (isBalnced(expression))
//            //    {
//            //        Console.WriteLine("Expression Balanced");
//            //    }
//            //    else
//            //    {
//            //        Console.WriteLine("Expression UnBalanced");
//            //    }
//            //}


//            //Console.ReadKey();

//            // public static bool isBalnced(string exp)
//            //{
//            //    Alg.Stack<char> s = new Alg.Stack<char>(10);
//            //    char[] charArray = exp.ToCharArray();
//            //    for (int i = 0; i < charArray.Length; i++)
//            //    {
//            //        if (charArray[i] == L_BRACE || charArray[i] == L_BRACKET || charArray[i] == L_SQUARE)
//            //        {
//            //            s.Push(charArray[i]);
//            //        }
//            //        else if (charArray[i] == R_BRACE || charArray[i] == R_BRACKET || charArray[i] == R_SQUARE)
//            //        {
//            //            if (s.IsEmpty()) return false;
//            //            if (s.Pop() != L_SQUARE) return false;
//            //            if (s.Pop() != L_BRACKET) return false;
//            //            if (s.Pop() != L_BRACE) return false;
//            //        }
//            //    }

//            //    return s.IsEmpty();
//            //}
//            #endregion

//            #region Queue TestCode
//            //int Size = 0;
//            //Console.WriteLine("Please Enter Size of Queue:");
//            //Size = Convert.ToInt32(Console.ReadLine());
//            //Alg.Queue<int> s = new Alg.Queue<int>(Size);
//            ////System.Collections.Generic.Stack<char> s = new Stack<char>();
//            //while (true)
//            //{

//            //    Console.WriteLine("1. Push element into Queue");
//            //    Console.WriteLine("2. Pop element into Queue");
//            //    Console.WriteLine("3. Display element from Queue");
//            //    Console.WriteLine("4. Display peek element from Queue");
//            //    Console.WriteLine("5. Exit");
//            //    Console.WriteLine("Enter your choose:");
//            //    int i = Convert.ToInt32(Console.ReadLine());

//            //    switch (i)
//            //    {
//            //        case 1:
//            //            Console.WriteLine("Enter the element to insert into Stack");
//            //            int e = Convert.ToInt32(Console.ReadLine());
//            //            s.EnQueue(e);
//            //            break;
//            //        case 2:
//            //            s.DeQueue();
//            //            break;
//            //        case 3:
//            //            s.Display();
//            //            break;
//            //        case 4:
//            //            s.Peek();
//            //            break;
//            //        case 5:
//            //            System.Environment.Exit(1);
//            //            break;
//            //    }
//            //}
//            #endregion

//            //int[] pol3 = new int[1000];

//            //for (int i = 100; i <= 999; i++)
//            //{
//            //    pol3[i - 100] = i;
//            //}


//            //int[] r=(from i in pol3
//            //         where i=rever)
//            "dasda".IndexOf
//            int T = Convert.ToInt32(Console.ReadLine());

//            for (int i = 0; i < T; i++)
//            {
//                string[] strArray = Console.ReadLine().Split(' ');
//                int[] ele = new int[Convert.ToInt16(strArray[0])];
//                bool bFound = false;
//                for (int j = 0; j < Convert.ToInt16(strArray[0]); j++)
//                {
//                    ele[j] = Convert.ToInt16(Console.ReadLine());
//                }


//                int index = 0;
//                int Sum = 0;
//                while (index <= ele.Length && !bFound)
//                {
//                    for (int k = index; k < ele.Length; k++)
//                    {
//                        Sum += ele[k];
//                        if (Sum == Convert.ToInt16(strArray[1]))
//                        {
//                            bFound = true;
//                        }
//                        //if
//                    }
//                    index++;
//                    Sum = 0;
//                }


//                if (bFound)
//                    Console.WriteLine("YES");
//                else
//                    Console.WriteLine("NO");
//            }
//            Console.ReadKey();

//        }
//    }


//}
//using System;
//using System.Collections.Generic;
//using System.IO;
//class Solution
//{
//    static void Main(String[] args)
//    {
//        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
//        char[] alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
//        string input = Console.ReadLine();
//        bool isPan = false;
//        for (int i = 0; i < alpha.Length; i++)
//        {
//            if (input.ToLower().IndexOf(alpha[i]) >= 0)
//            {
//                isPan = true;
//            }
//            else
//            {
//                isPan = false;
//                break;
//            }
//        }
//        if (isPan)
//        {
//            Console.WriteLine("pangram");
//        }
//        else
//        {
//            Console.WriteLine("not pangram");
//        }


//        Console.ReadKey();
//    }
//}

using System;
using System.Collections.Generic;
using System.IO;
using System.Collections;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int T = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < T; i++)
        {
            string[] S = Console.ReadLine().Split(' ');
            SieveOfEratosthenes(Convert.ToInt32(S[0]), Convert.ToInt32(S[1]));
        }
        Console.ReadKey();

    }

    public static void SieveOfEratosthenes(int n, int N)
    {
        //bool[] primes = new bool[N + 1];
        //primes = Enumerable.Repeat(true, N + 1).ToArray();
        //primes[0] = false;
        //if (n == 1)
        //    n = 2;
        //for (int i = 2; i * i <= N; i++)
        //{
        //    if (primes[i] == true)
        //    {
        //        for (int j = i * 2; j <= N; j += i)
        //        {
        //            primes[j] = false;
        //        }
        //    }
        //}
        int total = N;
        bool[] notPrime = new bool[total];
        notPrime[0] = true;
        notPrime[1] = true;
        for (int i = 2; i <= Math.Sqrt(notPrime.Length); i++)
        {
            if (!notPrime[i])
            {
                for (int j = i * 2; j < notPrime.Length; j += i)
                {
                    notPrime[j] = true;
                }
            }
        }

        for (int p = 0; p < notPrime.Length; p++)
        {
            if (!notPrime[p])
                Console.WriteLine(p);
        }
    }

}