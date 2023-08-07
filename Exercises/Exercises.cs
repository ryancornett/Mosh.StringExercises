namespace Mosh.StringExercises.Exercises
{
    public class Exercises
    {
        Utilities utilities = new Utilities();
        public void Exercise1()
        {
            List<int> list = new List<int>();

            string prompt = "Enter a series of numbers separated by a hyphen:";
            string userInput = utilities.GetUserInput(prompt);
            string[] splitInput = userInput.Split('-');
            
            foreach ( string split in splitInput ) 
            {
                if (Int32.TryParse(split, out int value) )
                {
                    list.Add(value);
                }
            }

            bool checkForContinuity = true;

            for (int i = list.Count - 1; i > 0; i--)
            {
                if (list.Count != list.Distinct().Count() || Math.Abs(list[i] - list[i - 1]) != 1)
                {
                    checkForContinuity = false;
                }
            }

            // This breaks if the user attempts to use a hyphen as a negative sign
            Console.WriteLine(checkForContinuity ? "Consecutive" : "Not Consecutive");
        }

        public void Exercise2()
        {
            List<int> list = new List<int>();

            string prompt = "Enter a series of numbers separated by a hyphen:";
            string userInput = utilities.GetUserInput(prompt);
            string[] splitInput = userInput.Split('-');

            foreach (string split in splitInput)
            {
                if (Int32.TryParse(split, out int value))
                {
                    list.Add(value);
                }
            }

            // This breaks if the user attempts to use a hyphen as a negative sign
            Console.WriteLine(list.Count == list.Distinct().Count() ? "No duplicates" : "Duplicate");

        }

        public void Exercise3()
        {
            List<int> list = new List<int>();

            string prompt = "Enter a time value in the 24-hour time format(e.g. 19:00):";
            string userInput = utilities.GetUserInput(prompt);
            string[] splitInput = userInput.Split(':');

            foreach (string split in splitInput)
            {
                if (Int32.TryParse(split, out int value))
                {
                    list.Add(value);
                }
            }
            bool checkValidity = true;
            if (list[0] > 23 || list[0] < 0 || list[1] > 59 || list[1] < 0) 
            {
                checkValidity = false;
            }

            Console.WriteLine(checkValidity ? "Ok" : "Invalid Time");
        }

        public void Exercise4()
        {
            List<string> list = new List<string>();

            string prompt = "Enter a few words separated by a space:";
            string userInput = utilities.GetUserInput(prompt);
            string[] splitInput = userInput.Split(' ');

            foreach (string split in splitInput)
            {
                string lowerSplit = split.ToLower();
                char firstLetter = Char.Parse(lowerSplit.Substring(0, 1).ToUpper());
                string pascalCaseWord = lowerSplit.Replace(lowerSplit[0], firstLetter);
                Console.Write(pascalCaseWord);
            }
        }
    }
}
