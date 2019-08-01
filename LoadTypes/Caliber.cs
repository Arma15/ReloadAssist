using System;
using System.Collections.Generic;
using System.Linq;

namespace LoadTypes
{
    /// <summary>
    /// This class will hold a type of caliber for reloading
    /// application, i.e., .224, 7.62x39, 7.62.51(.308), etc.
    /// </summary>
    public class Caliber
    {
        /// <summary>
        /// ie, .224, 7.62x39, 7.62x51, etc.
        /// </summary>
        public string CaliberType { get; private set; }
        /// <summary>
        /// Will hold the specifications on the source the 
        /// data was generated from, i.e., Remington 700, 26", 
        /// 1 in 12 twist... etc.
        /// </summary>
        public string CaliberInfo { get; private set; }
        /// <summary>
        /// class holding the bullet specs
        /// </summary>
        public List<BulletType> BulletTypes { get; set; } 
        /// <summary>
        /// Max case length per the specifications/caliber
        /// </summary>
        public float MaxCOL { get; private set; }
        /// <summary>
        /// Max case length per the caliber
        /// </summary>
        public float MaxCaseLen { get; private set; }
        /// <summary>
        /// Recommended length to trim if needed
        /// </summary>
        public float CaseTrimLen { get; private set; }
        /// <summary>
        /// TODO: figure out what parameters are needed for estimate, **move to diff class**
        /// </summary>
        /// <returns></returns>
        public float BulletDropEst() { return 0; }

    }
}
