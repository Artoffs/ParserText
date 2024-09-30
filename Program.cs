using TextParser.Tokens;

namespace TextParser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Parser parser = new Parser("text.txt");
            TextToken text = parser.Parse();
            Console.WriteLine(parser.ToString());
        }
    }
}