using System;
using System.Collections.Generic;
using System.Text;

namespace FirstVowel.Common.Constants
{
    public static class Alphabet
    {
        public static List<char> Vowel 
        { 
            get 
            { 
                return new List<char> { 'a', 'e', 'i', 'o', 'u' }; 
            } 
        }

        public static List<char> Consonant
        {
            get
            {
                return new List<char>
                {
                    'b',
                    'c',
                    'd',
                    'f',
                    'g',
                    'h',
                    'j',
                    'k',
                    'l',
                    'm',
                    'n',
                    'p',
                    'q',
                    'r',
                    's',
                    't',
                    'v',
                    'w',
                    'x',
                    'y',
                    'z'
                };
            }
        }
    }
}
