using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadTypes
{
    class BulletInfo
    {
        #region data members
        /* 
        *  Data members: B.C, S.D, Type, Weight, recommended powder load, fps per load, etc.
        */
        public List<PowderInfo> Powders; // Each PowderStats item will contain info on a specific powder 

        #endregion data members


        #region Properties

        /// <summary>
        /// In ballistics, the ballistic coefficient (BC) of a bullet is a measure of its ability to 
        /// overcome air resistance in flight. A high BC means the object will slow down less. 
        /// It will have more of its speed left when it reaches the target. BC depends on mass, 
        /// diameter, and drag coefficient.
        /// </summary>
        public float Bullet_Coefficient { get; private set; }
        /// <summary>
        /// Sectional density (SD) is the numerical result of a calculation that compares a bullet's 
        /// weight to its diameter. To calculate a bullet's sectional density divide the bullet's 
        /// weight (in pounds) by its diameter (in inches), squared.
        /// </summary>
        public float Sectional_Density { get; private set; }
        /// <summary>
        /// Bullet brand i.e., Hornady, Winchester, Federal, etc.
        /// </summary>
        public float Bullet_Brand { get; private set; }
        /// <summary>
        /// Bullet weight is measured in grains
        /// </summary>
        public int Bullet_Weight { get; private set; }
        /// <summary>
        /// Not always needed, as it falls under specific calibers
        /// </summary>
        public float Bullet_Diameter { get; private set; }

        #endregion Properties

        #region constructors / destructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public BulletInfo() { }

        /// <summary>
        /// Destructor
        /// </summary>
        ~BulletInfo() { }
        #endregion constructors / destructors

        #region functions

        #endregion functions

    }
}
