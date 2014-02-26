using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BraviSoftware.RomanNumerals
{
    public class Converter
    {
        public static string Convert(int number)
        {
            var romanCharacters = new Dictionary<int, string> { { 50, "L"}, { 10, "X" }, { 5, "V" } , { 1, "I" } };

            if (romanCharacters.ContainsKey(number))
                return romanCharacters[number];

            string roman = string.Empty;

            foreach (var pair in romanCharacters)
            {
                while (number >= pair.Key)
                {
                    roman += pair.Value;
                    number -= pair.Key;
                }
                if ((number >= 40 && number < 50)(number == pair.Key-10) && number != 0)
                {
                    roman += "X";
                    roman += pair.Value;
                    number = 0;
                }
                if ((number == pair.Key-1) && number != 0)
                {
                    roman += "I";
                    roman += pair.Value;
                    number = 0;
                }
            }


            //while (number >= 10)
            //{
            //    roman += "X";
            //    number -= 10;
            //}

            //if (number >= 9)
            //{
            //    return "IX";
            //}

            //if (number == 4)
            //{
            //    return roman + "IV";
            //}

            //while (number >= 5)
            //{
            //    roman += "V";
            //    number -= 5;
            //}

            //while (number >= 1)
            //{
            //    roman += "I";
            //    number -= 1;
            //}

            return roman;
        }
    }
}
