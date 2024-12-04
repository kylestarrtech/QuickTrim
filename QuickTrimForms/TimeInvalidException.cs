using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickTrimForms {
    internal class TimeInvalidException : Exception {
        public TimeInvalidException() { }

        public TimeInvalidException(string message) : base(message) { }

        public TimeInvalidException(string message, Exception inner) : base(message, inner) { }
    }
}
