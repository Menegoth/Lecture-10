using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_10 {
    class File : Document {

        //instance variables
        public string PathName { get; set; }

        //constructors
        public File() { }
        public File(string pathName, string text) {
            PathName = pathName;
            Text = text;
        }

        //methods
        /// <summary>
        /// Return object as string
        /// </summary>
        /// <returns>all instance variables</returns>
        public override string ToString() {
            return "Pathname: " + PathName + "\nContent: " + Text;
        }

    }
}
