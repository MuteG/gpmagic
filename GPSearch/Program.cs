using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GP.GPMagic.GPSearch.UI;

namespace GP.GPMagic.GPSearch
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
