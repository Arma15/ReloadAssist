﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadTypes
{
    public class BulletBrand
    {
        /******************************************************************************************
        * Data Members and Properties
        ******************************************************************************************/
        #region Data Fields

        /// <summary> Bullet brand i.e., Hornady, Winchester, Federal, etc. </summary>
        public string BrandName { get; private set; } 
        /// <summary> Holds different types of bullets for this brand </summary>
        public List<BulletType> Bullets;

        #endregion Data Fields

        /******************************************************************************************
        * Constructors / Destructors
        ******************************************************************************************/
        #region Constructors / Destructors
        public BulletBrand(string name)
        {
            BrandName = name;
        }
        ~BulletBrand() { }
        #endregion Constructors / Destructors

        #region Public Methods
        /// <summary>  </summary>
        /// <param name="bt"></param>
        public void AddBullet(BulletType bt)
        {
            int index = Find(bt);
            if (index < 0)
            {
                Bullets.Add(bt);
            }
            else
            {
                // TODO
            }
        }

        /// <summary>  </summary>
        /// <param name="name"></param>
        public BulletType Find(string name)
        {
            for (int i = 0; i < Bullets.Count; ++i)
            {
                if (Bullets[i].Type == name)
                {
                    return Bullets[i];
                }
            }

            return null;
        }

        /// <summary>  </summary>
        /// <param name="bt"></param>
        public int Find(BulletType bt)
        {
            for (int i = 0; i < Bullets.Count; ++i)
            {
                if (Bullets[i] == bt)
                {
                    return i;
                }
            }
            return Program.NOINDEX;
        }
        
        #endregion Public Methods

        #region Private Methods

        #endregion Private Methods
    }
}