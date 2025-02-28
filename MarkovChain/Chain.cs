namespace MarkovChain
{
    public class Chain
    {
        private readonly Dictionary<string, TermsCollection> _terms = [];

        public void Add(string termA, string termB)
        {
            ArgumentNullException.ThrowIfNullOrWhiteSpace(termA);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(termB);

            if (!_terms.ContainsKey(termA))
            {
                _terms.Add(termA, new TermsCollection());
            }

            _terms[termA].Add(termB);
        }

        public string Next(string term)
        {
            return _terms[term].Next();
        }
    }
}
