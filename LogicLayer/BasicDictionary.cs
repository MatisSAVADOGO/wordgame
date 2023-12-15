using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    /// <summary>
    /// Simple dictionary class, to test...
    /// </summary>
    public class BasicDictionary : IDictionary
    {
        private Dictionary<string, string> definitions;
        public BasicDictionary()
        {
            definitions = new Dictionary<string, string>();
            definitions["ordinateur"] = "Une machine servant à faire tourner des programmes";
            definitions["mot"] = "ensemble de lettres";
            definitions["professeur"] = "un être humain qui essaye d'enseigner aux étudiants";
            definitions["etudiant"] = "un être humain qui essaye vainement de comprendre";
            definitions["cours"] = "jamais assez";
            definitions["informatique"] = "science de l'information";
        }
        public int Count => definitions.Count;

        public IEnumerable<string> Words => definitions.Keys;

        public void Add(string word, string def)
        {
            if (definitions.ContainsKey(word))
                throw new WordExists(word);
            definitions[word] = def;
        }

        public bool Contains(string word)
        {
            return definitions.ContainsKey(word.ToLower());
        }

        public string GetDef(string word)
        {
            if (!definitions.ContainsKey(word)) throw new NoSuchWord(word);
            return definitions[word];
        }
    }
}
