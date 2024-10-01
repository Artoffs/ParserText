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
            foreach (Token t in words)
            {
                WordToken WordTok;
                PunctuationToken PuncTok;
                if (t is PunctuationToken)
                {
                    PuncTok = (PunctuationToken)t;
                }
                if (t is WordToken) 
                {
                    WordTok = (WordToken)t;
                    result += $"{t.GetType()} ({WordTok.GetValue()})";
                }

            }
            return String.Empty;
        }
    }
}
