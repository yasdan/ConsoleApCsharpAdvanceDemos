using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApCsharpAdvanceDemos
{
    internal class DictionaryDemo
    {
        public DictionaryDemo() { }

        public void DictionaryDemoMethod()
        {
            // Create a dictionary to store student names and their scores
            Dictionary<string, int> studentScores = new Dictionary<string, int>();
            // Add some students and their scores
            studentScores.Add("Alice", 85);
            studentScores.Add("Bob", 92);
            studentScores.Add("Charlie", 78);
            // Display the students and their scores
            Console.WriteLine("Student Scores:");
            foreach (var student in studentScores)
            {
                Console.WriteLine($"{student.Key}: {student.Value}");
            }
            // Check if a student exists in the dictionary
            string searchStudent = "Bob";
            if (studentScores.ContainsKey(searchStudent))
            {
                Console.WriteLine($"{searchStudent} is found with a score of {studentScores[searchStudent]}.");
            }
            else
            {
                Console.WriteLine($"{searchStudent} is not found in the dictionary.");
            }
            // Remove a student from the dictionary
            studentScores.Remove("Charlie");
            
            Console.WriteLine("After removing Charlie:");
            foreach (var student in studentScores)
            {
                Console.WriteLine($"{student.Key}: {student.Value}");
            }
        }
    }
}
