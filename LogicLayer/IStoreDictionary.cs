using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    /// <summary>
    /// Interface to storage layer for dictionary
    /// </summary>
    public interface IStoreDictionary
    {
        /// <summary>
        /// Save a dictionary
        /// </summary>
        /// <param name="dico">the dictionary to save</param>
        void Save(IDictionary dico);
        /// <summary>
        /// Load a dictionary
        /// </summary>
        /// <returns>the dictionary to load</returns>
        IDictionary Load();
    }
}
