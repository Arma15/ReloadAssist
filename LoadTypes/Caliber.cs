using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadTypes
{
    /// <summary>
    /// This class will hold a type of caliber for reloading
    /// application, i.e., .224, 7.62x39, 7.62.51(.308), etc.
    /// </summary>
    class Caliber
    {
        /// <summary>
        /// ie, .224, 7.62x39, 7.62x51, etc.
        /// </summary>
        public string Caliber_Name { get; private set; }
        /// <summary>
        /// class holding the bullet specs
        /// </summary>
        public BulletInfo B_Info { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public float Max_COL { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public float Max_Case_Length { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public float Case_Trim_Length { get; private set; }

        /// <summary>
        /// TODO: figure out what parameters are needed for estimate
        /// </summary>
        /// <returns></returns>
        public float BulletDropEst() { return 0; }

    }
}
