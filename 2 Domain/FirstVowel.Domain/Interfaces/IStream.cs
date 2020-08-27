namespace FirstVowel.Domain.Implementations
{
    public interface IStream
    {
        public string Input { get; set; }

        public char GetNext();

        public bool HasNext();
    }
}
