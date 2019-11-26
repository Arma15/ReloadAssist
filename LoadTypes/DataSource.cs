using System;
using System.Collections.Generic;
using System.Linq;

namespace LoadTypes
{
    /// <summary>
    /// Primary class that holds data from different primary
    /// sources, i.e., hornady book data, personal data, etc.
    /// </summary>
    public class DataSource
    {
        private List<Caliber> Calibers;
        public string Source { get; private set; }
        public DataSource(string src)
        {
            Source = src;
            Calibers = new List<Caliber>();
        }
        public void AddCaliber(Caliber cal)
        {
            // Check if caliber exists in the List, if so then append data to current caliber
            // else add the whole data structure to the list of calibers
            int index = Find(cal);
            // If < 0 then not found, add to List, else add to existing object
            if (index < 0)
            {
                Calibers.Add(cal);
            }
            else // add data to existing object at index "index"
            {
                // TODO
            }
        }
        /// <summary>
        /// Finds if the caliber object already exists in the list
        /// </summary>
        /// <param name="cal"> Takes a string to see if exists </param>
        /// <returns> Returns the caliber object if exists in list, else null </returns>
        public Caliber Find(string cal)
        {
            for (int i = 0; i < Calibers.Count; ++i) 
            {
                if (Calibers[i].CaliberSName == cal.ToLower())
                {
                    return Calibers[i];
                }
            }
            return null;
        }
        /// <summary>
        /// Finds if the caliber object already exists in the list
        /// </summary>
        /// <param name="cal"> Takes a string to see if exists </param>
        /// <returns> Returns the index at which the object resides, else -1 </returns>
        public int Find(Caliber cal)
        {
            for (int i = 0; i < Calibers.Count; ++i)
            {
                if (Calibers[i] == cal)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
