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
        public Dictionary<float, float> P_Load_Velocity { get; private set; } // holds the amount of powder as key and value is velocity

        #endregion data members

        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public string Powder_Type { get; private set; }

        #endregion Properties

        #region constructors / destructors
        public PowderInfo(string p_name) { Powder_Type = p_name; }

        #endregion constructors / destructors

        #region functions

        #endregion functions
    }
}
