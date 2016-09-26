using System;
using System.Windows.Forms;

namespace SomeCardGames
{
    internal static class Program
    {
        public static Form1 MainForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm = new Form1();
            SomeCardGamesAPI.Utility.VariableStorage.CollectForm(MainForm);

            Application.Run(MainForm);
        }
    }
}