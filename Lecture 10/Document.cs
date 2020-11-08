using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_10 {
    class Document {

        //instance variable
        public string Text { get; set; }

        //constructors
        public Document() { }
        public Document(string text) {
            Text = text;
        }

        //methods

        /// <summary>
        /// Return object as string
        /// </summary>
        /// <returns>value of text</returns>
        public override string ToString() {
            return Text;
        }

    }
}
