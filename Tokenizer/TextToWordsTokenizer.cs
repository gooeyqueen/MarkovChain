namespace Tokenizer
{
    public class TextToWordsTokenizer
    {
        public List<string> Tokenize(string text, IEnumerable<string> termsToRemove)
        {
            foreach (var term in termsToRemove)
            {
                text = text.Replace(term, string.Empty);
            }

            text = text.ToLower();

            return text.Split().Where(w => !string.IsNullOrWhiteSpace(w)).ToList();
        }
    }
}
