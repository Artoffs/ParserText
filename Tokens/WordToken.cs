using System.Xml.Serialization;

namespace TextParser.Tokens
{
    public class WordToken : Token
    {
        [XmlText]
        private string value;

        public WordToken() : base("Word")
        { }

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
