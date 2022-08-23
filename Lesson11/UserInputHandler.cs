using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    internal class UserInputHandler
    {
        internal bool Iterate { get; set; } = false;
        internal string UserInput { get; private set; }

        private string[] _validStates = new string[] { "v", "b", "g", "x"};

        internal void CheckInput(string userInput)
        {
            if (!_validStates.Contains(userInput))
            {
                Iterate = true;
                throw new InvalidUserInputException("Invalid option! Try again...");
            }
            if (userInput == "x")
            {
                Iterate = false;
                throw new UserHaltException("Application was halted by user...");
            }
            Iterate = true;
            UserInput = userInput;
        }
    }
}
