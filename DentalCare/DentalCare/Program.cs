﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalCare
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

            //Application.Run(new ClientInfoView());
            //Application.Run(new DentistView());

            //Application.Run(new LoginView());
            Application.Run(new ReceptionistView());
            //Application.Run(new AdminView());
        }
    }
}
