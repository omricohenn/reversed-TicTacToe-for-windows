﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceWindows
{
    class Program
    {
        public static void Main()
        {
            StartGameForm startGame= new StartGameForm();

            startGame.ShowDialog();
        }
    }
}