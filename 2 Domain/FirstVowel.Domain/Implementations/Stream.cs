namespace FirstVowel.Domain.Implementations
{
    public class Stream : IStream
    {
        public string Input { get; set; }

        public char GetNext()
        {
            var result = Input.Substring(0, 1);
            Input = Input.Remove(0, 1);

            return char.Parse(result);
        }

        public bool HasNext()
        {
            return Input.Length > 0;
        }
    }
}
