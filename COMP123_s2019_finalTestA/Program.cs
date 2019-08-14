﻿using COMP123_s2019_finalTestA.Objects;
using COMP123_s2019_finalTestA.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_s2019_finalTestA
{
    static class Program
    {
        public static HeroGenerator heroGenerator;
        public static MasterForm masterForm;
        public static Hero character;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            heroGenerator = new HeroGenerator();
            masterForm = new MasterForm();
            character = new Hero();




            Application.Run(heroGenerator);
        }
    }
}
