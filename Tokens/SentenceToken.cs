namespace TextParser.Tokens
{
    public class SentenceToken : Token
    {
        private List<Token> words { get; }

        public SentenceToken(List<Token> words) : base("Sentence")
        {
            this.words = words;
        }

        public override string ToString()
        {
            string result = string.Empty;
            foreach (var token in words)
            {
                if (token is WordToken)
                {
                    result += " " + token.ToString();
                }
                if (token is PunctuationToken)
                {
                    result += token.ToString();
                }
            }
            return result;
        }

        public int getNumberOfWords()
        {
            return words.Count;
        }
        
        
    }
}
