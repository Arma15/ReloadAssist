using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadTypes
{
    class Caliber
    {
        /*
        * This class will hold a type of caliber for reloading
        * application. i.e., .224, 7.62x39, 7.62.51(.308), etc.
        * Data members will be: BulletInfo (class holding the bullet specs), Max_C.O.L, diameter, 
        * max_case_length, Case_trim_length.
        * 
        * Member methods: bullet drop est., 
        */
        public string Caliber_Name { get; private set; } // ie, .224, 7.62x39, 7.62x51, etc.
        public BulletInfo B_Info { get; private set; }
        public float Max_COL { get; private set; }
        public float Max_Case_Length { get; private set; }
        public float Case_Trim_Length { get; private set; }

        public float BulletDropEst() { return 0; } // figure out what parameters are needed for estimate

    }
}
