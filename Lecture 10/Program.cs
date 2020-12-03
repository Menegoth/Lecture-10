/// Week 10		Lab 
/// File Name: Program.cs
/// @author: Antonio Monteiro

using System;

namespace Lecture_10 {

    class Program {
        static void Main(string[] args) {

            //testing email class
            Email email1 = new Email("John", "James", "Hi", "Hello there");
            Email email2 = new Email();
            email2.Sender = "James";
            email2.Recipient = "John";
            email2.Title = "Hi back";
            email2.Text = "Hey there";
            Console.WriteLine(email1);
            Console.WriteLine(email2);

            //testing file class
            File file1 = new File("C:\\users\\John", "I'm John");
            File file2 = new File();
            file2.PathName = "C:\\Users\\James";
            file2.Text = "I'm James";
            Console.WriteLine(file1);
            Console.WriteLine(file2);

            //testing for keyword
            Console.WriteLine(ContainsKeyword(email1, "Hello"));
            Console.WriteLine(ContainsKeyword(email2, "Hello"));
            Console.WriteLine(ContainsKeyword(file1, "James"));
            Console.WriteLine(ContainsKeyword(file2, "James"));


        }

        public static bool ContainsKeyword(Document docObject, string keyword) {
            if (docObject.ToString().IndexOf(keyword, 0) >= 0) {
                return true;
            } else {
                return false;
            }
        }

    }
}
