using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionLibrary {

    public class GT100Exception : Exception {

        public int i1 { get; set; }
        public int i2 { get; set; }

        public GT100Exception() : base() {
        }
        public GT100Exception(string message) : base(message) {
        }
        public GT100Exception(string message, Exception innerException)
            : base(message, innerException) {
        }
    }
}
