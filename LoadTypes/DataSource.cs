using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadTypes
{
    /// <summary>
    /// Primary class that holds data from different primary 
    /// sources, i.e., hornady book data, personal data, etc.
    /// </summary>
    public class DataSource
    {
        private List<Caliber> Calibers;
        public string source { get; private set; }

        public void AddCaliber(Caliber cal)
        {
            // TODO
        }


    }
}
