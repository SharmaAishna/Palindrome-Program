using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ispalindrome returns 2 tuples value
           ( bool,int)IsPalindrome(String str)
            {
                string testStr;
                testStr = str.ToUpper();
                //use stringbuilder to stripe out white space
                var sb = new StringBuilder();
                foreach (char c in testStr)
                {
                    if (!char.IsPunctuation(c) && !char.IsWhiteSpace(c))
                    {
                        sb.Append(c);
                    }
                }
             //   Convert builder to finish string
                testStr = sb.ToString();
                //compare characters starting at begining and end of string
                int i = 0, j =testStr.Length - 1;
                //if index crosses we met Palindrome
                while (i <= j)
                {
                    //if character at each index doesnt match, it's not palindrome
                    if (testStr[i] != testStr[j])
                    {
                        return (false, 0);
                    }
                    //update the counter and try again
                    i++;
                    j--;
                }           
                return (true, str.Length);
            }

            string inputstr = "";
            (bool b, int L) result;
            Console.WriteLine("Lets Begin:");
            while (inputstr != "exit")
            {
                inputstr = Console.ReadLine();
                if (inputstr != "exit")
                {
                    result = IsPalindrome(inputstr);
                    Console.WriteLine($"Palindrome:{result.b}, Length: {result.L}");
                }
            }
        }
    }
}
