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
        public Dictionary<float, float> PowderLoadVelocity;

        /// <summary> Ex: IMR4198, CFE223, etc. </summary>
        public string PowderName { get; private set; }

        #endregion Data Fields

        #region Constructors / Destructors
        /// <summary>
        /// Constructor that sets
        /// </summary>
        /// <param name="powdername"></param>
        public PowderType(string powdername)
        { 
            PowderName = powdername;
            PowderLoadVelocity = new Dictionary<float, float>();
        }

        #endregion Constructors / Destructors

        #region Functions
        public float FindVelocity(float load)
        {
            if (PowderLoadVelocity.TryGetValue(load, out float value))
            {
                return value;
            }
            Console.WriteLine($"{DateTime.Now}: PowderInfo (duplicate data) --> key: {load} value does not exist for load.");
            return 0.0f;
        }
        public void FindVelocity(float load, ref bool exists)
        {
            if (PowderLoadVelocity.TryGetValue(load, out float value))
            {
                exists = true;
                return;
            }
            Console.WriteLine($"{DateTime.Now}: PowderInfo (duplicate data) --> key: {load} value does not exist for load.");
            exists = false;
        }
        /// <summary>
        /// Updates the velocity of the load if it exists
        /// </summary>
        /// <param name="load"> The load to modify </param>
        /// <param name="velocity">The new velocity </param>
        /// <returns> True if updated, false if does not exist </returns>
        public bool UpdateVelocity(float load, float velocity)
        {
            bool exists = false;
            FindVelocity(load, ref exists);

            if (exists)
            {
                PowderLoadVelocity[load] = velocity;
            }
            return exists;
        }

        public void AddPowderLoadAndVelocity(float powderLoad, float velocity)
        {
            if (PowderLoadVelocity != null && PowderLoadVelocity.ContainsKey(powderLoad))
            {
                // Temporary log system
                Console.WriteLine($"{DateTime.Now}: PowderInfo (duplicate data) --> key: {powderLoad} value(passed): {velocity}, value(existing): {PowderLoadVelocity[powderLoad]} already in dataset");
            }
            else
            {
                PowderLoadVelocity.Add(powderLoad, velocity);
            }
        }
        #endregion Functions
    }
}
