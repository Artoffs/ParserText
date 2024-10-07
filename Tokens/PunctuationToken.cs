using System.Xml.Serialization;

namespace TextParser.Tokens
{
    public class PunctuationToken : Token
    {
        [XmlText]
        private string value { get; }

        public PunctuationToken() : base("punctuation") { }

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
