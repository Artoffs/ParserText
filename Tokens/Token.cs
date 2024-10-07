using System.Xml.Serialization;

namespace TextParser.Tokens
{
    public abstract class Token
    {
        [XmlAttribute("type")]
        protected string TokenType { get; }

        protected Token() { }

        public Token(string TokenType)
        {
            this.TokenType = TokenType;
        }

        public string GetTokenType()
        {
            return TokenType;
        }

        public override string ToString()
        {
            return TokenType;
        }

        public abstract int GetLength();
    }
}







