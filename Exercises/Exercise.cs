namespace Mosh.StringExercises.Exercises
{
    public class Exercise
    {
        public bool Exercise1(string userInput)
        {
            List<int> list = new List<int>();
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
            return checkForContinuity;
        }

        public bool Exercise2(string userInput)
        {
            List<int> list = new List<int>();

            
            string[] splitInput = userInput.Split('-');

            foreach (string split in splitInput)
            {
                if (Int32.TryParse(split, out int value))
                {
                    list.Add(value);
                }
            }

            // This breaks if the user attempts to use a hyphen as a negative sign
            return list.Count == list.Distinct().Count();

        }

        public bool Exercise3(string userInput)
        {
            List<int> list = new List<int>();

            
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

            return checkValidity;
        }

        public string Exercise4(string userInput)
        {
            string[] splitInput = userInput.Split(" ");
            string pascalCaseWordDisplay = null;
            foreach (string split in splitInput)
            {
                string lowerSplit = split.ToLower();
                string firstLetter = lowerSplit.Substring(0, 1).ToUpper();
                lowerSplit = lowerSplit.Remove(0, 1);
                string pascalCaseWord = lowerSplit.Insert(0, firstLetter);
                pascalCaseWordDisplay += pascalCaseWord;
            }

            return pascalCaseWordDisplay;
        }

        public string Exercise5(string userInput)
        {
            char[] vowels = new char[6] { 'a', 'e', 'i', 'o', 'u', 'y' };
            int count = 0;
            for (int i = 0; i < userInput.Length; i++)
            {
                foreach (char c in vowels)
                {
                    if (c == userInput[i])
                    {
                        count++;
                    }
                }
            }
            return $"There {(count > 1 ? "are " + count + " vowels" : count == 0 ? "are no vowels" : "is 1 vowel")} in the word you entered.";
        }
    }
}
