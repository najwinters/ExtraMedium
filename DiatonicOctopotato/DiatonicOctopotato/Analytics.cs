using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiatonicOctopotato
{
    class Analytics
    {
        public static int mCScore;
        public static int fCScore;
        public static int fITBScore;
        public static int average;
        public static bool gotMC = false;
        public static bool gotFC = false;
        public static bool gotFITB = false;
        public static void mCReport(int i) {
            mCScore = i;
            gotMC = true;
        }
        public static void fCReport(int i) {
            fCScore = i;
            gotFC = true;
        }
        public static void fITBReport(int i)
        {
            fITBScore = i;
            gotFITB = true;
        }
        public static int getAV()
        {
            int temp = fITBScore + fCScore + mCScore;
            int aV = temp / 3;
            return aV;
        }
        public static int getCS()
        {
            int cS = fITBScore + fCScore + mCScore;
            return cS;
        }
        public static int getHS()
        {
            int hi = 0;
            if (fITBScore >= fCScore && fITBScore >= mCScore)
            {
                hi = fITBScore;
            }
            else if (fCScore >= fITBScore && fCScore >= mCScore)
            {
                hi = fCScore;
            }
            else if (mCScore >= fITBScore && mCScore >= fCScore)
            {
                hi = mCScore;
            }
            return hi;
        }
    }
}
