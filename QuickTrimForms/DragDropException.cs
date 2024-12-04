using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickTrimForms {
    internal class DragDropException : Exception {
        public DragDropException() { }

        public DragDropException(string message) : base(message) { }

        public DragDropException(string message, Exception inner) : base(message, inner) { }

    }
}
