
using Mosh.StringExercises.Exercises;
using System.Text;
using System.Xml.Serialization;

Exercises exercises = new Exercises();
// exercises.Exercise1();

Utilities utilities = new Utilities();

void ShowMenu()
{
    utilities.GetHeader();

    utilities.GetMenu();

    string prompt = "Please make a menu selection:";
    string userSelection = utilities.GetUserInput(prompt);
    int parsedUserSelection = 0;
    try
    {
        parsedUserSelection = Int32.Parse(userSelection);
    }
    catch (Exception ex)
    {
        utilities.InvalidEntry();
        ShowMenu();
    }

    switch (parsedUserSelection)
    {
        case 0:
            Environment.Exit(0); break;

        case 1:
            exercises.Exercise1(); break;

        case 2:
            exercises.Exercise2();
            break;

        case 3:
            exercises.Exercise3();
            break;

        case 4:
            exercises.Exercise4();
            break;

        case 5:
            throw new NotImplementedException();
            // exercises.Exercise5();
            break;

        default:
            utilities.InvalidEntry();
            break;
    }
}

ShowMenu();