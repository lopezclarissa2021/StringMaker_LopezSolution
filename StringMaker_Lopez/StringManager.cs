using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMaker_Lopez
{
    internal class StringManager
    {
        public string CurrInput { get; set; } = "";
        public string Reverse(string s)
        {
            CurrInput = s;
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

        public string Reverse(string s, bool PreserveCaseLocation)
        {
            string revStr = Reverse(s);
            string newStr = "";
            for(int i = 0; i < s.Length; i++)
            {
                if(char.IsWhiteSpace(s[i]))
                {
                    newStr += revStr[i].ToString();
                }else if (s[i].ToString().ToUpper() == s[i].ToString())
                {
                    newStr += revStr[i].ToString().ToUpper();
                }else
                {
                    newStr += revStr[i].ToString().ToLower();
                }
            }
            return newStr;  

        }

        public bool Symmetric(string s)
        {
            CurrInput = s;
            return s == Reverse(s);
        }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(CurrInput))
            {
                return "Negative One";
            }

            int asciiTotal = 0;
            for (int i = 0; i < CurrInput.Length; i++)
            {
                asciiTotal += Convert.ToInt32(CurrInput[i]);
            }

            string numberString = asciiTotal.ToString();

            string resultString = "";
            List<string> numList = new List<string> { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight","Nine" };

            for (int i = 0; i < numberString.Length; i++)
            {
                resultString += numList[int.Parse(numberString[i].ToString())] + " ";
            }

            return resultString.Trim();
        }

        public override bool Equals(object? obj)
        {
            return CurrInput.Equals(obj);
        }

    }
}
