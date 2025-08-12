using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApCsharpAdvanceDemos
{
    internal class Trainee
    {
        public string Name { get; set; }
        public string Id { get; set; } = string.Empty;
        public string Course { get; set; }

        public Trainee() { }
        public Trainee(string name, string id, string course)
        {
            Name = name;
            Id = id;
            Course = course;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Id: {Id}, Course: {Course}");
        }

        // write a method to  write Trainee details to a  file using stream writer.

        public void AddTrainee(Trainee trainee , string filepath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filepath, true))
                {
                    writer.WriteLine($"Name: {trainee.Name}, Id: {trainee.Id}, Course: {trainee.Course}");
                }
            }

            catch (IOException ioEx)
            {
                Console.WriteLine($"An I/O error occurred while writing to the file: {ioEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while writing to the file: {ex.Message}");

            }
        }

        // method to read Trainee details from a file using stream reader.
        public void ReadTrainees(string filepath)
        {
            Console.WriteLine($"Reading trainees from file: {filepath}");
            try
            {
                using (StreamReader reader = new StreamReader(filepath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (FileNotFoundException fnfEx)
            {
                Console.WriteLine($"File not found: {fnfEx.Message}");
            }
            catch (IOException ioEx)
            {
                Console.WriteLine($"An I/O error occurred while reading the file: {ioEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
            }
        }
    }
}
