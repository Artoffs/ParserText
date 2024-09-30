namespace TextParser.Tokens
{
    public abstract class Token
    {
        protected string TokenType { get; }

        public Token(string TokenType)
        {
            this.TokenType = TokenType;
        }

        public override string ToString()
        {
            return TokenType;
        }
    }
}







