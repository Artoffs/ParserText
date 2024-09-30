namespace TextParser.Tokens
{
    public class WordToken : Token
    {
        private string value { get; }
        public WordToken(string value) : base("Word")
        {
            this.value = value;
        }

        public string GetValue()
        {
            return this.value;
        }
    }
}
