﻿using SchoolManageSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManageSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initialize database table
            DatabaseInitializer.CreateTables();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //MainForm mf = new MainForm();
            //Application.Run(mf);
            Application.Run(new MainForm());
        }
    }
}
