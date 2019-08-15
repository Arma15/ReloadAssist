using System;
using System.Collections.Generic;
using System.Linq;

namespace LoadTypes
{
    /// <summary>
    /// Will store bullet info like brand and weight of a bullet
    /// i.e., 35g NTX
    /// </summary>
    public class BulletType
    {
        //  Data members: B.C, S.D, Type, Weight, recommended powder load, fps per load, etc.
        #region Data Fields
        /// <summary>
        /// Each PowderInfo item will contain info on a specific powder 
        /// </summary>
        public List<PowderType> Powders;
        /// <summary>
        /// In ballistics, the ballistic coefficient (BC) of a bullet is a measure of its ability to 
        /// overcome air resistance in flight. A high BC means the object will slow down less. 
        /// It will have more of its speed left when it reaches the target. BC depends on mass, 
        /// diameter, and drag coefficient.
        /// </summary>
        public float BulletCoefficient { get; private set; }
        /// <summary>
        /// COL = case overall length which can be specific to a bullet type
        /// </summary>
        public float COL { get; private set; }
        /// <summary>
        /// Sectional density (SD) is the numerical result of a calculation that compares a bullet's 
        /// weight to its diameter. To calculate a bullet's sectional density divide the bullet's 
        /// weight (in pounds) by its diameter (in inches), squared.
        /// </summary>
        public float SectionalDensity { get; private set; }
        /// <summary>
        /// Bullet brand i.e., Hornady, Winchester, Federal, etc.
        /// </summary>
        public float BulletBrand { get; private set; }
        /// <summary>
        /// Bullet weight is measured in grains
        /// </summary>
        public int BulletWeight { get; private set; }
        /// <summary>
        /// Not always needed, as it falls under specific calibers
        /// </summary>
        public float BulletDiameter { get; private set; }

        #endregion Data Fields

        #region Constructors / Destructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public BulletType() { }
        /// <summary>
        /// Destructor
        /// </summary>
        ~BulletType() { }
        #endregion Constructors / Destructors

        #region Public Functions

        #endregion Public Functions

        #region Private Functions

        #endregion Private Functions

    }
}
