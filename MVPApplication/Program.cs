using System;
using System.Windows.Forms;
using MVPApplication.Model;
using MVPApplication.Presenter;
using MVPApplication.View;

namespace MVPApplication
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

            var listView = new ListViewForm();
            var model = new DataModel();
            var listPresenter = new ListViewFormPresenter(listView, model);

            Application.Run(listView);
        }
    }
}
