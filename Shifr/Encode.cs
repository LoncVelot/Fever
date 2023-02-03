using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shifr
{
    public class Code
    {
        private char[] characters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', ' ', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        private int N;
        public string Encode(string input, string keyword)
        {
            N = characters.Length;
            input = input.ToUpper();
            keyword = keyword.ToUpper();

            string result = "";

            int keyword_index = 0;

            foreach (char symbol in input)
            {
                int c = (Array.IndexOf(characters, symbol) + Array.IndexOf(characters, keyword[keyword_index])) % N;

                result += characters[c];

                keyword_index++;

                if ((keyword_index) == keyword.Length)
                    keyword_index = 0;
            }

            return result;
        }
        public string Decode(string input, string keyword)
        {
            N = characters.Length;
            input = input.ToUpper();
            keyword = keyword.ToUpper();

            string result = "";

            int keyword_index = 0;

            foreach (char symbol in input)
            {
                int p = (Array.IndexOf(characters, symbol) + N - Array.IndexOf(characters, keyword[keyword_index])) % N;

                result += characters[p];

                keyword_index++;

                if ((keyword_index) == keyword.Length)
                    keyword_index = 0;
            }

            return result;
        }
    }
}
