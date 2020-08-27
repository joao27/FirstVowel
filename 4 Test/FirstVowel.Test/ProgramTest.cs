using FirstVowel.Presentation;
using System;
using System.IO;
using Xunit;

namespace FirstVowel.Test
{
    public class ProgramTest
    {
        static readonly string ERROR_MESSAGE =
            "Não foi possível encontrar o primeiro caracter vogal da stream que não se repete após a primeira consoante!";

        [Theory]
        [InlineData("aAbBABacfe", "Output: e")]
        [InlineData("mSeaeXjuar", "Output: u")]
        public void Main_GettingValidInput_ResultInValidOutput(string inserted, string expected)
        {
            // arrange
            var output = new StringWriter();
            Console.SetOut(output);

            var input = new StringReader(inserted);
            Console.SetIn(input);

            // act
            Program.Main();

            // assert
            Assert.Contains(expected, output.ToString());
        }

        [Theory]
        [InlineData("aAbBABacfee")]
        [InlineData("mSeaeXjuaur")]
        public void Main_GettingInvalidInput_ResultInErrorMessageOutput(string inserted)
        {
            // arrange
            var output = new StringWriter();
            Console.SetOut(output);

            var input = new StringReader(inserted);
            Console.SetIn(input);

            // act
            Program.Main();

            // assert
            Assert.Contains(ERROR_MESSAGE, output.ToString());
        }
    }
}
