using System;
using System.Collections.Generic;
using System.Text;

namespace NumberGuesser
{
    /// <summary>
    /// 1. ask for real number 2. if not 50 ask higher or lower
    /// 3. guess 25 or 75. 
    /// 4. keep diving by 2 and asking higher or lower
    /// 5. if number is right at any time stop program
    /// </summary>
    class GuessWork
    {
        public static int realNum;
        public int isLower;
        public int isHigher;
        public string correctNum;
    }
    
}

