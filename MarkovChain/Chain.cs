namespace MarkovChain
{
    public class Chain<T> where T : notnull, IEquatable<T>
    {
        private readonly Dictionary<T, TermsCollection<T>> _terms = [];

        public void Add(T termA, T termB)
        {
            if (!_terms.ContainsKey(termA))
            {
                _terms.Add(termA, new TermsCollection<T>());
            }

            _terms[termA].Add(termB);
        }

        public T Next(T term)
        {
            return _terms[term].Next();
        }
    }
}
