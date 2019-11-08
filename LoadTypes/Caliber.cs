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
            
        }
        public static bool operator != (Caliber LHS, Caliber RHS)
        {
            return !(LHS == RHS);
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
        /// <summary>
        /// Constructor to initialize the type of caliber
        /// </summary>
        /// <param name="type"></param>
        public Caliber(string type)
        {
            CaliberSName = type;
            SetFName();
        }
        /// <summary>
        /// ie, 224, 762x39, 762x51, etc.
        /// </summary>
        public string CaliberSName { get; private set; }
        /// <summary>
        /// ie, .224, 7.62x39, 7.62x51, etc.
        /// </summary>
        public string CaliberFName { get; private set; }
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
        /// <summary>
        /// Add a new bullet to the list
        /// </summary>
        /// <param name="bt"></param>
        public void AddBulletType(BulletType bt)
        {

        }
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



    }
}
