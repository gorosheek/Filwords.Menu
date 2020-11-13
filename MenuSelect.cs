﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Filwords.Menu
{
    class MenuSelect
    {
        public static void Select()
        {
            int i = 1;
            ConsoleKeyInfo key;
            while (true)
            {
                key = Console.ReadKey(true);
                
                
                if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W)
                {
                    if (i == 1)
                    {
                        MenuScreen.PrintMenu(ConsoleColor.White, ConsoleColor.White, ConsoleColor.White, ConsoleColor.Red);
                        i = 4;
                    }
                    else if (i == 2)
                    {
                        MenuScreen.PrintMenu(ConsoleColor.Red, ConsoleColor.White, ConsoleColor.White, ConsoleColor.White);
                        i = 1;
                    }
                    else if (i == 3)
                    {
                        MenuScreen.PrintMenu(ConsoleColor.White, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.White);
                        i = 2;
                    }
                    else if (i == 4)
                    {
                        MenuScreen.PrintMenu(ConsoleColor.White, ConsoleColor.White, ConsoleColor.Red, ConsoleColor.White);
                        i = 3;
                    }
                    
                }
                else if (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S)
                {
                    if (i == 1)
                    {
                        MenuScreen.PrintMenu(ConsoleColor.White, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.White);
                        i = 2;
                    }
                    else if (i == 2)
                    {
                        MenuScreen.PrintMenu(ConsoleColor.White, ConsoleColor.White, ConsoleColor.Red, ConsoleColor.White);
                        i = 3;
                    }
                    else if (i == 3)
                    {
                        MenuScreen.PrintMenu(ConsoleColor.White, ConsoleColor.White, ConsoleColor.White, ConsoleColor.Red);
                        i = 4;
                    }
                    else if (i == 4)
                    {
                        MenuScreen.PrintMenu(ConsoleColor.Red, ConsoleColor.White, ConsoleColor.White, ConsoleColor.White);
                        i = 1;
                    }
                    
                }
                
            }
        }
    }
}
