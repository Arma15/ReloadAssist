using System;
using System.Collections.Generic;

namespace LoadTypes
{
    public class PowderType
    {
        #region Data Fields
        /// <summary>
        /// holds the amount of powder as key and value is velocity 
        /// generated from the powder load, i.e., 35.5gr, 2530 fps
        /// </summary>
        public Dictionary<float, float> PowderLoadVelocity { get; private set; }

        /// <summary>
        /// Ex: IMR4198, CFE223, etc..
        /// </summary>
        public string PowderName { get; private set; }

        #endregion Data Fields

        #region Constructors / Destructors
        /// <summary>
        /// Constructor that sets
        /// </summary>
        /// <param name="powdername"></param>
        public PowderType(string powdername) { PowderName = powdername; }

        #endregion Constructors / Destructors

        #region Functions
        public void AddPowderLoadAndVelocity(float powderLoad, float velocity)
        {

        } 
        #endregion Functions
    }
}
