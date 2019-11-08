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
            // TODO
            // Check if caliber exists in the List, if so then append data to current caliber
            // else add the whole data structure to the list of calibers
        }
        public Caliber Find(string cal)
        {
            foreach(Caliber Cal in Calibers) 
            {
                if (Cal.CaliberSName == cal)
                {
                    return Cal;
                }
            }
            return new Caliber("");
        }

    }
}
