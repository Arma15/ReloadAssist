using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadTypes
{
    public class LoadSpecifics
    {
        /// <summary>
        /// Types of Guns
        /// </summary>
        public List<string> Guns, Calibers, Bullets, BBrand, Powders;


        public LoadSpecifics()
        {
            Guns = new List<string> { "Any", "Handgun", "Rifle" };
            Calibers = new List<string> { "Any", ".223", "5.56", ".308", "7.62x39" };
            Bullets = new List<string> { "Any", "35g NSX", "70g TSX"};
            BBrand = new List<string> { "Any", "Hornady", "Barnes"};
            Powders = new List<string> { "Any", "IMR4198", "CFE223", "Varget"};

            // Sort to keep them in same order indicies as combo boxes will display them
            Guns.Sort();
            Calibers.Sort();
            Bullets.Sort();
            BBrand.Sort();
            Powders.Sort();
        }
    }
}
