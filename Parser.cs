using TextParser.Tokens;

namespace TextParser
{
    public class Parser
    {
        private const string RUSSIAN_ALPHABET = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        private const string ENGLISH_ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        private const string FULL_ALPHABET = RUSSIAN_ALPHABET + ENGLISH_ALPHABET;
        private const string PUNCTUATION = "!?.";

        private int currentIndex = -1;
        private char currentChar;
        private string text;

        public Parser(string filename)
        {
            this.text = ExtractText(filename);
        }

        public TextToken Parse()
        {
            List<SentenceToken> text = new List<SentenceToken>();
            Advance();

            while (currentIndex != -1)
            {
                text.Add(MakeSentence());
            }
            return new TextToken(text); 
        }

        private SentenceToken MakeSentence()
        {
            List<Token> sentence = new List<Token>();
            do
            {
                if (FULL_ALPHABET.Contains(currentChar))
                {
                    sentence.Add(MakeWord());
                    Advance();
                }
                if (currentChar == ',')
                {
                    sentence.Add(new PunctuationToken(","));
                    Advance();
                }
                if (PUNCTUATION.Contains(currentChar))
                {
                    sentence.Add(new PunctuationToken(currentChar.ToString()));
                    Advance();
                }
                if (currentChar == ' ')
                {
                    Advance();
                }
            } while (!PUNCTUATION.Contains(currentChar));

            return new SentenceToken(sentence);
        }

        private WordToken MakeWord()
        {
            string str = "";
            while (FULL_ALPHABET.Contains(currentChar))
            {
                str += currentChar;
                Advance();
            }
            return new WordToken(str);
        }

        private void Advance()
        {
            if (currentIndex + 1 < text.Length)
            {
                currentIndex++;
                currentChar = text[currentIndex];
            }
            else
            {
                currentIndex = -1;
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
