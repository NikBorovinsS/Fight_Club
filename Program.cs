﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Fight_Club
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FightClubMainForm());

            FightClubMainForm view = new FightClubMainForm();
            IFightModel fmdl = new FightModel();

            IMainController cnt = new MainController(view, fmdl);

            Application.Run(view);
        }
    }
}
