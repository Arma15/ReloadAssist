using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadTypes
{
    class PowderInfo
    {
        #region data members
        /// <summary>
        /// holds the amount of powder as key and value is velocity
        /// </summary>
        public Dictionary<float, float> P_Load_Velocity { get; private set; }

        #endregion data members

        #region Properties
        /// <summary>
        /// EX: IMR4198, CFE223, etc..
        /// </summary>
        public string Powder_Type { get; private set; }

        #endregion Properties

        #region constructors / destructors
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_name"></param>
        public PowderInfo(string p_name) { Powder_Type = p_name; }

        #endregion constructors / destructors

        #region functions

        #endregion functions
    }
}
