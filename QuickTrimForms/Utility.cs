using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickTrimForms {
    public static class Utility {
        public static bool IsNumber(string str) {
            int val;
            bool isInt = int.TryParse(str, out val);

            if (!isInt) { return isInt; }

            return isInt;
        }

        public static int GetNumber(string str) {
            if (!IsNumber(str)) {
                return -int.MaxValue;
            }

            return int.Parse(str);
        }

        public static long GetCurrentEpoch() {
            TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1);
            int secondsSinceEpoch = (int)t.TotalSeconds;

            return secondsSinceEpoch;
        }
    }
}
