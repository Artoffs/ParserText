using TextParser.Tokens;

namespace TextParser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Parser parser = new Parser("text.txt");
            TextToken text = parser.Parse();
            TextToken SortedText = text.SortTextByAscendingOrder();
            List<string> list = text.GetAllWordsFrom(SentenceType.Interrogative, 12); // 4 12
            TextToken textW = text.DeleteAllWordsCertLength(12);
            Console.WriteLine(SortedText.ToString());
            text.Serialize();
        }
    }
}