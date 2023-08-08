
using Mosh.StringExercises.Exercises;

Utilities utilities = new Utilities();
Exercise exercise = new Exercise();

void ShowMenu()
{
    utilities.GetHeader();

    utilities.GetMenu();

    string prompt = "Please make a menu selection:";
    string userSelection = utilities.GetUserInput(prompt);
    int parsedUserSelection = -1;
    try
    {
        parsedUserSelection = Int32.Parse(userSelection);
    }
    catch (Exception ex)
    {
        utilities.InvalidEntry();
        ShowMenu();
    }

    while (parsedUserSelection != 6)
    {
        switch (parsedUserSelection)
        {
            case 0:
                Environment.Exit(0); break;

            case 1:
                // TODO: Input validation on all exercises
                string exercisePrompt1 = "Enter a series of numbers separated by a hyphen:";
                string userInput1 = utilities.GetUserInput(exercisePrompt1);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(exercise.Exercise1(userInput1) ? "Consecutive" : "Not Consecutive");
                break;

            case 2:
                string exercisePrompt2 = "Enter a series of numbers separated by a hyphen:";
                string userInput2 = utilities.GetUserInput(exercisePrompt2);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(exercise.Exercise2(userInput2) ? "No duplicates" : "Duplicate(s)");
                break;

            case 3:
                string exercisePrompt3 = "Enter a time value in the 24-hour time format(e.g. 19:00):";
                string userInput3 = utilities.GetUserInput(exercisePrompt3);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(exercise.Exercise3(userInput3) ? "Ok" : "Invalid Time");
                break;

            case 4:
                string exercisePrompt4 = "Enter a few words separated by a space:";
                string userInput4 = utilities.GetUserInput(exercisePrompt4);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(exercise.Exercise4(userInput4));
                break;

            case 5:
                string exercisePrompt5 = "Enter an English word to see how many vowels it has:";
                string userInput5 = utilities.GetUserInput(exercisePrompt5);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(exercise.Exercise5(userInput5));
                break;

            default:
                utilities.InvalidEntry();
                break;
        }
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Press ENTER to continue.");
        Console.ForegroundColor = ConsoleColor.White;
        Console.ReadLine();
        Console.Clear();
        ShowMenu();
    }
}

ShowMenu();