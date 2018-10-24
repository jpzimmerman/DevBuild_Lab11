using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuild.Utilities {
    class MenuHandling {

        public static void PrintMenuOptions(IList<object> menuOptions, [Optional]bool menuMode) {

            for (int i = 0; i < menuOptions.Count; i++) {
                Console.WriteLine((menuMode? $"{i + 1}.) " : "") + menuOptions[i]);
            }
        }

        public static uint SelectMenuOption(int numberOfOptions) {
            uint userSelection = 0;
            string userEntry = "";

            while ( !uint.TryParse(userEntry, out userSelection) || 
                    userSelection < 0 || 
                    userSelection > numberOfOptions) {
                UserInput.PromptUntilValidEntry($"Please enter a selection, 1-{numberOfOptions}: ", out userEntry, InformationType.Numeric);
            }
            return userSelection;
        }
    }
}