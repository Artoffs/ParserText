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

        public override int GetLength()
        {
            return value.Count;
        }

        private List<SentenceToken> GetAllSentencesByType(SentenceType type)
        {
            List<SentenceToken> result = new List<SentenceToken>();
            foreach (SentenceToken sentence in value)
            {
                if(sentence.GetSentenceType() == type)
                {
                    result.Add(sentence);
                }
            }
            return result;
        }

        public List<string> GetAllWords()
        {
            List<string> result = [];
            foreach (SentenceToken sentence in value)
            {
                List<string> words = sentence.ConvertSentenceToWordsArray();
                foreach (string word in words)
                {
                    result.Add(word);
                }
            }
            return result;
        }

        // Task 3
        public List<string> GetAllWordsFrom(SentenceType type, int length)
        {
            List<string> result = [];
            List<SentenceToken> sentences = GetAllSentencesByType(type);
            foreach (SentenceToken sentence in sentences)
            {
                List<string> words = sentence.ConvertSentenceToWordsArray();
                foreach (string word in words)
                {
                    if (word.Length == length && !result.Contains(word))
                    {
                        result.Add(word);
                    }
                }
            }
            return result;
        }

        // task 4
        public TextToken DeleteAllWordsCertLength(int length)
        {
            List<string> words = GetAllWords();
            List<string> result = [];
            foreach (string word in words)
            {
                if (word.Length != length && (Constants.FULL_CONSONANTS + Constants.PUNCTUATION).Contains(word[0]))
                {
                    result.Add(word);
                }
            }
            Parser parser = new Parser(null, string.Join(" ", result.ToArray()));
            return parser.Parse();
        }

        //task 5
        public void ReplaceWordsByLength(int index, int length, string rep)
        {
            SentenceToken sentence = value[index];
            foreach (Token word in sentence.GetWords())
            {
                if (word.GetLength() == length)
                {
                    ((WordToken)word).SetValue(rep);
                }
            }
        }

        // task 1
        public TextToken SortTextByAscendingOrder()
        {
            return new TextToken(value.OrderBy(x => x.getNumberOfWords()).ToList());
        }
        //task 2
        public TextToken SortTextByLength()
        {
            return new TextToken(value.OrderBy(x => x.getLenghtOfSentence()).ToList());
        }
    }
}
