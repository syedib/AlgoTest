using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmSolution.Alg;
namespace AlgorithmSolution
{
    class Program
    {
        const char L_BRACE = '(';
        const char R_BRACE = ')';
        const char L_BRACKET = '{';
        const char R_BRACKET = '}';
        const char L_SQUARE = '[';
        const char R_SQUARE = ']';

        static void Main(string[] args)
        {
            #region testcode

            //int Size = 0;
            //Console.WriteLine("Please Enter Size of Stack:");
            //Size = Convert.ToInt32(Console.ReadLine());
            //Alg.Stack<int> s = new Alg.Stack<int>(Size);
            ////System.Collections.Generic.Stack<char> s = new Stack<char>();
            //while (true)
            //{

            //    Console.WriteLine("1. Push element into Stack");
            //    Console.WriteLine("2. Pop element into Stack");
            //    Console.WriteLine("3. Display element from Stack");
            //    Console.WriteLine("4. Display peek element from Stack");
            //    Console.WriteLine("5. Exit");
            //    Console.WriteLine("Enter your choose:");
            //    int i = Convert.ToInt32(Console.ReadLine());

            //    switch (i)
            //    {
            //        case 1:
            //            Console.WriteLine("Enter the element to insert into Stack");
            //            int e = Convert.ToInt32(Console.ReadLine());
            //            s.Push(e);
            //            break;
            //        case 2:
            //            s.Pop();
            //            break;
            //        case 3:
            //            s.display();
            //            break;
            //        case 4:
            //            s.Peek();
            //            break;
            //        case 5:
            //            System.Environment.Exit(1);
            //            break;
            //    }
            //}
            #endregion

            //Balanced Parenteses

            while (true)
            {
                string expression = "";
                Console.WriteLine("Please Enter your Expression");
                expression = Console.ReadLine();

                if (isBalnced(expression))
                {
                    Console.WriteLine("Expression Balanced");
                }
                else
                {
                    Console.WriteLine("Expression UnBalanced");
                }
            }
            

            //Console.ReadKey();
        }
        public static bool isBalnced(string exp)
        {
            Alg.Stack<char> s = new Alg.Stack<char>(10);
            char[] charArray = exp.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == L_BRACE || charArray[i] == L_BRACKET || charArray[i] == L_SQUARE)
                {
                    s.Push(charArray[i]);
                }
                else if (charArray[i] == R_BRACE || charArray[i] == R_BRACKET || charArray[i] == R_SQUARE)
                {
                    if (s.IsEmpty()) return false;
                    if (s.Pop() != L_SQUARE) return false;
                    if (s.Pop() != L_BRACKET) return false;
                    if (s.Pop() != L_BRACE) return false;
                }
            }

            return s.IsEmpty();
        }
    }
}