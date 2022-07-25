using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Fancy_Console_Menu
{
    public class Menu
    {
        private int SelectIndex;
        private string[] Options;

        public Menu(string[] options)
        {
            Options = options;
            SelectIndex = 0;
        }

        private void DisplayOptions()
        {
            
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string prefix;
                if(i == SelectIndex)
                {
                    prefix = "*";
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = " ";
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }
                WriteLine($"{prefix}<< {currentOption} >>");
            }
            ResetColor();
        }

        public int Run()
        {
            ConsoleKey keyPressed;
            do
            {
                Clear();
                DisplayOptions();

                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;

                // Update SelectedIndex based on arrow keys
                if(keyPressed == ConsoleKey.UpArrow)
                {
                    SelectIndex--;
                    if(SelectIndex == -1)
                    {
                        SelectIndex = Options.Length - 1;
                    }
                }
                else if(keyPressed == ConsoleKey.DownArrow)
                {
                    SelectIndex++;
                    if(SelectIndex == Options.Length)
                    {
                        SelectIndex = 0;
                    }
                }
            }
            while(keyPressed != ConsoleKey.Enter);


            return SelectIndex;
        }

    }
}
