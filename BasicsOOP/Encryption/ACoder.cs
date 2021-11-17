using System;
using System.Text;

namespace BasicsOOP.Encryption
{
    public class ACoder : IСoder
    {
        /// <summary>
        /// Класс шифрует строку посредством сдвига  каждого символа на одну «алфавитную» позицию выше.
        /// </summary>
        /// <returns></returns>
        public string Encode(string str)
        {
            str = str.ToLower();
            var result = new StringBuilder();

            foreach (var ch in str)
            {
                var nextChar = ch;
                nextChar = ch == 'я' ? 'а' : ++nextChar;
                result.Append(nextChar);
            }
            return result.ToString();
        }

        public string Decode(string str)
        {
            str = str.ToLower();
            var result = new StringBuilder();

            foreach (var ch in str)
            {
                var nextChar = ch;
                nextChar = nextChar == 'а' ? 'я' : --nextChar;
                result.Append(nextChar);
            }
            return result.ToString();
        }
    }
}
