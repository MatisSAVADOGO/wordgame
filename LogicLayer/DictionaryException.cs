using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    /// <summary>
    /// Generic exception for dictionary errors
    /// </summary>
    public class DictionaryException : Exception
    {
    }

    /// <summary>
    /// Exception thrown when a word not exists in dictionary
    /// </summary>
    public class NoSuchWord : DictionaryException
    {
        private string word;
        /// <summary>
        /// Initialize
        /// </summary>
        /// <param name="word">the word who's not exists</param>
        public NoSuchWord(string word)
        {
            this.word = word;
        }
        public override string Message => "The word "+word+" does not exist.";
    }

    /// <summary>
    /// Exception thrown when a word exists and can not be added
    /// </summary>
    public class WordExists : DictionaryException
    {
        private string word;
        /// <summary>
        /// Initialize
        /// </summary>
        /// <param name="word">the word who exists</param>
        public WordExists(string word)
        {
            this.word = word;
        }

        public override string Message => "The word "+word+" already exists.";
    }
}
