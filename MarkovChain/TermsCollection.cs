namespace MarkovChain
{
    internal class TermsCollection
    {
        private static readonly Random _rng = new();

        private readonly Dictionary<string, int> _terms = [];
        private int _total;

        public void Add(string term)
        {
            if (!_terms.ContainsKey(term))
            {
                _terms.Add(term, 0);
            }

            _terms[term]++;
            _total++;
        }

        public string Next()
        {
            int accumulator = 0;
            int random = _rng.Next(_total);

            foreach (var termPair in _terms)
            {
                accumulator += termPair.Value;

                if (accumulator >= random)
                {
                    return termPair.Key;
                }
            }

            throw new IndexOutOfRangeException("Accumulator hasn't reached random selector");
        }
    }
}
