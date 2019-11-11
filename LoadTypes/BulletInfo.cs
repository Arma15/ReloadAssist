﻿using System;
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
        /// Sectional density (SD) is the numerical result of a calculation that compares a bullet's 
        /// weight to its diameter. To calculate a bullet's sectional density divide the bullet's 
        /// weight (in pounds) by its diameter (in inches), squared.
        /// </summary>
        public float SectionalDensity { get; private set; }
        /// <summary>
        /// Bullet brand i.e., Hornady, Winchester, Federal, etc.
        /// </summary>
        public string BulletBrand { get; private set; }
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
        public void AddPowder(PowderType pt)
        {
            int index = Find(pt);
            // Check if bullet type exists in the List, if so then append data
            // else add the whole data structure to the list of bullet types
            if (index > 0)
            {
                Powders.Add(pt);
            }
            else
            {
                // TODO
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pt"></param>
        /// <returns></returns>
        private int Find(PowderType pt)
        {
            for (int i = 0; i < Powders.Count; ++i)
            {
                if (Powders[i] == pt)
                {
                    return i;
                }
            }

            return -1;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pt"></param>
        /// <returns></returns>
        private PowderType Find(string pt)
        {
            for (int i = 0; i < Powders.Count; ++i)
            {
                if (Powders[i].PowderName == pt)
                {
                    return Powders[i];
                }
            }

            return null;
        }
        #endregion Public Functions

        #region Private Functions

        #endregion Private Functions

    }
}
