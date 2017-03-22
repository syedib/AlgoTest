using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSolution.Alg
{
    public class Stack <T>: IStack<T>
    {
        public const string STR_FULLMSG = "Stack is Full";
        public const string STR_EMPTY = "Stack is Empty";
        public const string STR_PUSH_SUCCESSMSG = "Element inserted Successfully";
        public const string STR_POP_SUCCESSMSG = "Element deleted Successfully";

        //private T _value;
        private T value
        {
            get;
            set;
        }
        public T[] items
        {
            get;
            set;
        }
        public int top
        {
            get;
            set;
        }
        public int Size
        {
            get;
            set;
        }

        public Stack(int SizeOfStack)
        {
            Size = SizeOfStack;
            items = new T[Size];
            top = -1;
        }

        public void display()
        {
            //throw new NotImplementedException();
            if (IsEmpty())
            {
                Console.WriteLine(STR_EMPTY);
                return;
            }
            for (int i = top; i > -1; i--)
            {

                Console.WriteLine("Item {0} : {1}", (top - i), items[i]);
            }

        }

        public bool IsEmpty()
        {
            //throw new NotImplementedException();
            if (top == -1)
                return true;
            return false;
        }

        public void Peek()
        {
            //throw new NotImplementedException();
            //T returnEle = T;
            if (!IsEmpty())
            {
                Console.WriteLine(items[top]);
            }
            else
            {
                Console.WriteLine(STR_EMPTY);
                //returnEle = items[top];
            }
            //sreturn returnEle;
        }

        public T Pop() 
        {
            //throw new NotImplementedException();
            T valueT = default(T);
            if (IsEmpty())
            {
                throw new InvalidOperationException(STR_EMPTY);   
            }
            else
            {
                valueT = items[top--];
            }
            return valueT;
        }

        public void Push(T element)
        {
            //throw new NotImplementedException();
            if (top == Size - 1)
            {
                Console.WriteLine("Stack is full");
            }
            else
            {
                items[++top] = element;
                //Console.WriteLine(STR_PUSH_SUCCESSMSG);
            }
        }
    }
    public interface IStack<T>
    {
        bool IsEmpty();

        void Push(T element);

        T Pop();

        void Peek();

        void display();
    }
}
