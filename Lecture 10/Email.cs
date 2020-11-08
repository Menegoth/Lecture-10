using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_10 {
    class Email : Document {

        //instance variables
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public string Title { get; set; }

        //constructors
        public Email() { }
        public Email(string sender, string recipient, string title, string text) {
            Sender = sender;
            Recipient = recipient;
            Title = title;
            Text = text;
        }

        //methods
        /// <summary>
        /// Return object as string
        /// </summary>
        /// <returns>all instance variables</returns>
        public override string ToString() {

            return "Sender: " + Sender + "\nRecipient: " + Recipient + "\nTitle: " + Title + "\nBody: " + Text;

        }

    }
}
