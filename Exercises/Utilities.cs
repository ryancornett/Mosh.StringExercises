using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh.StringExercises.Exercises
{
    public class Utilities
    {
        public string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string userInput = Console.ReadLine();
            Console.WriteLine($"You entered: {userInput}");
            return userInput;
        }

        public void InvalidEntry()
        {
            Console.Clear();
            Console.WriteLine("Invalid entry. Try again.");
            Console.WriteLine();
        }

        public void GetHeader()
        {
            string asciiArt = @"
    .|'''|    ||                                   '||''''|                                                    
    ||        ||            ''                      ||   .                              ''                     
    `|'''|, ''||''  '||''|  ||  `||''|,  .|''|,     ||'''|  \\  // .|''|, '||''| .|'',  ||  ('''' .|''|, ('''' 
     .   ||   ||     ||     ||   ||  ||  ||  ||     ||        ><   ||..||  ||    ||     ||   `'') ||..||  `'') 
     |...|'   `|..' .||.   .||. .||  ||. `|..||    .||....| //  \\ `|...  .||.   `|..' .||. `...' `|...  `...' 
                                             ||                                                                
                                          `..|'";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(asciiArt);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void GetMenu()
        {
            string[] choices = new string[6]
            {
                "1. Consecutive Integers Test",
                "2. Duplicate Integers Test",
                "3. Valid Time Format Test",
                "4. PascalCase Formatter",
                "5. Number of Vowels in Word",
                "0. Exit the Application"
            };
            int menuWidth = choices[0].Length;
            for (int i = 1; i < choices.Length; i++)
            {
                if (choices[i].Length > menuWidth)
                {
                    menuWidth = choices[i].Length;
                }
            }

            int padding = 5;
            // Account for lower kerning in a line consisting solely of asterisks
            int kernAdjustment = 6;

            StringBuilder menu = new StringBuilder();
            
            menu
                .Append(' ', padding)
                .Append('*', menuWidth + (menuWidth / kernAdjustment));
            foreach (string choice in choices)
            {
                menu
                    .AppendLine()
                    .Append(' ', padding)
                    .Append("* " + choice)
                    .Append(' ', menuWidth - choice.Length)
                    .Append(" *");
            };
            menu
            .AppendLine()
            .Append(' ', padding)
            .Append('*', menuWidth + (menuWidth / kernAdjustment))
            .AppendLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(menu);
            Console.ForegroundColor = ConsoleColor.White;

        }
    }


}
