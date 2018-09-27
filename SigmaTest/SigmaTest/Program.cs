using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigmaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.Count(60,80));
            Console.WriteLine(Program.ToCamelCase("The-first-WORD"));
        }


        /*
         Method, that counts number of numbers,
         that contain number "7"
         */
        public static int Count(int a, int b)
        {
            int count = 0;
            for(;a<b;a++)
            {
                string c = Convert.ToString(a);
                for(int i=0;i<c.Length;i++)
                    if(c[i]=='7')
                    {
                        count++;
                        break;
                    }
            }
            return count;
        }

        /*
         * Method take string in which word split by 
         * "-" and " ". Method must return converted 
         * string, where word writed together, and every
         * word inside the phrase write from Uppercase
         * letter
         */
        public static string ToCamelCase(string a)
        {
            string[] del = a.Split('-', ' ');
            string result="";
            string bad_letter="";

            result += del[0].ToLower();
            for(int i=1;i<del.Length;i++)
            {
                string bad_word = (string) del[i];
                for (int j = 0; j < bad_word.Length; j++)
                {
                    bad_letter = bad_word[j].ToString();
                    if (j == 0)
                        result += bad_letter.ToUpper();
                    else
                        result += bad_letter.ToLower();
                }

            }
            return result;
        }
    }
}
