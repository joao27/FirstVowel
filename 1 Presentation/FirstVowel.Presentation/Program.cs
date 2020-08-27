using FirstVowel.Common.Constants;
using FirstVowel.Domain.Implementations;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstVowel.Presentation
{
    public class Program : Base
    {
        public static void Main()
        {
            RegisterServices();

            var stream = Provider.GetService<IStream>();

            Console.Write("Input: ");
            stream.Input = Console.ReadLine();

            var result = FindFirstVowel(stream);

            if (result != default)
                Console.WriteLine("Output: " + result);
            else
                Console.WriteLine("Não foi possível encontrar o primeiro caracter vogal da stream que não se repete após a primeira consoante!");

            Dispose();
        }

        private static char FindFirstVowel(IStream stream)
        {
            var found1 = new List<char>();

            while (stream.HasNext())
            {
                var @char = stream.GetNext();

                if (Alphabet.Consonant.Exists(e => e == char.ToLower(@char)))
                    break;
                else if (Alphabet.Vowel.Exists(e => e == char.ToLower(@char)))
                    found1.Add(@char);
            }

            var found2 = new List<char>();

            while (stream.HasNext())
            {
                var @char = stream.GetNext();

                if (Alphabet.Vowel.Exists(e => e == char.ToLower(@char)) && !found1.Exists(e => char.ToLower(e) == char.ToLower(@char)))
                    found2.Add(@char);
            }

            return found2.GroupBy(g => g).Where(w => w.Count() == 1).Select(s => s.Key)
                .FirstOrDefault();
        }
    }
}
