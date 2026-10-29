using System.Text;

//class Program
//    {
//       static void Main(string[] args)
//        {
//            Console.WriteLine("--- Name and Surname Check ---");

//            //Ask the user to enter their first name and surname
//            Console.Write("Enter your first name and surname (e.g., Ivan Ivanovich): ");
//            string fullName = Console.ReadLine();

//            //Split the string into an array of words using a space as a separator
//            string[] words = fullName.Split(' ');
//            if (words.Length == 2)
//            {
//                // Get the first word (index 0) as the name, and the second word (index 1) as the surname
//                string firstName = words[0];
//                string lastName = words[1];

//                if (firstName.Length > 0 && lastName.Length > 0)
//                {
//                    // Get the first letter of the first name and the first letter of the surname
//                    char firstLetterName = firstName[0];
//                    char firstLetterSurname = lastName[0];
//                    firstLetterName = char.ToUpper(firstLetterName);
//                    firstLetterSurname = char.ToUpper(firstLetterSurname);

//                    //Compare the letters
//                    if (firstLetterName == firstLetterSurname)
//                    {
//                        Console.WriteLine("The surname starts with the same letter as the first name");
//                    }
//                    else
//                    {
//                        Console.WriteLine("The surname does not start with the same letter as the first name");
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Error: First name or surname cannot be empty.");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Error: Please enter exactly two words (First Name and Surname) separated by a space.");
//            }

//            Console.ReadLine();
//        }
//    }
//////////////////////////////////////////////////////////////////////////////////
//class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Text Report Generator");

//            // Create a StringBuilder instance to store the report
//            StringBuilder report = new StringBuilder();

//            //Add the header and the current date to the report
//            report.AppendLine("MY DAILY REPORT");
//            report.AppendLine($"Date: {DateTime.Now.ToString("dd.MM.yyyy HH:mm")}");
//            report.AppendLine("Events:");

//            bool isEnteringEvents = true;
//            int eventCount = 1;

//            //Loop to get events from the user
//            while (isEnteringEvents)
//            {
//                Console.Write($"Enter event #{eventCount} (or type 'exit' to finish): ");
//                string input = Console.ReadLine();

//                if (input.ToLower() == "exit")
//                {
//                    isEnteringEvents = false;
//                }
//                else if (input.Trim() != "") // Make sure the input is not empty
//                {
//                    // Append the event to the StringBuilder with a dash
//                    report.AppendLine($"- {input}");
//                    eventCount++;
//                }
//            }
//            //Print the final generated report to the console
//            Console.WriteLine("\n--- GENERATED REPORT ---");
//            Console.WriteLine(report.ToString());
//            Console.ReadLine();
//        }
//    }

///////////////////////////////////////////////////////////////////////////////////////////////////////////
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Remove Spaces");

            // Ask the user to enter a string with words separated by commas
            Console.Write("Enter a string with commas (e.g., apple, banana, orange): ");
            string input = Console.ReadLine();

            // Use the Replace method to replace all spaces with an empty string ("")
            string result = input.Replace(" ", "");

            //Print the result
            Console.WriteLine("\nResult without spaces:");
            Console.WriteLine(result);
        }
    }
