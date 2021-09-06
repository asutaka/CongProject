using CongProject.Common;
using CongProject.Entities;
using CongProject.GuiEntity;
using CongProject.Model;
using System;
using System.Windows.Forms;

namespace CongProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            0.InitJson();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            UserConfigModel _model = 0.LoadJson();
            if (string.IsNullOrWhiteSpace(_model.Connection.Database))
            {
                Application.Run(new frmStart());
            }
            else
            {
                Constants.appDbContext = new AppDbContext(_model.Connection.ToConnectionString());
                var checkExists = Constants.appDbContext.Database.Exists();
                if(checkExists)
                    Application.Run(new frmMain());
                else
                    Application.Run(new frmStart());
            }
        }
    }
}
