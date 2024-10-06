namespace TextParser.Tokens
{
    public class PunctuationToken : Token
    {
        private string value { get; }

        public PunctuationToken(string value) : base("Punctuation")
        {
            this.value = value;
        }

        public override string ToString()
        {
            return value;
        }

        public override int GetLength()
        {
            return value.Length;
        }

    }
}
