using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility.IDChecker
{
    internal class StringEqualizer
    {
        public string ReplaceEnglishLetters(string input)
        {
            Dictionary<char, char> translationMap = new Dictionary<char, char>
            {   
                {'A', 'А'}, {'B', 'В'}, {'C', 'С'}, {'E', 'Е'}, {'H', 'Н'}, {'K', 'К'},
                {'M', 'М'}, {'O', 'О'}, {'P', 'Р'}, {'T', 'Т'}, {'X', 'Х'}, {'a', 'а'},
                {'c', 'с'}, {'e', 'е'}, {'o', 'о'}, {'p', 'р'}, {'x', 'х'}
            };

            StringBuilder result = new StringBuilder();

            foreach (char c in input)
            {
                if (translationMap.TryGetValue(c, out char translatedChar))
                {
                    result.Append(translatedChar);
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
    }
}
