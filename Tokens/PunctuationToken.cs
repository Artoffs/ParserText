namespace TextParser.Tokens
{
    public class PunctuationToken : Token
    {
        private string value { get; }

        public PunctuationToken(string value) : base("Punctuation")
        {
            this.value = value;
        }

    }
}
