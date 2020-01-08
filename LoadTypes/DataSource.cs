using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            int index = FindCaliber(cal);
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
        /// <returns> Returns the index at which the object resides, else -1 </returns>
        public int FindCaliber(string cal)
        {
            for (int i = 0; i < Calibers.Count; ++i) 
            {
                if (Calibers[i].CaliberSName == cal.ToLower())
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Finds if the caliber object already exists in the list
        /// </summary>
        /// <param name="cal"> Takes a Caliber object to see if exists </param>
        /// <returns> Returns the index at which the object resides, else -1 </returns>
        public int FindCaliber(Caliber cal)
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

        /// <summary>
        /// Formats the contents of a caliber object
        /// </summary>
        /// <returns></returns>
        public string CaliberToString(Caliber cal) 
        {
            StringBuilder sb = new StringBuilder();
            int numBrands = cal.Brands.Count();
            sb.Append(cal.CaliberFName + " --> ");

            for (int i = 0; i < numBrands; ++i)
            {
                int numBulletBrands = cal.Brands[i].Bullets.Count();
                sb.Append(cal.Brands[i].BrandName + " --> ");

                for (int j = 0; j < numBulletBrands; ++j) 
                {
                    int numBulletTypes = cal.Brands[i].Bullets[j].Powders.Count();
                    sb.Append(cal.Brands[i].Bullets[j].BulletDescription + ":\nPowder\t");

                    for (int k = 0; k < numBulletTypes; ++k)
                    {
                        int numDataEntries = cal.Brands[i].Bullets[j].Powders.Count();
                        sb.Append(cal.Brands[i].Bullets[j].Powders[k].PowderName + ":\t");

                        for (int l = 0; l < numDataEntries; ++l)
                        {

                        }

                    }
                }

            }

            return "";
        }

    }
}
