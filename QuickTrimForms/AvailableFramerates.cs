using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickTrimForms {
    public static class AvailableFramerates {
        public static int[] Framerates = new int[] { 24, 30, 60, 75, 90, 120, 144, 165, 180, 240, 360, 480, 500 };

        public static int FindClosestFPS(double fps) {
            int closest = Framerates[0];

            foreach (int framerate in Framerates) {
                if (Math.Abs(fps - framerate) < Math.Abs(fps - closest)) {
                    closest = framerate;
                }
            }

            return closest;
        }
    }
}
