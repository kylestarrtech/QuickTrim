using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickTrimForms {
    public static class Utility {
        public static bool IsNumber(string str) {
            double val;
            bool isNum = double.TryParse(str, out val);

            if (!isNum) { return isNum; }

            return isNum;
        }

        public static double GetNumber(string str) {
            if (!IsNumber(str)) {
                return -double.MaxValue;
            }

            return double.Parse(str);
        }

        public static long GetCurrentEpoch() {
            TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1);
            int secondsSinceEpoch = (int)t.TotalSeconds;

            return secondsSinceEpoch;
        }
    }
}
