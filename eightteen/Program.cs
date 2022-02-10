using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace eightteen

{
    class Program
    {
        static bool Checker(string str)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> sk = new Dictionary<char, char>
            {
                {'(',')'},
                {'{','}'},
                {'[',']'},
            };
            foreach (char c in str)
            {
                if (c == '(' || c == '{' || c == '[') stack.Push(sk[c]);
                if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0 || stack.Pop() != c) return false;
                }
            }
            if (stack.Count == 0) return true;
            else return false;
        }
        static void Main(string[] args)
        {
            WriteLine("Введите строку");
            string str = ReadLine();
            WriteLine(Checker(str));
            ReadKey();
        }

    }
}