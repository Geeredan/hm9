class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("--- Name and Surname Check ---");

            //Ask the user to enter their first name and surname
            Console.Write("Enter your first name and surname (e.g., Ivan Ivanovich): ");
            string fullName = Console.ReadLine();

            //Split the string into an array of words using a space as a separator
            string[] words = fullName.Split(' ');
            if (words.Length == 2)
            {
                // Get the first word (index 0) as the name, and the second word (index 1) as the surname
                string firstName = words[0];
                string lastName = words[1];

                if (firstName.Length > 0 && lastName.Length > 0)
                {
                    // Get the first letter of the first name and the first letter of the surname
                    char firstLetterName = firstName[0];
                    char firstLetterSurname = lastName[0];
                    firstLetterName = char.ToUpper(firstLetterName);
                    firstLetterSurname = char.ToUpper(firstLetterSurname);

                    //Compare the letters
                    if (firstLetterName == firstLetterSurname)
                    {
                        Console.WriteLine("The surname starts with the same letter as the first name");
                    }
                    else
                    {
                        Console.WriteLine("The surname does not start with the same letter as the first name");
                    }
                }
                else
                {
                    Console.WriteLine("Error: First name or surname cannot be empty.");
                }
            }
            else
            {
                Console.WriteLine("Error: Please enter exactly two words (First Name and Surname) separated by a space.");
            }

            Console.ReadLine();
        }
    }
