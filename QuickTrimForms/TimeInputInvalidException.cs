using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickTrimForms {
    internal class TimeInputInvalidException : Exception {
        public TimeInputInvalidException() { }

        public TimeInputInvalidException(string message) : base(message) { }

        public TimeInputInvalidException(string message, Exception inner) : base(message, inner) { }
    }
}
