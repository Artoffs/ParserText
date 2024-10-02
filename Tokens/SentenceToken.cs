namespace TextParser.Tokens
{
    public enum SentenceType
    {
        Declarative,
        Interrogative,
        Exclamatory
    }

    public class SentenceToken : Token
    {
        private List<Token> words { get; }
        private SentenceType type;

        public SentenceToken(List<Token> words) : base("Sentence")
        {
            this.words = words;
            this.type = CheckSentenceType();
        }

        private SentenceType CheckSentenceType()
        {
            foreach (var token in this.words)
            {
                if (token is PunctuationToken)
                {
                    switch (((PunctuationToken)token).ToString())
                    {
                        case "!":
                            return SentenceType.Interrogative;
                        case "?":
                            return SentenceType.Exclamatory;
                    }
                }
            }
            return SentenceType.Declarative;
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
            int wordCount = 0;
            foreach (var token in words)
            {
                if (token is WordToken)
                {
                    wordCount++;
                }
            }
            return wordCount;
        }

        public int getLenghtOfSentence()
        {
            int lenghtOfSentence = 0;
            foreach (var token in words)
            {
                if (token is WordToken)
                {
                    lenghtOfSentence += ((WordToken)token).GetValue().Length;
                }
                else if (token is PunctuationToken)
                {
                    lenghtOfSentence++;
                }
            }
            return lenghtOfSentence;
        }
        
    }
}
