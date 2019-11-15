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
        /******************************************************************************************
		 * Operator overloading and Overrides
		******************************************************************************************/
        #region Operator Overloading and Overrides
        public static bool operator == (Caliber LHS, Caliber RHS)
        {
            if (ReferenceEquals(LHS, RHS))
            {
                return true;
            }
            if (RHS is null)
            {
                return false;
            }
            return LHS.Equals(RHS);
        }
        public static bool operator != (Caliber LHS, Caliber RHS)
        {
            return !(LHS.Equals(RHS));
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = CaliberSName.GetHashCode();
                hashCode = (hashCode * 397) ^ CaliberFName.GetHashCode();
                return hashCode;
            }
        }
        public override bool Equals(object RHS) { return this.CaliberSName == ((Caliber)RHS).CaliberSName; }
        #endregion

        /******************************************************************************************
		 * Constructor / Destructor
		******************************************************************************************/
        #region Constructor and Destructor
        /// <summary>
        /// Constructor to initialize the type of caliber
        /// </summary>
        /// <param name="type"></param>
        public Caliber(string type)
        {
            CaliberSName = type;
            SetFName();
        }
        ~Caliber() {}
        #endregion

        /******************************************************************************************
		 * Data Members and Properties
		******************************************************************************************/
        #region Data Members and Properties
        /// <summary> ie, 224, 762x39, 762x51, etc. </summary>
        public string CaliberSName { get; private set; }
        /// <summary> ie, .224, 7.62x39, 7.62x51, etc. </summary>
        public string CaliberFName { get; private set; }
        /// <summary>
        /// Will hold the specifications on the source the 
        /// data was generated, i.e., Remington 700, 26", 
        /// 1 in 12 twist... etc.
        /// </summary>
        public string CaliberInfo { get; private set; }
        /// <summary>class holding the bullet specs </summary>
        public List<BulletBrand> Brands;
        /// <summary> Max case length per the specifications/caliber </summary>
        public float MaxCOL { get; private set; }
        /// <summary> Max case length per the caliber </summary>
        public float MaxCaseLen { get; private set; }
        /// <summary> Recommended length to trim if needed </summary>
        public float CaseTrimLen { get; private set; }
        #endregion

        /******************************************************************************************
		 * Public Methods
		******************************************************************************************/
        #region Public Methods
        /// <summary> TODO: figure out what parameters are needed for estimate, **move to diff class** </summary>
        public float BulletDropEst() { return 0; }

        /// <summary>
        /// Add a new bullet to the list if not already in there, else append data
        /// </summary>
        /// <param name="bt"></param>
        public void AddBulletBrand(BulletBrand bt)
        {
            int index = Find(bt);
            // Check if bullet type exists in the List, if so then append data
            // else add the whole data structure to the list of bullet types
            if (index > 0)
            {
                Brands.Add(bt);
            }
            else
            {
                // TODO
            }
        }

        /// <summary>
        /// Finds if the bullet type exists in the list
        /// </summary>
        /// <param name="bt"> Compares the string to data member BulletBrand </param>
        /// <returns> Returns the object if found, else null </returns>
        public BulletBrand Find(string bt)
        {
            for (int i = 0; i < Brands.Count; ++i)
            {
                if (Brands[i].BrandName == bt)
                {
                    return Brands[i];
                }
            }

            return null;
        }

        /// <summary>
        /// Finds if the bullet type exists in the list
        /// </summary>
        /// <param name="bt"> Takes object of BulletType to see if exists in list </param>
        /// <returns> Returns the index if found, else -1 </returns>
        public int Find(BulletBrand bt)
        {
            for (int i = 0; i < Brands.Count; ++i)
            {
                if (Brands[i] == bt)
                {
                    return i;
                }
            }

            return Program.NOINDEX;
        }

        /// <summary>
        /// Sets fullname for reading purposes
        /// </summary>
        private void SetFName()
        {
            switch (CaliberSName)
            {
                case "223":
                    CaliberFName = ".223";
                    break;
                case "5.56":
                    CaliberFName = ".556";
                    break;
                case "762x39":
                    CaliberFName = "7.62x39";
                    break;
                case "762x51":
                    CaliberFName = "7.62x51";
                    break;
                default:
                    CaliberFName = "N/A";
                    break;
            }
        }
        #endregion

    }
}
