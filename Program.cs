using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MVPDemo
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
            var view = new MainView();
            var model = new MainModel();
            var controller = new MainPresenter(view, model);
            Application.Run(view);
        }
    }
}
