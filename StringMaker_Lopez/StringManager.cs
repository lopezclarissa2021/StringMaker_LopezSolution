using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMaker_Lopez
{
    internal class StringManager
    {
        public string Reverse(string s)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                stack.Push(i);
            }
            return s;
        }

        public string Reverse(string s, bool PreserveCaseLocation)
        {

        }
    }
}
