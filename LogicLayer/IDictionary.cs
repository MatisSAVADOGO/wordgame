namespace LogicLayer
{
    /// <summary>
    /// Interface to a dictionary
    /// </summary>
    public interface IDictionary
    {
        /// <summary>
        /// Number of words in the dictionary
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Tell if a word is in the dictionary
        /// </summary>
        /// <param name="word">the word to find</param>
        /// <returns>true if word is known</returns>
        bool Contains(string word);

        /// <summary>
        /// Get the definition of a word
        /// </summary>
        /// <param name="word">the word to find</param>
        /// <returns>the definition of the word</returns>
        /// <exception cref="NoSuchWord">If the word does not exist</exception>
        string GetDef(string word);

        /// <summary>
        /// Get all the words
        /// </summary>
        IEnumerable<string> Words { get; }

        /// <summary>
        /// Add a word and its definition
        /// </summary>
        /// <param name="word">word to add</param>
        /// <param name="def">definition of the word</param>
        /// <exception cref="WordExists">If the word already exists</exception>
        void Add(string word, string def);

    }
}