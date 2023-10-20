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
            string revString = "";
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                stack.Push(s[i]);
            }
           
            while(stack.Count > 0)
            {
                revString += stack.Pop();
            }
        
            return revString;
        }

        //public string Reverse(string s, bool PreserveCaseLocation)
        //{

       // }
    }
}
