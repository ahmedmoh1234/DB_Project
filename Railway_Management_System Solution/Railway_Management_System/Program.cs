﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Railway_Management_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
<<<<<<< Updated upstream:Railway_Management_System Solution/Railway_Management_System/Program.cs
            Application.Run(new Employee_Form());
           //Application.Run(new Manager_Form());
=======
            //Application.Run(new Employee_Form());
            //Application.Run(new Manager_Form());
            Application.Run(new Passenger_Form());
>>>>>>> Stashed changes:Railway_Management_System/Railway_Management_System/Program.cs
        }
    }
}
