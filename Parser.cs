using TextParser.Tokens;

namespace TextParser
{
    public class Parser
    {
        private int currentIndex = -1;
        private char currentChar;
        private string text;

        public Parser(string? filename = null, string? text = null)
        {
            if (filename != null && text == null)
            {
                this.text = ExtractText(filename);
            }
            else if (filename == null && text != null) 
            {
                this.text = text;
            }
            else 
            {
                throw new ArgumentException();
            }
        }

        public TextToken Parse()
        {
            List<SentenceToken> rtext = new List<SentenceToken>();
            Advance();

            while (currentIndex != -1)
            {
                rtext.Add(MakeSentence());
                Advance();
            }
            return new TextToken(rtext); 
        }

        private SentenceToken MakeSentence()
        {
            List<Token> sentence = new List<Token>();
            do
            {
                if (Constants.FULL_ALPHABET.Contains(currentChar))
                {
                    sentence.Add(MakeWord());
                }
                if (currentChar == ',')
                {
                    sentence.Add(new PunctuationToken(","));
                    Advance();
                }
                if (currentChar == ' ')
                {
                    Advance();
                }
                if (Constants.PUNCTUATION.Contains(currentChar))
                {
                    sentence.Add(new PunctuationToken(currentChar.ToString()));
                }
                if (currentChar == '\n' || currentChar == '\r')
                {
                    Advance();
                }
            } while (!Constants.PUNCTUATION.Contains(currentChar));

            return new SentenceToken(sentence);
        }

        private WordToken MakeWord()
        {
            string str = "";
            while (Constants.FULL_ALPHABET.Contains(currentChar))
            {
                str += currentChar;
                Advance();
            }
            return new WordToken(str);
        }

        private void Advance()
        {
            if (currentIndex + 1 == text.Length)
            {
                currentIndex = -1;
                currentChar = '\0';
            }
            else
            {
                currentIndex++;
                currentChar = text[currentIndex];
            }
        }
        private string ExtractText(string filename)
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                return sr.ReadToEnd();
            }
        }
    }
}
