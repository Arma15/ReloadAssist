using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadTypes
{
    public class PowderType
    {
        #region Data Fields
        /// <summary>
        /// holds the amount of powder as key and value is velocity
        /// </summary>
        public Dictionary<float, float> P_Load_Velocity { get; private set; }

        /// <summary>
        /// EX: IMR4198, CFE223, etc..
        /// </summary>
        public string PowderModel { get; private set; }

        #endregion Data Fields

        #region Constructors / Destructors
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_name"></param>
        public PowderType(string p_name) { PowderModel = p_name; }

        #endregion Constructors / Destructors

        #region Functions

        #endregion Functions
    }
}
