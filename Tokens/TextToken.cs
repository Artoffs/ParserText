namespace TextParser.Tokens
{
    public class TextToken : Token
    {
        private List<SentenceToken> value { get; }

        public TextToken(List<SentenceToken> value) : base("Text") 
        {
            this.value = value;
        }

        public override string ToString()
        {
            return String.Join("", value);
        }

        public TextToken SortTextByAscendingOrder()
        {
            return new TextToken(value.OrderBy(x => x.getNumberOfWords()).ToList());
        }
        public TextToken SortTextByLength()
        {
            return new TextToken(value.OrderBy(x => x.getLenghtOfSentence()).ToList());
        }
    }
}
