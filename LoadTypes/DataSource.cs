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
        public List<Caliber> Calibers;
        public string source { get; private set; }
        public DataSource()
        {
            Calibers = new List<Caliber>();
        }
        public void AddCaliber(Caliber cal)
        {
            // TODO
        }
        public Caliber Find(string cal) 
        {
            foreach(Caliber Cal in Calibers) 
            {
                if (Cal.CaliberType == cal)
                {
                    return Cal;
                }
            }
            return new Caliber();
        }

    }
}
