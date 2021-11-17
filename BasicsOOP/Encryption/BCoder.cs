using System.Text;

namespace BasicsOOP.Encryption
{
    public class BCoder : IСoder
    {
        /// <summary>
        /// Шифрует строку, выполняя замену каждой буквы, стоящей в алфавите на i-й позиции, на букву того же регистра, расположенную в алфавите на i-й позиции с конца алфавита.
        /// </summary>
        /// <returns></returns>
        public string Encode(string str)
        {
            str = str.ToLower();
            var result = new StringBuilder();
            
            foreach (var ch in str)
            {
                result.Append((char)('я' - ch + 'а'));
            }
            return result.ToString();
        }

        public string Decode(string str) => Encode(str);
    }
}
