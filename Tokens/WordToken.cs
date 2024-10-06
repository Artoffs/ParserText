namespace TextParser.Tokens
{
    public class WordToken : Token
    {

        private string value;

        public WordToken(string value) : base("Word")
        {
            this.value = value;
        }

        public override int GetLength()
        { 
            return value.Length;
        }

        public string GetValue()
        {
            return value;
        }

        public void SetValue(string newValue)
        {
            value = newValue;
        }

        public override string ToString()
        {
            return value;
        }
    }
}
