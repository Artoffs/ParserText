namespace TextParser.Tokens
{
    public class TextToken : Token
    {
        private List<SentenceToken> value { get; }

        public TextToken(List<SentenceToken> value) : base("Text") 
        {
            this.value = value;
        }
    }
}
