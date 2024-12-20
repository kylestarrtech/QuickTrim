﻿using FFMpegCore.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickTrimForms {

    public enum QuickTrimCPUUsage {
        Default         = 0,
        Slower          = 1,
        Slow            = 4
    }

    public class QuickTrimSettings {
        public int ConstantRateFactor { get; set; }
        public QuickTrimCPUUsage CPUUsage { get; set; }
        public Speed EncoderPreset { get; set; }
        public bool EncodeSpecificFramerate { get; set; }
        public int SetFrameRate { get; set; }
    }
}
